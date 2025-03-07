namespace Turbo.Plugins.User
{
    using Turbo.Plugins.Default;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using SharpDX;
    using System.Windows.Forms;

    public class AutoGreaterRiftPathfindingPlugin : BasePlugin, IInGameWorldPainter
    {
        public bool Enabled { get; set; }
        public bool ShowPath { get; set; }
        public bool AutoNavigate { get; set; }
        public List<Vector2> PathPoints { get; set; }
        public Vector2 CurrentTarget { get; set; }
        public IMonster CurrentTarget_Monster { get; set; }
        public IActor CurrentTarget_ShrineOrPylon { get; set; }
        private float PathUpdateTimer { get; set; }
        private float PathUpdateInterval => 0.5f;
        private Vector2 NextWaypoint { get; set; }
        private Vector2 LastPosition { get; set; }
        private IWatch StuckTimer { get; set; }
        private float StuckThreshold => 2.0f;
        private int StuckTimeout => 3000;
        private HashSet<Vector2> ExploredPoints { get; set; }
        private HashSet<int> ExploredSceneIds { get; set; }
        public IWorldDecorator PathDecorator { get; private set; }
        public IWorldDecorator TargetDecorator { get; private set; }
        public IWorldDecorator NextPointDecorator { get; private set; }
        public float HealthThreshold { get; set; }
        public bool AutoUsePotion { get; set; }

        private List<string> DebugMessages = new List<string>();
        public IFont DebugFont { get; private set; }

        public AutoGreaterRiftPathfindingPlugin()
        {
            Enabled = true;
            ShowPath = true;
            AutoNavigate = false;
            PathPoints = new List<Vector2>();
            CurrentTarget = default(Vector2);
            CurrentTarget_Monster = null;
            CurrentTarget_ShrineOrPylon = null;
            PathUpdateTimer = 0;
            NextWaypoint = default(Vector2);
            LastPosition = default(Vector2);
            StuckTimer = Hud.Time.CreateWatch();
            ExploredPoints = new HashSet<Vector2>();
            ExploredSceneIds = new HashSet<int>();
            HealthThreshold = 0.3f;
            AutoUsePotion = true;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            PathDecorator = new WorldDecoratorCollection(
                new MapShapeDecorator(Hud)
                {
                    ShapePainter = new CircleShapePainter(Hud),
                    Brush = Hud.Render.CreateBrush(255, 0, 255, 0, 2),
                    Radius = 2.0f
                }
            ).Decorators.First();
            TargetDecorator = new WorldDecoratorCollection(
                new MapShapeDecorator(Hud)
                {
                    ShapePainter = new CircleShapePainter(Hud),
                    Brush = Hud.Render.CreateBrush(255, 255, 0, 0, 2),
                    Radius = 5.0f
                }
            ).Decorators.First();
            NextPointDecorator = new WorldDecoratorCollection(
                new MapShapeDecorator(Hud)
                {
                    ShapePainter = new CircleShapePainter(Hud),
                    Brush = Hud.Render.CreateBrush(255, 0, 0, 255, 2),
                    Radius = 3.0f
                }
            ).Decorators.First();
            DebugFont = Hud.Render.CreateFont("tahoma", 8, 255, 0, 255, 0, true, false, 255, 0, 0, 0, true);
        }

        private void AddDebugMessage(string message)
        {
            DebugMessages.Add($"{Hud.Game.CurrentGameTick}: {message}");
            if (DebugMessages.Count > 10) DebugMessages.RemoveAt(0);
        }

        public void PaintWorld(WorldLayer layer)
        {
            if (layer != WorldLayer.Ground || !Enabled || !ShowPath) return;

            foreach (var point in PathPoints)
            {
                PathDecorator.Paint(layer, null, new SimpleWorldCoordinate(point.X, point.Y, Hud.Game.Me.FloorCoordinate.Z), null);
            }
            if (CurrentTarget != default(Vector2))
            {
                TargetDecorator.Paint(layer, null, new SimpleWorldCoordinate(CurrentTarget.X, CurrentTarget.Y, Hud.Game.Me.FloorCoordinate.Z), null);
            }
            if (NextWaypoint != default(Vector2))
            {
                NextPointDecorator.Paint(layer, null, new SimpleWorldCoordinate(NextWaypoint.X, NextWaypoint.Y, Hud.Game.Me.FloorCoordinate.Z), null);
            }

            var uiElement = Hud.Render.GetUiElement("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.BoostWrapper");
            var uiRect = uiElement != null ? ToSharpDXRectangleF(uiElement.Rectangle) : new SharpDX.RectangleF(0, 0, Hud.Window.Size.Width, Hud.Window.Size.Height);
            for (int i = 0; i < DebugMessages.Count; i++)
            {
                DebugFont.DrawText(DebugMessages[i], uiRect.Left + 20, uiRect.Top + 300 + i * 20);
            }
        }

        private SharpDX.RectangleF ToSharpDXRectangleF(System.Drawing.RectangleF rect)
        {
            return new SharpDX.RectangleF(rect.X, rect.Y, rect.Width, rect.Height);
        }

        private class SimpleWorldCoordinate : IWorldCoordinate
        {
            public float X { get; private set; }
            public float Y { get; private set; }
            public float Z { get; private set; }

            public SimpleWorldCoordinate(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Vector3 ToVector3()
            {
                return new Vector3(X, Y, Z);
            }

            public bool Equals(IWorldCoordinate other)
            {
                return other != null && X == other.X && Y == other.Y && Z == other.Z;
            }

            public bool IsOnScreen(double radius)
            {
                return true; // 简化实现
            }

            public void Add(IWorldCoordinate coord)
            {
                X += coord.X;
                Y += coord.Y;
                Z += coord.Z;
            }

            public IWorldCoordinate Offset(float x, float y, float z)
            {
                return new SimpleWorldCoordinate(X + x, Y + y, Z + z);
            }

            public void Set(IWorldCoordinate coord)
            {
                X = coord.X;
                Y = coord.Y;
                Z = coord.Z;
            }

            public void Set(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public IScreenCoordinate ToScreenCoordinate(bool clampToScreen = false, bool force = false)
            {
                var screenCoord = Hud.Render.WorldToScreen(new Vector3(X, Y, Z), clampToScreen);
                return Hud.Render.CreateScreenCoordinate(screenCoord.X, screenCoord.Y);
            }

            public void SetScreenCoordinate(IScreenCoordinate coord, bool clampToScreen = false, bool force = false)
            {
                var worldCoord = Hud.Render.ScreenToWorld(coord.X, coord.Y);
                X = worldCoord.X;
                Y = worldCoord.Y;
                Z = Hud.Game.Me.FloorCoordinate.Z; // 假设 Z 不变
            }

            public float XYDistanceTo(IWorldCoordinate other)
            {
                return (float)Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
            }

            public float XYDistanceTo(float x, float y)
            {
                return (float)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
            }

            public float XYZDistanceTo(IWorldCoordinate other)
            {
                return (float)Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2) + Math.Pow(Z - other.Z, 2));
            }

            public float XYZDistanceTo(float x, float y, float z)
            {
                return (float)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2) + Math.Pow(Z - z, 2));
            }

            public float ZDiffTo(IWorldCoordinate other)
            {
                return Math.Abs(Z - other.Z);
            }

            public string ToStringCompact()
            {
                return $"[{X:F1}, {Y:F1}, {Z:F1}]";
            }

            public string ToStringCompactPrecise()
            {
                return $"[{X:F3}, {Y:F3}, {Z:F3}]";
            }

            public bool IsValid => !float.IsNaN(X) && !float.IsNaN(Y) && !float.IsNaN(Z);
        }

        public void Update(IController hud)
        {
            if (!Enabled || !Hud.Game.IsInGame) return;

            AddDebugMessage("Pathfinding Update");
            PathUpdateTimer += 0.1f;
            if (PathUpdateTimer >= PathUpdateInterval)
            {
                PathUpdateTimer = 0;
                UpdatePath();
            }
            if (AutoNavigate)
                MoveToTarget();
        }

        public void UpdatePath()
        {
            if (!Enabled || !AutoNavigate || !Hud.Game.IsInGame) return;

            var playerPos = new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y);
            RecordExploredArea(playerPos);

            if (CurrentTarget != default(Vector2) && Vector2.Distance(playerPos, CurrentTarget) > 10.0f)
            {
                PathPoints = FindPathAStar(playerPos, CurrentTarget);
                UpdateNextWaypoint(playerPos);
                return;
            }

            if (Hud.Game.Me.IsInTown) return;

            if (FindAndTargetShrine())
            {
                PathPoints = FindPathAStar(playerPos, new Vector2(CurrentTarget_ShrineOrPylon.FloorCoordinate.X, CurrentTarget_ShrineOrPylon.FloorCoordinate.Y));
                return;
            }
            if (FindAndTargetMonster())
            {
                PathPoints = FindPathAStar(playerPos, new Vector2(CurrentTarget_Monster.FloorCoordinate.X, CurrentTarget_Monster.FloorCoordinate.Y));
                return;
            }
            var exit = FindRiftExit();
            if (exit != null)
            {
                CurrentTarget = new Vector2(exit.FloorCoordinate.X, exit.FloorCoordinate.Y);
                PathPoints = FindPathAStar(playerPos, CurrentTarget);
                return;
            }
            if (CurrentTarget == default(Vector2) || Vector2.Distance(playerPos, CurrentTarget) < 10.0f)
            {
                FindNewExplorationTarget();
                if (CurrentTarget != default(Vector2))
                    PathPoints = FindPathAStar(playerPos, CurrentTarget);
            }
            UpdateNextWaypoint(playerPos);
        }

        public void MoveToTarget()
        {
            if (!Enabled || !AutoNavigate || !Hud.Game.IsInGame) return;

            AddDebugMessage("MoveToTarget 已调用");
            var playerPos = new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y);

            if (Vector2.Distance(playerPos, LastPosition) < StuckThreshold && StuckTimer.ElapsedMilliseconds > StuckTimeout)
            {
                HandleStuck(playerPos);
                return;
            }
            LastPosition = playerPos;
            StuckTimer.Restart();

            if (CurrentTarget != default(Vector2))
            {
                var targetPos = CurrentTarget;
                AddDebugMessage("移动到目标: " + targetPos.X + ", " + targetPos.Y);
                if (Vector2.Distance(playerPos, targetPos) <= 10.0f)
                {
                    Hud.Interaction.MouseMove(targetPos.X, targetPos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Left);
                    Hud.Interaction.MouseUp(MouseButtons.Left);
                    CurrentTarget = default(Vector2);
                }
                else
                {
                    Hud.Interaction.MouseMove(targetPos.X, targetPos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Right);
                    Hud.Interaction.MouseUp(MouseButtons.Right);
                }
                return;
            }

            if (NextWaypoint != default(Vector2))
            {
                AddDebugMessage("移动到路径点: " + NextWaypoint.X + ", " + NextWaypoint.Y);
                Hud.Interaction.MouseMove(NextWaypoint.X, NextWaypoint.Y, Hud.Game.Me.FloorCoordinate.Z);
                Hud.Interaction.MouseDown(MouseButtons.Right);
                Hud.Interaction.MouseUp(MouseButtons.Right);
            }
        }

        private bool FindAndTargetShrine()
        {
            var shrineOrPylon = Hud.Game.Actors.FirstOrDefault(a => (a.SnoActor.Kind == ActorKind.Shrine || a.SnoActor.Sno == (ActorSnoEnum)208706) &&
                                                                  !a.IsDisabled && !a.IsOperated &&
                                                                  Vector2.Distance(new Vector2(a.FloorCoordinate.X, a.FloorCoordinate.Y),
                                                                                   new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y)) < 150.0f);
            if (shrineOrPylon != null)
            {
                CurrentTarget_ShrineOrPylon = shrineOrPylon;
                CurrentTarget = new Vector2(shrineOrPylon.FloorCoordinate.X, shrineOrPylon.FloorCoordinate.Y);
                return true;
            }
            return false;
        }

        private bool FindAndTargetMonster()
        {
            var monster = Hud.Game.AliveMonsters.Where(m => m.Rarity != ActorRarity.Normal &&
                                                           Vector2.Distance(new Vector2(m.FloorCoordinate.X, m.FloorCoordinate.Y),
                                                                            new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y)) < 150.0f)
                .OrderBy(m => Vector2.Distance(new Vector2(m.FloorCoordinate.X, m.FloorCoordinate.Y),
                                               new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y)))
                .FirstOrDefault();
            if (monster != null)
            {
                CurrentTarget_Monster = monster;
                CurrentTarget = new Vector2(monster.FloorCoordinate.X, monster.FloorCoordinate.Y);
                return true;
            }
            return false;
        }

        private IMarker FindRiftExit()
        {
            return Hud.Game.Markers.FirstOrDefault(m => m.SnoActor.Sno == (ActorSnoEnum)403989);
        }

        private void FindNewExplorationTarget()
        {
            var currentScene = Hud.Game.Me.Scene;
            if (currentScene != null && !ExploredSceneIds.Contains((int)currentScene.SceneId))
            {
                CurrentTarget = new Vector2(Hud.Game.Me.FloorCoordinate.X + 50, Hud.Game.Me.FloorCoordinate.Y + 50);
            }
        }

        private void RecordExploredArea(Vector2 position)
        {
            ExploredPoints.Add(new Vector2((float)Math.Round(position.X / 10.0f) * 10.0f, (float)Math.Round(position.Y / 10.0f) * 10.0f));
            var currentScene = Hud.Game.Me.Scene;
            if (currentScene != null && !ExploredSceneIds.Contains((int)currentScene.SceneId))
            {
                ExploredSceneIds.Add((int)currentScene.SceneId);
            }
        }

        private void UpdateNextWaypoint(Vector2 playerPos)
        {
            if (PathPoints == null || PathPoints.Count == 0)
            {
                NextWaypoint = default(Vector2);
                return;
            }
            NextWaypoint = PathPoints.FirstOrDefault(p => Vector2.Distance(playerPos, p) > 5.0f);
        }

        private void HandleStuck(Vector2 playerPos)
        {
            var nearbyPoint = ExploredPoints.Where(p => Vector2.Distance(p, playerPos) > 20.0f && Vector2.Distance(p, playerPos) < 50.0f)
                                           .OrderBy(p => new Random().Next())
                                           .FirstOrDefault();
            if (nearbyPoint != default(Vector2))
            {
                CurrentTarget = nearbyPoint;
                PathPoints = FindPathAStar(playerPos, CurrentTarget);
                StuckTimer.Restart();
            }
        }

        private bool IsWalkable(Vector2 position)
        {
            var scene = Hud.Game.Me.Scene;
            if (scene == null) return false;
            return !Hud.Game.Actors.Any(a => a != null &&
                                            a.SnoActor != null &&
                                            a.SnoActor.NameLocalized != null &&
                                            a.SnoActor.NameLocalized.Contains("Wall") &&
                                            Vector2.Distance(new Vector2(a.FloorCoordinate.X, a.FloorCoordinate.Y), position) < 5.0f);
        }

        public List<Vector2> FindPathAStar(Vector2 start, Vector2 goal)
        {
            var openSet = new HashSet<Vector2> { start };
            var closedSet = new HashSet<Vector2>();
            var cameFrom = new Dictionary<Vector2, Vector2>();
            var gScore = new Dictionary<Vector2, float> { [start] = 0 };
            var fScore = new Dictionary<Vector2, float> { [start] = Vector2.Distance(start, goal) };

            while (openSet.Count > 0)
            {
                var current = openSet.OrderBy(n => fScore.ContainsKey(n) ? fScore[n] : float.MaxValue).First();
                if (Vector2.Distance(current, goal) < 5.0f)
                {
                    return ReconstructPath(cameFrom, current);
                }
                openSet.Remove(current);
                closedSet.Add(current);

                foreach (var neighbor in GetNeighbors(current))
                {
                    if (closedSet.Contains(neighbor) || !IsWalkable(neighbor)) continue;

                    var tentativeGScore = gScore[current] + Vector2.Distance(current, neighbor);
                    if (!openSet.Contains(neighbor))
                    {
                        openSet.Add(neighbor);
                    }
                    else if (tentativeGScore >= (gScore.ContainsKey(neighbor) ? gScore[neighbor] : float.MaxValue))
                    {
                        continue;
                    }
                    cameFrom[neighbor] = current;
                    gScore[neighbor] = tentativeGScore;
                    fScore[neighbor] = gScore[neighbor] + Vector2.Distance(neighbor, goal);
                }
            }
            return new List<Vector2>();
        }

        private List<Vector2> ReconstructPath(Dictionary<Vector2, Vector2> cameFrom, Vector2 current)
        {
            var path = new List<Vector2> { current };
            while (cameFrom.ContainsKey(current))
            {
                current = cameFrom[current];
                path.Add(current);
            }
            path.Reverse();
            return path;
        }

        private IEnumerable<Vector2> GetNeighbors(Vector2 position)
        {
            var step = 5.0f;
            return new List<Vector2>
            {
                new Vector2(position.X + step, position.Y),
                new Vector2(position.X - step, position.Y),
                new Vector2(position.X, position.Y + step),
                new Vector2(position.X, position.Y - step),
                new Vector2(position.X + step, position.Y + step),
                new Vector2(position.X + step, position.Y - step),
                new Vector2(position.X - step, position.Y + step),
                new Vector2(position.X - step, position.Y - step)
            };
        }

        public void ToggleAutoPotion()
        {
            AutoUsePotion = !AutoUsePotion;
        }

        public void SetHealthThreshold(float threshold)
        {
            HealthThreshold = threshold;
        }

        public void ResetClickedShrines()
        {
            CurrentTarget_ShrineOrPylon = null;
        }
    }
}
namespace Turbo.Plugins.User
{
    using Turbo.Plugins.Default;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using SharpDX;
    using System.Windows.Forms;
    using System.IO;

    public class AutoGreaterRiftPathfindingPlugin : BasePlugin, IInGameWorldPainter, IAfterCollectHandler
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
        private string LogFilePath => Path.Combine(Directory.GetCurrentDirectory(), "AutoGreaterRiftPathfindingPlugin_Log.txt");
        
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
            ExploredPoints = new HashSet<Vector2>();
            ExploredSceneIds = new HashSet<int>();
            HealthThreshold = 0.3f;
            AutoUsePotion = true;
        }
        
        public override void Load(IController hud)
        {
            base.Load(hud);
            StuckTimer = Hud.Time.CreateWatch();
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
            if (File.Exists(LogFilePath)) File.Delete(LogFilePath);
        }

        private void AddDebugMessage(string message)
        {
            string timestampedMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{Hud.Game.CurrentGameTick}] {message}";
            DebugMessages.Add(timestampedMessage);
            if (DebugMessages.Count > 15) DebugMessages.RemoveAt(0);
            try
            {
                File.AppendAllText(LogFilePath, timestampedMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Hud.Sound.Speak("日志写入失败: " + ex.Message);
            }
        }

        public void PaintWorld(WorldLayer layer)
        {
            if (layer != WorldLayer.Ground || !Enabled) return;

            var uiElement = Hud.Render.GetUiElement("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.BoostWrapper");
            var uiRect = uiElement != null ? ToSharpDXRectangleF(uiElement.Rectangle) : new SharpDX.RectangleF(0, 0, Hud.Window.Size.Width, Hud.Window.Size.Height);
            
            DebugFont.DrawText($"自动导航: {(AutoNavigate ? "开启" : "关闭")}", uiRect.Left + 20, uiRect.Top + 250);
            DebugFont.DrawText($"显示路径: {(ShowPath ? "开启" : "关闭")}", uiRect.Left + 20, uiRect.Top + 270);
            DebugFont.DrawText($"自动喝药: {(AutoUsePotion ? "开启" : "关闭")} (阈值: {HealthThreshold*100}%)", uiRect.Left + 20, uiRect.Top + 290);
            
            if (CurrentTarget != default(Vector2))
                DebugFont.DrawText($"当前目标: {CurrentTarget.X:F1}, {CurrentTarget.Y:F1}", uiRect.Left + 20, uiRect.Top + 310);
            else if (CurrentTarget_Monster != null)
                DebugFont.DrawText($"当前目标: 怪物 ({CurrentTarget_Monster.FloorCoordinate.X:F1}, {CurrentTarget_Monster.FloorCoordinate.Y:F1})", uiRect.Left + 20, uiRect.Top + 310);
            else if (CurrentTarget_ShrineOrPylon != null)
                DebugFont.DrawText($"当前目标: 神龛/塔 ({CurrentTarget_ShrineOrPylon.FloorCoordinate.X:F1}, {CurrentTarget_ShrineOrPylon.FloorCoordinate.Y:F1})", uiRect.Left + 20, uiRect.Top + 310);
            
            DebugFont.DrawText($"路径点数量: {PathPoints.Count}", uiRect.Left + 20, uiRect.Top + 330);
            
            for (int i = 0; i < DebugMessages.Count; i++)
            {
                DebugFont.DrawText(DebugMessages[i], uiRect.Left + 20, uiRect.Top + 350 + i * 20);
            }

            if (!ShowPath) return;
            
            foreach (var point in PathPoints)
            {
                var coord = Hud.Window.CreateWorldCoordinate(point.X, point.Y, Hud.Game.Me.FloorCoordinate.Z);
                ((IWorldDecorator)PathDecorator).Paint(null, coord, null);
            }
            if (CurrentTarget != default(Vector2))
            {
                var coord = Hud.Window.CreateWorldCoordinate(CurrentTarget.X, CurrentTarget.Y, Hud.Game.Me.FloorCoordinate.Z);
                ((IWorldDecorator)TargetDecorator).Paint(null, coord, null);
            }
            if (NextWaypoint != default(Vector2))
            {
                var coord = Hud.Window.CreateWorldCoordinate(NextWaypoint.X, NextWaypoint.Y, Hud.Game.Me.FloorCoordinate.Z);
                ((IWorldDecorator)NextPointDecorator).Paint(null, coord, null);
            }
        }

        private SharpDX.RectangleF ToSharpDXRectangleF(System.Drawing.RectangleF rect)
        {
            return new SharpDX.RectangleF(rect.X, rect.Y, rect.Width, rect.Height);
        }

        public void AfterCollect()
        {
            Update(Hud);
        }

        public void Update(IController hud)
        {
            if (!Enabled || !Hud.Game.IsInGame)
            {
                AddDebugMessage("Update 未执行：条件不满足");
                return;
            }
            
            var playerPos = new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y);
            AddDebugMessage($"玩家位置: ({playerPos.X:F1}, {playerPos.Y:F1}), 生命值: {Hud.Game.Me.Defense.HealthPct:P0}");
            
            if (AutoUsePotion && Hud.Game.Me.Defense.HealthPct < HealthThreshold)
            {
                AddDebugMessage($"生命值低于阈值 {HealthThreshold*100}%，尝试使用药水");
                if (!Hud.Game.Me.Powers.HealthPotionSkill.IsOnCooldown)
                {
                    var cursorX = Hud.Window.CursorX;
                    var cursorY = Hud.Window.CursorY;
                    
                    Hud.Interaction.DoAction(ActionKey.Heal);
                    
                    Hud.Interaction.MouseMove(cursorX, cursorY);
                    
                    AddDebugMessage("使用药水");
                }
                else
                {
                    AddDebugMessage("药水冷却中");
                }
            }
            
            PathUpdateTimer += 0.1f;
            if (PathUpdateTimer >= PathUpdateInterval)
            {
                PathUpdateTimer = 0;
                UpdatePath();
            }
            if (AutoNavigate)
            {
                AddDebugMessage("AutoNavigate 为 true，调用 MoveToTarget");
                MoveToTarget();
            }
            else
            {
                AddDebugMessage("AutoNavigate 为 false");
            }
        }

        public void MoveToTarget()
        {
            if (!Enabled || !AutoNavigate || !Hud.Game.IsInGame) 
            {
                AddDebugMessage("MoveToTarget 未执行：条件不满足");
                return;
            }

            AddDebugMessage("MoveToTarget 已调用");
            var playerPos = new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y);

            if (Vector2.Distance(playerPos, LastPosition) < StuckThreshold && StuckTimer.ElapsedMilliseconds > StuckTimeout)
            {
                AddDebugMessage($"检测到卡住：当前位置 ({playerPos.X:F1}, {playerPos.Y:F1})，上次位置 ({LastPosition.X:F1}, {LastPosition.Y:F1})，距离 {Vector2.Distance(playerPos, LastPosition):F1}，时间 {StuckTimer.ElapsedMilliseconds}ms");
                HandleStuck(playerPos);
                return;
            }
            LastPosition = playerPos;
            StuckTimer.Restart();

            // 处理怪物目标
            if (CurrentTarget_Monster != null)
            {
                if (!CurrentTarget_Monster.IsAlive || CurrentTarget_Monster.IsDisabled)
                {
                    AddDebugMessage($"目标怪物已死亡或被禁用，重置目标");
                    CurrentTarget_Monster = null;
                    CurrentTarget = default(Vector2);
                    return;
                }
                
                var monsterPos = new Vector2(CurrentTarget_Monster.FloorCoordinate.X, CurrentTarget_Monster.FloorCoordinate.Y);
                var distance = Vector2.Distance(playerPos, monsterPos);
                AddDebugMessage($"移动到怪物: {CurrentTarget_Monster.SnoMonster.NameLocalized}，位置: ({monsterPos.X:F1}, {monsterPos.Y:F1})，距离: {distance:F1}");
                
                if (distance <= 40.0f)  // 攻击范围
                {
                    AddDebugMessage($"怪物在攻击范围内，点击攻击");
                    Hud.Interaction.MouseMove(monsterPos.X, monsterPos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Left);
                    Hud.Interaction.MouseUp(MouseButtons.Left);
                }
                else
                {
                    AddDebugMessage($"怪物不在攻击范围内，移动接近");
                    Hud.Interaction.MouseMove(monsterPos.X, monsterPos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Right);
                    Hud.Interaction.MouseUp(MouseButtons.Right);
                }
                return;
            }

            // 处理神龛/塔目标
            if (CurrentTarget_ShrineOrPylon != null)
            {
                if (CurrentTarget_ShrineOrPylon.IsDisabled || CurrentTarget_ShrineOrPylon.IsOperated)
                {
                    AddDebugMessage($"目标神龛/塔已被使用或禁用，重置目标");
                    CurrentTarget_ShrineOrPylon = null;
                    CurrentTarget = default(Vector2);
                    return;
                }
                
                var shrinePos = new Vector2(CurrentTarget_ShrineOrPylon.FloorCoordinate.X, CurrentTarget_ShrineOrPylon.FloorCoordinate.Y);
                var distance = Vector2.Distance(playerPos, shrinePos);
                AddDebugMessage($"移动到神龛/塔: {CurrentTarget_ShrineOrPylon.SnoActor.NameLocalized}，位置: ({shrinePos.X:F1}, {shrinePos.Y:F1})，距离: {distance:F1}");
                
                if (distance <= 10.0f)  // 点击范围
                {
                    AddDebugMessage($"神龛/塔在点击范围内，点击使用");
                    Hud.Interaction.MouseMove(shrinePos.X, shrinePos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Left);
                    Hud.Interaction.MouseUp(MouseButtons.Left);
                    CurrentTarget_ShrineOrPylon = null;
                    CurrentTarget = default(Vector2);
                }
                else
                {
                    AddDebugMessage($"神龛/塔不在点击范围内，移动接近");
                    Hud.Interaction.MouseMove(shrinePos.X, shrinePos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Right);
                    Hud.Interaction.MouseUp(MouseButtons.Right);
                }
                return;
            }

            // 处理普通目标点
            if (CurrentTarget != default(Vector2))
            {
                var targetPos = CurrentTarget;
                var distance = Vector2.Distance(playerPos, targetPos);
                AddDebugMessage($"移动到目标点: ({targetPos.X:F1}, {targetPos.Y:F1}), 距离: {distance:F1}");
                if (distance <= 10.0f)
                {
                    AddDebugMessage("已到达目标点，点击目标");
                    Hud.Interaction.MouseMove(targetPos.X, targetPos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Left);
                    Hud.Interaction.MouseUp(MouseButtons.Left);
                    CurrentTarget = default(Vector2);
                }
                else
                {
                    AddDebugMessage("未到达目标点，继续移动");
                    Hud.Interaction.MouseMove(targetPos.X, targetPos.Y, Hud.Game.Me.FloorCoordinate.Z);
                    Hud.Interaction.MouseDown(MouseButtons.Right);
                    Hud.Interaction.MouseUp(MouseButtons.Right);
                }
                return;
            }

            // 处理路径点
            if (NextWaypoint != default(Vector2))
            {
                var distance = Vector2.Distance(playerPos, NextWaypoint);
                AddDebugMessage($"移动到路径点: ({NextWaypoint.X:F1}, {NextWaypoint.Y:F1}), 距离: {distance:F1}");
                Hud.Interaction.MouseMove(NextWaypoint.X, NextWaypoint.Y, Hud.Game.Me.FloorCoordinate.Z);
                Hud.Interaction.MouseDown(MouseButtons.Right);
                Hud.Interaction.MouseUp(MouseButtons.Right);
            }
            else
            {
                AddDebugMessage("没有可用的路径点");
            }
        }

        public void UpdatePath()
        {
            if (!Enabled || !AutoNavigate || !Hud.Game.IsInGame) 
            {
                AddDebugMessage("UpdatePath 未执行：条件不满足");
                return;
            }

            var playerPos = new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y);
            RecordExploredArea(playerPos);

            if (CurrentTarget != default(Vector2) && Vector2.Distance(playerPos, CurrentTarget) > 10.0f)
            {
                AddDebugMessage($"继续前往当前目标: ({CurrentTarget.X:F1}, {CurrentTarget.Y:F1}), 距离: {Vector2.Distance(playerPos, CurrentTarget):F1}");
                PathPoints = FindPathAStar(playerPos, CurrentTarget);
                UpdateNextWaypoint(playerPos);
                AddDebugMessage($"路径点数量: {PathPoints.Count}");
                return;
            }

            if (Hud.Game.Me.IsInTown)
            {
                AddDebugMessage("玩家在城镇中，尝试寻找方尖碑");
                if (FindAndTargetObelisk())
                {
                    PathPoints = FindPathAStar(playerPos, CurrentTarget);
                    AddDebugMessage($"找到方尖碑，计算路径，路径点数量: {PathPoints.Count}");
                    return;
                }
                else
                {
                    AddDebugMessage("未找到方尖碑");
                }
            }

            AddDebugMessage("尝试寻找神龛或塔");
            if (FindAndTargetShrine())
            {
                PathPoints = FindPathAStar(playerPos, new Vector2(CurrentTarget_ShrineOrPylon.FloorCoordinate.X, CurrentTarget_ShrineOrPylon.FloorCoordinate.Y));
                AddDebugMessage($"找到神龛或塔，计算路径，路径点数量: {PathPoints.Count}");
                return;
            }
            
            AddDebugMessage("尝试寻找怪物");
            if (FindAndTargetMonster())
            {
                PathPoints = FindPathAStar(playerPos, new Vector2(CurrentTarget_Monster.FloorCoordinate.X, CurrentTarget_Monster.FloorCoordinate.Y));
                AddDebugMessage($"找到怪物，计算路径，路径点数量: {PathPoints.Count}");
                return;
            }
            
            AddDebugMessage("尝试寻找秘境出口");
            var exit = FindRiftExit();
            if (exit != null)
            {
                CurrentTarget = new Vector2(exit.FloorCoordinate.X, exit.FloorCoordinate.Y);
                PathPoints = FindPathAStar(playerPos, CurrentTarget);
                AddDebugMessage($"找到秘境出口，计算路径，路径点数量: {PathPoints.Count}");
                return;
            }
            
            if (CurrentTarget == default(Vector2) || Vector2.Distance(playerPos, CurrentTarget) < 10.0f)
            {
                AddDebugMessage("没有目标或已到达目标，寻找新的探索目标");
                FindNewExplorationTarget();
                if (CurrentTarget != default(Vector2))
                {
                    PathPoints = FindPathAStar(playerPos, CurrentTarget);
                    AddDebugMessage($"找到新探索目标，计算路径，路径点数量: {PathPoints.Count}");
                }
                else
                {
                    AddDebugMessage("未找到新探索目标");
                }
            }
            UpdateNextWaypoint(playerPos);
        }

        private bool FindAndTargetObelisk()
        {
            AddDebugMessage("开始寻找方尖碑");
            var obelisk = Hud.Game.Actors.FirstOrDefault(a => a.SnoActor.Sno == ActorSnoEnum._x1_openworld_lootrunobelisk_b &&
                                                    !a.IsDisabled && !a.IsOperated &&
                                                    Vector2.Distance(new Vector2(a.FloorCoordinate.X, a.FloorCoordinate.Y),
                                                                     new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y)) < 150.0f);
            if (obelisk != null)
            {
                CurrentTarget_ShrineOrPylon = obelisk;
                CurrentTarget = new Vector2(obelisk.FloorCoordinate.X, obelisk.FloorCoordinate.Y);
                AddDebugMessage($"找到方尖碑，位置: ({CurrentTarget.X:F1}, {CurrentTarget.Y:F1}), 距离: {Vector2.Distance(new Vector2(Hud.Game.Me.FloorCoordinate.X, Hud.Game.Me.FloorCoordinate.Y), CurrentTarget):F1}");
                return true;
            }
            AddDebugMessage("未找到方尖碑");
            return false;
        }

        private bool FindAndTargetShrine()
        {
            AddDebugMessage("开始寻找神龛或塔");
            var shrine = Hud.Game.Actors.Where(a => a.SnoActor.Kind == ActorKind.Shrine && !a.IsOperated && !a.IsDisabled)
                .OrderBy(a => a.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate))
                .FirstOrDefault();
            if (shrine != null)
            {
                CurrentTarget_ShrineOrPylon = shrine;
                CurrentTarget = new Vector2(shrine.FloorCoordinate.X, shrine.FloorCoordinate.Y);
                AddDebugMessage($"找到神龛或塔，类型: {shrine.SnoActor.NameLocalized}，位置: ({CurrentTarget.X:F1}, {CurrentTarget.Y:F1}), 距离: {shrine.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate):F1}");
                return true;
            }
            CurrentTarget_ShrineOrPylon = null;
            AddDebugMessage("未找到神龛或塔");
            return false;
        }
        
        private bool FindAndTargetMonster()
        {
            AddDebugMessage("开始寻找怪物");
            var monster = Hud.Game.AliveMonsters.Where(m => m.Rarity != ActorRarity.Normal)
                .OrderBy(m => m.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate))
                .FirstOrDefault();
            if (monster != null)
            {
                CurrentTarget_Monster = monster;
                CurrentTarget = new Vector2(monster.FloorCoordinate.X, monster.FloorCoordinate.Y);
                AddDebugMessage($"找到怪物，类型: {monster.SnoMonster.NameLocalized}，稀有度: {monster.Rarity}，位置: ({CurrentTarget.X:F1}, {CurrentTarget.Y:F1}), 距离: {monster.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate):F1}");
                return true;
            }
            CurrentTarget_Monster = null;
            AddDebugMessage("未找到怪物");
            return false;
        }
        
        private IActor FindRiftExit()
        {
            var exit = Hud.Game.Actors.FirstOrDefault(a => a.SnoActor.Kind == ActorKind.Portal && a.SnoActor.Code.Contains("RiftPortal"));
            if (exit != null)
            {
                AddDebugMessage($"找到秘境出口，距离: {exit.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate)}");
            }
            return exit;
        }

        private void FindNewExplorationTarget()
        {
            // 临时禁用 Scenes 相关功能
            // var unexploredScenes = Hud.Game.Scenes
            //     .Where(s => !ExploredSceneIds.Contains(s.SceneHash) && s.NavMesh != null)
            //     .OrderBy(s => s.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate))
            //     .ToList();
            //
            // if (unexploredScenes.Any())
            // {
            //     var targetScene = unexploredScenes.First();
            //     CurrentTarget = new Vector2(targetScene.FloorCoordinate.X, targetScene.FloorCoordinate.Y);
            //     AddDebugMessage($"找到新探索目标: {CurrentTarget.X}, {CurrentTarget.Y}");
            // }
            // else
            // {
                CurrentTarget = default(Vector2);
                AddDebugMessage("无新探索目标（Scenes 不可用，跳过探索）");
            // }
        }

        public List<Vector2> FindPathAStar(Vector2 start, Vector2 goal)
        {
            var openSet = new PriorityQueue<Vector2>();
            var cameFrom = new Dictionary<Vector2, Vector2>();
            var gScore = new Dictionary<Vector2, float>();
            var fScore = new Dictionary<Vector2, float>();

            openSet.Enqueue(start, 0);
            gScore[start] = 0;
            fScore[start] = Heuristic(start, goal);

            while (openSet.Count > 0)
            {
                var current = openSet.Dequeue();
                if (Vector2.Distance(current, goal) < 10.0f)
                    return ReconstructPath(cameFrom, current);

                foreach (var neighbor in GetNeighbors(current))
                {
                    if (!IsWalkable(neighbor)) continue;

                    var tentativeGScore = gScore[current] + Vector2.Distance(current, neighbor);
                    if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentativeGScore;
                        fScore[neighbor] = gScore[neighbor] + Heuristic(neighbor, goal);
                        if (!openSet.Contains(neighbor))
                            openSet.Enqueue(neighbor, fScore[neighbor]);
                    }
                }
            }
            AddDebugMessage("未找到路径");
            return new List<Vector2>();
        }

        private float Heuristic(Vector2 a, Vector2 b)
        {
            return Vector2.Distance(a, b);
        }

        private List<Vector2> GetNeighbors(Vector2 point)
        {
            var neighbors = new List<Vector2>();
            float step = 10.0f;
            neighbors.Add(new Vector2(point.X + step, point.Y));
            neighbors.Add(new Vector2(point.X - step, point.Y));
            neighbors.Add(new Vector2(point.X, point.Y + step));
            neighbors.Add(new Vector2(point.X, point.Y - step));
            neighbors.Add(new Vector2(point.X + step, point.Y + step));
            neighbors.Add(new Vector2(point.X - step, point.Y - step));
            neighbors.Add(new Vector2(point.X + step, point.Y - step));
            neighbors.Add(new Vector2(point.X - step, point.Y + step));
            return neighbors;
        }

        private bool IsWalkable(Vector2 point)
        {
            // 临时禁用 Scenes 相关功能
            // var scene = Hud.Game.Scenes.FirstOrDefault(s => s.NavMesh != null && s.NavMesh.IsInMesh(point.X, point.Y));
            // return scene != null && scene.NavMesh.IsWalkable(point.X, point.Y);
            AddDebugMessage("IsWalkable 不可用（Scenes 禁用）");
            return true; // 默认可行走，避免路径计算失败
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

        private void UpdateNextWaypoint(Vector2 playerPos)
        {
            if (PathPoints == null || PathPoints.Count == 0)
            {
                NextWaypoint = default(Vector2);
                return;
            }

            NextWaypoint = PathPoints.FirstOrDefault(p => Vector2.Distance(playerPos, p) > 5.0f);
            if (NextWaypoint == default(Vector2) && PathPoints.Count > 0)
                NextWaypoint = PathPoints.Last();
        }

        private void RecordExploredArea(Vector2 playerPos)
        {
            ExploredPoints.Add(new Vector2((float)Math.Round(playerPos.X / 10) * 10, (float)Math.Round(playerPos.Y / 10) * 10));
            // 临时禁用 Scenes 相关功能
            // var currentScene = Hud.Game.Scenes.FirstOrDefault(s => s.NavMesh != null && s.NavMesh.IsInMesh(playerPos.X, playerPos.Y));
            // if (currentScene != null)
            //     ExploredSceneIds.Add(currentScene.SceneHash);
            AddDebugMessage("RecordExploredArea 跳过 Scenes 检查");
        }

        private void HandleStuck(Vector2 playerPos)
        {
            AddDebugMessage("检测到卡住，尝试处理（Scenes 不可用，跳过）");
            // 临时禁用 Scenes 相关功能
            // var nearestWalkable = Hud.Game.Scenes
            //     .Where(s => s.NavMesh != null)
            //     .SelectMany(s => s.NavMesh.WalkablePoints())
            //     .OrderBy(p => Vector2.Distance(new Vector2(p.X, p.Y), playerPos))
            //     .FirstOrDefault();
            //
            // if (nearestWalkable != default(Vector2))
            // {
            //     Hud.Interaction.MouseMove(nearestWalkable.X, nearestWalkable.Y, Hud.Game.Me.FloorCoordinate.Z);
            //     Hud.Interaction.MouseDown(MouseButtons.Right);
            //     Hud.Interaction.MouseUp(MouseButtons.Right);
            //     AddDebugMessage($"尝试移动到最近可行走点: {nearestWalkable.X}, {nearestWalkable.Y}");
            // }
            StuckTimer.Restart();
        }

        public void ToggleAutoPotion()
        {
            AutoUsePotion = !AutoUsePotion;
            AddDebugMessage($"AutoUsePotion 切换为: {AutoUsePotion}");
        }

        public void SetHealthThreshold(float threshold)
        {
            HealthThreshold = threshold;
            AddDebugMessage($"HealthThreshold 设置为: {threshold}");
        }

        public void ResetClickedShrines()
        {
            AddDebugMessage("ResetClickedShrines 被调用（功能未实现）");
        }

        private class PriorityQueue<T>
        {
            private List<(T item, float priority)> elements = new List<(T, float)>();

            public int Count => elements.Count;

            public void Enqueue(T item, float priority)
            {
                elements.Add((item, priority));
                elements.Sort((a, b) => a.priority.CompareTo(b.priority));
            }

            public T Dequeue()
            {
                var item = elements[0].item;
                elements.RemoveAt(0);
                return item;
            }

            public bool Contains(T item)
            {
                return elements.Any(e => EqualityComparer<T>.Default.Equals(e.item, item));
            }
        }
    }
} 
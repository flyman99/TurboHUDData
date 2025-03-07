namespace Turbo.Plugins.User
{
    using Turbo.Plugins.Default;
    using SharpDX.DirectInput;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using SharpDX;
    using System.IO;

    public class AutoGreaterRiftPlugin : BasePlugin, IInGameTopPainter, IKeyEventHandler, INewAreaHandler, IAfterCollectHandler
    {
        public bool Running { get; set; }
        public IFont HeaderFont { get; private set; }
        public IFont InfoFont { get; private set; }
        public string StatusHeader { get; set; }
        public string CurrentAction { get; set; }
        public IWatch DelayTimer { get; private set; }
        public IUiElement uiGRmainPage => Hud.Render.GetUiElement("Root.NormalLayer.riftmenu_main");
        public IUiElement uiOnGreaterRift => Hud.Render.GetUiElement("Root.NormalLayer.riftmenu_main.LayoutRoot.greaterRift");
        public IUiElement uiAcceptButton => Hud.Render.GetUiElement("Root.NormalLayer.riftmenu_main.LayoutRoot.Accept_Layout.AcceptBtn");

        private bool IsInTown => Hud.Game.Me.IsInTown;
        private bool IsInRift => Hud.Game.SpecialArea == SpecialArea.GreaterRift;

        public enum RiftStep
        {
            OpenRift,
            ClearRift,
            CollectDrops,
            TalkToOrek,
            UpgradeGem,
            CloseRift
        }

        public RiftStep CurrentStep { get; set; }

        public IKeyEvent ToggleKeyEvent { get; private set; }

        public IFont DebugFont { get; private set; }
        private List<string> DebugMessages = new List<string>();
        private AutoGreaterRiftPathfindingPlugin PathfindingPlugin { get; set; }
        private string LogFilePath => Path.Combine(Directory.GetCurrentDirectory(), "AutoGreaterRiftPlugin_Log.txt");

        public AutoGreaterRiftPlugin()
        {
            Enabled = true;
            Running = false;
            CurrentStep = RiftStep.OpenRift;
            StatusHeader = "大秘境自动化脚本已停止";
            CurrentAction = "待机中";
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            HeaderFont = Hud.Render.CreateFont("tahoma", 9, 255, 0, 255, 255, true, false, 255, 0, 0, 0, true);
            InfoFont = Hud.Render.CreateFont("tahoma", 7, 255, 255, 255, 255, false, false, 255, 0, 0, 0, true);
            DelayTimer = Hud.Time.CreateWatch();
            ToggleKeyEvent = Hud.Input.CreateKeyEvent(true, Key.Insert, false, false, false);
            DebugFont = Hud.Render.CreateFont("tahoma", 8, 255, 0, 255, 0, true, false, 255, 0, 0, 0, true);
            PathfindingPlugin = Hud.GetPlugin<AutoGreaterRiftPathfindingPlugin>();
            // 初始化日志文件
            if (File.Exists(LogFilePath)) File.Delete(LogFilePath);
        }

        private void AddDebugMessage(string message)
        {
            string timestampedMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{Hud.Game.CurrentGameTick}] {message}";
            DebugMessages.Add(timestampedMessage);
            if (DebugMessages.Count > 10) DebugMessages.RemoveAt(0);
            // 写入日志文件
            try
            {
                File.AppendAllText(LogFilePath, timestampedMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Hud.Sound.Speak("日志写入失败: " + ex.Message);
            }
        }

        public void PaintTopInGame(ClipState clipState)
        {
            if (clipState != ClipState.BeforeClip) return;
            if (Hud.Render.UiHidden) return;

            var uiElement = Hud.Render.GetUiElement("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.BoostWrapper");
            var uiRect = uiElement != null ? ToSharpDXRectangleF(uiElement.Rectangle) : new SharpDX.RectangleF(0, 0, Hud.Window.Size.Width, Hud.Window.Size.Height);

            HeaderFont.DrawText(StatusHeader ?? "大秘境自动化脚本", uiRect.Left + 20, uiRect.Top + 30);
            InfoFont.DrawText("当前步骤: " + CurrentStep.ToString(), uiRect.Left + 20, uiRect.Top + 50);
            InfoFont.DrawText("当前动作: " + (CurrentAction ?? "待机中"), uiRect.Left + 20, uiRect.Top + 70);
            InfoFont.DrawText("按Insert键开启/关闭自动化脚本", uiRect.Left + 20, uiRect.Top + 90);

            for (int i = 0; i < DebugMessages.Count; i++)
            {
                DebugFont.DrawText(DebugMessages[i], uiRect.Left + 20, uiRect.Top + 110 + i * 20);
            }
        }

        private SharpDX.RectangleF ToSharpDXRectangleF(System.Drawing.RectangleF rect)
        {
            return new SharpDX.RectangleF(rect.X, rect.Y, rect.Width, rect.Height);
        }

        public void OnKeyEvent(IKeyEvent keyEvent)
        {
            if (ToggleKeyEvent.Matches(keyEvent) && keyEvent.IsPressed)
            {
                Running = !Running;
                if (Running)
                {
                    StatusHeader = "大秘境自动化脚本已启动";
                    PathfindingPlugin.AutoNavigate = true;
                    AddDebugMessage("脚本启动，AutoNavigate 设置为 true");
                }
                else
                {
                    StatusHeader = "大秘境自动化脚本已停止";
                    PathfindingPlugin.AutoNavigate = false;
                    AddDebugMessage("脚本停止，AutoNavigate 设置为 false");
                }
            }
        }

        public void OnNewArea(bool newGame, ISnoArea area)
        {
            if (newGame)
            {
                Running = false;
                CurrentStep = RiftStep.OpenRift;
                PathfindingPlugin.AutoNavigate = false;
                AddDebugMessage("新游戏开始，重置状态");
            }
        }

        public void AfterCollect()
        {
            if (!Running)
            {
                AddDebugMessage("Running 为 false");
                return;
            }
            if (!Hud.Game.IsInGame || Hud.Game.Me.IsDead) return;
            ExecuteCurrentStep();
            if (PathfindingPlugin != null)
            {
                AddDebugMessage("调用 PathfindingPlugin.Update");
                PathfindingPlugin.Update(Hud);
            }
            else
            {
                AddDebugMessage("PathfindingPlugin 为 null");
            }
        }

        private void ExecuteCurrentStep()
        {
            switch (CurrentStep)
            {
                case RiftStep.OpenRift:
                    OpenGreaterRift();
                    break;
                case RiftStep.ClearRift:
                    ClearGreaterRift();
                    break;
                case RiftStep.CollectDrops:
                    CollectDrops();
                    break;
                case RiftStep.TalkToOrek:
                    TalkToOrek();
                    break;
                case RiftStep.UpgradeGem:
                    UpgradeGem();
                    break;
                case RiftStep.CloseRift:
                    CloseRift();
                    break;
            }
        }

        private void OpenGreaterRift()
        {
            CurrentAction = "正在打开大秘境...";
            AddDebugMessage("进入 OpenGreaterRift");
            if (IsInTown && !IsInRift)
            {
                foreach (var actor in Hud.Game.Actors.Where(a => a.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate) < 150.0f))
                {
                    AddDebugMessage($"Actor: SNO={actor.SnoActor?.Sno}, Name={actor.SnoActor?.NameEnglish}, Distance={actor.FloorCoordinate.XYDistanceTo(Hud.Game.Me.FloorCoordinate)}");
                }

                var obelisk = Hud.Game.Actors.FirstOrDefault(a => a.SnoActor?.Sno == ActorSnoEnum._x1_openworld_lootrunobelisk_b);
                if (obelisk != null)
                {
                    var playerPos = Hud.Game.Me.FloorCoordinate;
                    var obeliskPos = obelisk.FloorCoordinate;
                    var distance = obeliskPos.XYDistanceTo(playerPos);
                    AddDebugMessage($"找到方尖碑，SNO: {obelisk.SnoActor?.Sno}, 距离: {distance}");
                    if (distance > 10.0f)
                    {
                        if (PathfindingPlugin != null)
                        {
                            AddDebugMessage("设置寻路目标");
                            PathfindingPlugin.CurrentTarget = new Vector2(obeliskPos.X, obeliskPos.Y);
                            PathfindingPlugin.PathPoints = PathfindingPlugin.FindPathAStar(
                                new Vector2(playerPos.X, playerPos.Y),
                                PathfindingPlugin.CurrentTarget);
                            PathfindingPlugin.AutoNavigate = true;
                            CurrentAction = $"正在导航到方尖碑，距离: {distance}";
                            AddDebugMessage($"AutoNavigate: {PathfindingPlugin.AutoNavigate}");
                        }
                    }
                    else
                    {
                        AddDebugMessage("点击方尖碑");
                        Hud.Interaction.MouseMove(obeliskPos.X, obeliskPos.Y, obeliskPos.Z);
                        Hud.Interaction.MouseDown(MouseButtons.Left);
                        Hud.Interaction.MouseUp(MouseButtons.Left);
                        DelayTimer.Restart();
                        PathfindingPlugin.AutoNavigate = false;
                    }
                }
                else
                {
                    CurrentAction = "未找到方尖碑";
                    AddDebugMessage("未找到方尖碑");
                    return;
                }

                if (DelayTimer.IsRunning && DelayTimer.ElapsedMilliseconds < 1000)
                {
                    AddDebugMessage("等待延迟");
                    return;
                }

                if (uiGRmainPage?.Visible == true)
                {
                    AddDebugMessage("大秘境界面已打开");
                    if (uiOnGreaterRift?.AnimState != 27)
                    {
                        Hud.Interaction.MouseMove(uiOnGreaterRift.Rectangle.X + uiOnGreaterRift.Rectangle.Width / 2, 
                                                uiOnGreaterRift.Rectangle.Y + uiOnGreaterRift.Rectangle.Height / 2);
                        Hud.Interaction.MouseDown(MouseButtons.Left);
                        Hud.Interaction.MouseUp(MouseButtons.Left);
                        DelayTimer.Restart();
                    }
                    else if (uiAcceptButton?.Visible == true)
                    {
                        Hud.Interaction.MouseMove(uiAcceptButton.Rectangle.X + uiAcceptButton.Rectangle.Width / 2, 
                                                uiAcceptButton.Rectangle.Y + uiAcceptButton.Rectangle.Height / 2);
                        Hud.Interaction.MouseDown(MouseButtons.Left);
                        Hud.Interaction.MouseUp(MouseButtons.Left);
                        CurrentStep = RiftStep.ClearRift;
                        AddDebugMessage("进入大秘境");
                    }
                }
            }
            else if (IsInRift)
            {
                CurrentStep = RiftStep.ClearRift;
                PathfindingPlugin.AutoNavigate = true;
            }
        }

        private void ClearGreaterRift()
        {
            CurrentAction = "清理大秘境中...";
            if (!Hud.Game.AliveMonsters.Any())
            {
                CurrentStep = RiftStep.CollectDrops;
            }
        }

        private void CollectDrops()
        {
            CurrentAction = "拾取掉落物品...";
            var drop = Hud.Game.Items.FirstOrDefault(i => i.Quality == ItemQuality.Legendary);
            if (drop != null)
            {
                Hud.Interaction.MouseMove(drop.FloorCoordinate.X, drop.FloorCoordinate.Y, drop.FloorCoordinate.Z);
                Hud.Interaction.MouseDown(MouseButtons.Left);
                Hud.Interaction.MouseUp(MouseButtons.Left);
                DelayTimer.Start();
            }
            else
            {
                CurrentStep = RiftStep.TalkToOrek;
            }
        }

        private void TalkToOrek()
        {
            CurrentAction = "与欧瑞克对话...";
            var orek = Hud.Game.Actors.FirstOrDefault(a => a.SnoActor.Sno == (ActorSnoEnum)403012);
            if (orek != null)
            {
                Hud.Interaction.MouseMove(orek.FloorCoordinate.X, orek.FloorCoordinate.Y, orek.FloorCoordinate.Z);
                Hud.Interaction.MouseDown(MouseButtons.Left);
                Hud.Interaction.MouseUp(MouseButtons.Left);
                DelayTimer.Start();
                CurrentStep = RiftStep.UpgradeGem;
            }
        }

        private void UpgradeGem()
        {
            CurrentAction = "升级宝石中...";
            DelayTimer.Start();
            CurrentStep = RiftStep.CloseRift;
        }

        private void CloseRift()
        {
            CurrentAction = "关闭大秘境...";
            var closeButton = Hud.Render.GetUiElement("Root.NormalLayer.riftResults_main.LayoutRoot.closeButton");
            if (closeButton?.Visible == true)
            {
                Hud.Interaction.MouseMove(closeButton.Rectangle.X + closeButton.Rectangle.Width / 2, 
                                        closeButton.Rectangle.Y + closeButton.Rectangle.Height / 2);
                Hud.Interaction.MouseDown(MouseButtons.Left);
                Hud.Interaction.MouseUp(MouseButtons.Left);
                Running = false;
                CurrentStep = RiftStep.OpenRift;
                PathfindingPlugin.AutoNavigate = false;
            }
        }
    }
}
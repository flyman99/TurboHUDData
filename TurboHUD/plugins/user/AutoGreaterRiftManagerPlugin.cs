namespace Turbo.Plugins.User
{
    using Turbo.Plugins.Default;
    using SharpDX.DirectInput;
    using System;

    public class AutoGreaterRiftManagerPlugin : BasePlugin, IKeyEventHandler
    {
        public bool Running { get; set; }
        private AutoGreaterRiftPlugin RiftPlugin { get; set; }
        private AutoGreaterRiftPathfindingPlugin PathfindingPlugin { get; set; }
        private IKeyEvent ToggleKeyEvent { get; set; }

        public AutoGreaterRiftManagerPlugin()
        {
            Enabled = true;
            Running = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            RiftPlugin = Hud.GetPlugin<AutoGreaterRiftPlugin>();
            PathfindingPlugin = Hud.GetPlugin<AutoGreaterRiftPathfindingPlugin>();
            ToggleKeyEvent = Hud.Input.CreateKeyEvent(true, Key.Insert, false, false, false);
        }

        public void OnKeyEvent(IKeyEvent keyEvent)
        {
            if (ToggleKeyEvent.Matches(keyEvent) && keyEvent.IsPressed)
            {
                Running = !Running;
                if (RiftPlugin != null)
                {
                    RiftPlugin.Running = Running;
                }
                if (PathfindingPlugin != null)
                {
                    PathfindingPlugin.AutoNavigate = Running;
                }
            }
            else if (keyEvent.Key == Key.F9 && keyEvent.IsPressed)
            {
                if (PathfindingPlugin != null)
                {
                    PathfindingPlugin.ToggleAutoPotion();
                }
            }
            else if (keyEvent.Key == Key.Up && keyEvent.IsPressed)
            {
                if (PathfindingPlugin != null)
                {
                    PathfindingPlugin.SetHealthThreshold(Math.Min(1.0f, PathfindingPlugin.HealthThreshold + 0.1f));
                }
            }
            else if (keyEvent.Key == Key.Down && keyEvent.IsPressed)
            {
                if (PathfindingPlugin != null)
                {
                    PathfindingPlugin.SetHealthThreshold(Math.Max(0.0f, PathfindingPlugin.HealthThreshold - 0.1f));
                }
            }
        }

        public void OnNewArea(bool newGame, ISnoArea area)
        {
            if (newGame && PathfindingPlugin != null)
            {
                PathfindingPlugin.ResetClickedShrines();
            }
        }
    }
}
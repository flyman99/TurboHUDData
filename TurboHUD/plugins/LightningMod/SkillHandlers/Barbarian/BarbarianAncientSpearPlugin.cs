namespace Turbo.Plugins.LightningMod
{
    public class BarbarianAncientSpearPlugin : AbstractSkillHandler, ISkillHandler
    {
        private float fury = 1;
        public BarbarianAncientSpearPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.UseTpStart, CastPhase.UseWpStart, CastPhase.Move, CastPhase.PreAttack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Barbarian_AncientSpear;
            Rune = 1;
            CreateCastRule()
                .IfTrue(ctx => {
                    if (ctx.Skill.Player.IsInTown)
                    {
                        fury = ctx.Skill.Player.Stats.ResourceMaxFury + 200;
                    }
                    return true;
                }).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfTrue(ctx =>
                {
                    if (fury == 1 && ctx.Skill.Player.Stats.ResourceCurFury < 30)
                    {
                        fury = ctx.Skill.Player.Stats.ResourceMaxFury + 200;
                    }
                    var set = Hud.Game.Me.GetSetItemCount(749637) >= 6;//����6��ޢ��671068����֮��
                    return set &&
                    ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.SkularsSalvation.Sno) &&//˹����������
                    (ctx.Skill.Player.Stats.ResourceCurFury / (fury == 1 ? ctx.Skill.Player.Stats.ResourceMaxFury : fury)>= 0.98) && //����
                    ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.ArreatsLaw.Sno) && //������֮��
                    (Hud.Game.Me.Animation.ToString().Contains("throw"));//�ɸ�
                }).ThenCastElseContinue()
                ;
        }
    }
}
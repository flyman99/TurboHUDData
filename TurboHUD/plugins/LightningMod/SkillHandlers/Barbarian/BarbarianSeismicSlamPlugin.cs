namespace Turbo.Plugins.LightningMod
{
    public class BarbarianSeismicSlamPlugin : AbstractSkillHandler, ISkillHandler
    {
        public BarbarianSeismicSlamPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.UseTpStart, CastPhase.UseWpStart, CastPhase.Move, CastPhase.PreAttack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Barbarian_SeismicSlam;
            Rune = 1;
            CreateCastRule()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfPrimaryResourceAmountIsAbove(ctx => 30).ThenContinueElseNoCast()
                .IfTrue(ctx =>
                {
                    var set = Hud.Game.Me.GetSetItemCount(671068) == 6 && Hud.Game.Me.GetSetItemCount(749637) == 4;//����6+4ʱ
                    return (set);
                }).ThenContinueElseNoCast()
                .IfTrue(ctx => ctx.Hud.Game.Me.Powers.BuffIsActive(hud.Sno.SnoPowers.Generic_ItemPassiveUniqueRing735x1.Sno, 0) && !ctx.Hud.Game.Me.Powers.BuffIsActive(hud.Sno.SnoPowers.Generic_ItemPassiveUniqueRing735x1.Sno, 2)).ThenCastElseContinue()//���Խ䲢������BUFF��ʧ��ʩ��
                .IfSpecificSkillOnCooldown(Hud.Sno.SnoPowers.Barbarian_WrathOfTheBerserker).ThenContinueElseNoCast()//��֮ŭ��ȴʱ
                .IfPrimaryResourcePercentageIsAbove(98).ThenCastElseContinue()//ŭ������98%

                ;
        }
    }
}
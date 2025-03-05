namespace Turbo.Plugins.LightningMod
{
    using System.Linq;
    public class CrusaderLawsOfJusticePlugin : AbstractSkillHandler, ISkillHandler
	{
        public CrusaderLawsOfJusticePlugin()
            : base(CastType.SimpleSkill, CastPhase.AutoCast, CastPhase.PreAttack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Crusader_LawsOfJustice;

            CreateCastRule()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge).ThenNoCastElseContinue()//����ʱ
                .IfTrue(ctx => ctx.Hud.Avoidance.CurrentValue).ThenCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Player.AvoidablesInRange.Any(x => x.AvoidableDefinition.InstantDeath)).ThenCastElseContinue()
                .IfEnoughMonstersNearby(ctx => 100, ctx => 1).ThenContinueElseNoCast()
                .IfHealthWarning(70, 80).ThenCastElseContinue()
                .IfNearbyPartyMemberIsInDanger(48, 40, 80, 40, true).ThenCastElseContinue()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Generic_X1CrusaderLawsOfJusticePassive2, 6).ThenNoCastElseContinue()//�Ѽ���
                .IfTrue(ctx =>
                ctx.Hud.Game.Me.Powers.BuffIsActive(310678) ||//�ɷ��ޱ�
                ctx.Skill.Player.Stats.CooldownReduction >= 0.5 || ctx.Hud.Game.Me.Powers.BuffIsActive(402459)//CDR����50����˻Ƶ�
                ).ThenContinueElseNoCast()
                .IfBuffIsAboutToExpire(100, 500).ThenCastElseContinue()
                ;
        }
    }
}
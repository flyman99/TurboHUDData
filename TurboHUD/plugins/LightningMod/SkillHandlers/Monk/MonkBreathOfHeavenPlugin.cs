namespace Turbo.Plugins.LightningMod
{
    public class MonkBreathOfHeavenPlugin : AbstractSkillHandler, ISkillHandler
	{
        public MonkBreathOfHeavenPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Attack)
        {
            Enabled = false;
        }
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Monk_BreathOfHeaven;
            //��������1 ����ŭ��2 ���ܹ�ע3 �������4
            CreateCastRule()
                .IfCanCastSkill(150, 200, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfHealthPercentageIsBelow(ctx => 70).ThenCastElseContinue()
                .IfNearbyPartyMemberIsInDanger(12, 70, 80, 70, true).ThenCastElseContinue()//���з�����12�����Σ��ʱʹ��
                .IfTrue(ctx => ctx.Skill.Rune == 3).ThenCastElseContinue()//���ܹ�ע
                .IfPrimaryResourcePercentageIsBelow(50).ThenContinueElseNoCast()//��������50%
                .IfTrue(ctx => (ctx.Hud.Game.Me.Stats.CooldownReduction > 0.65 && (ctx.Hud.Game.Me.Powers.BuffIsActive(402459) || ctx.Hud.Game.Me.Powers.BuffIsActive(hud.Sno.SnoPowers.Ingeom.Sno) || ctx.Hud.Game.Me.Powers.BuffIsActive(hud.Sno.SnoPowers.MesserschmidtsReaver.Sno))) || ctx.Hud.Game.Me.Stats.CooldownReduction > 0.73)//65 % CDR���ϼ����Ƶ�/����/÷���� 73% CDR ʱ�Զ�����ʩ��
                ;
            CreateCastRule()//����ŭ�����
                .IfTrue(ctx => ctx.Skill.Rune == 2).ThenContinueElseNoCast()
                .IfCanCastSkill(150, 200, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfIdle().ThenNoCastElseContinue()
                .IfRunning().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfEliteOrBossIsNearby(ctx => 40).ThenContinueElseNoCast()//�о�Ӣ��BOSSʱ����BUFF
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Monk_BreathOfHeaven, 0, 50, 100).ThenCastElseContinue()
                ;
            CreateCastRule()//������з���
                .IfTrue(ctx => ctx.Skill.Rune == 4).ThenContinueElseNoCast()
                .IfCanCastSkill(150, 200, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfTrue(ctx => (ctx.Hud.Game.Me.Stats.CooldownReduction > 0.65 && (ctx.Hud.Game.Me.Powers.BuffIsActive(402459) || ctx.Hud.Game.Me.Powers.BuffIsActive(hud.Sno.SnoPowers.Ingeom.Sno) || ctx.Hud.Game.Me.Powers.BuffIsActive(hud.Sno.SnoPowers.MesserschmidtsReaver.Sno))) || ctx.Hud.Game.Me.Stats.CooldownReduction > 0.73).ThenCastElseContinue()//65%CDR���ϼ����Ƶ�/����/÷���� 73% CDR ʱ�Զ�����ʩ��
                ;
        }
    }
}
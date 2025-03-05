namespace Turbo.Plugins.LightningMod
{
    public class DemonHunterPreparationPlugin : AbstractSkillHandler, ISkillHandler
    {
        public int ResourceConsumed { get; set; }
        public DemonHunterPreparationPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Move, CastPhase.PreAttack)
        {
            Enabled = false;
            ResourceConsumed = 30;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.DemonHunter_Preparation;

            CreateCastRule()
                .IfTrue(ctx => ctx.Skill.Rune == 0).ThenNoCastElseContinue()//�ͷ����Ĳ�ʩ��
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfTrue(ctx => ctx.Skill.Rune == 3 && ctx.Skill.Player.Defense.HealthPct <= 40).ThenCastElseContinue()//ս�˴������
                .IfTrue(ctx =>
                {
                    return (ctx.Skill.Player.Stats.ResourceCurDiscipline <= ctx.Skill.Player.Stats.ResourceMaxDiscipline - ResourceConsumed);//������30����ɺ��Զ�ʩ��
                }).ThenCastElseContinue()
                ;
        }
    }
}
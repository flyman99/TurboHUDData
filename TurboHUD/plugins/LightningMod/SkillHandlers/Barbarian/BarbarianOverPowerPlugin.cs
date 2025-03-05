namespace Turbo.Plugins.LightningMod
{
    public class BarbarianOverPowerPlugin : AbstractSkillHandler, ISkillHandler
    {
        public BarbarianOverPowerPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.UseTpStart, CastPhase.UseWpStart, CastPhase.Move, CastPhase.PreAttack, CastPhase.Attack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Barbarian_Overpower;

            CreateCastRule()
                .IfCanCastSkill(150, 200, 250)
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfTrue(ctx=>
                {//����������������30%����ŭ����Χ5�������ϲ�ʹ��
                    return
                    ctx.Skill.Rune == 3 &&
                    ctx.Skill.Player.Stats.ResourcePctFury <= 30 &&
                    ctx.Skill.Player.Density.GetDensity(9) >= 5;
                }).ThenCastElseContinue()
                .IfTrue(ctx =>
                {//ɱ¾�񻶡�ռ���Ȼ�������Buff��ʧ���ʹ��
                    return
                    (ctx.Skill.Rune == 0 || ctx.Skill.Rune == 4) &&
                    !ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Barbarian_Overpower.Sno);
                }).ThenCastElseContinue()
                //������������Χ�й�ʱʹ��
                .IfTrue(ctx =>
                {
                    return (ctx.Skill.Rune == 1 || ctx.Skill.Rune == 2) && (ctx.Skill.Player.Density.GetDensity(9) >= 1);
                }).ThenCastElseContinue()
                ;
        }
    }
}
 
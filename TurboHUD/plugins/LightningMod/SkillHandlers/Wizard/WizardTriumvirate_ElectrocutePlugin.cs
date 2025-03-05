using Turbo.Plugins.glq;
namespace Turbo.Plugins.LightningMod
{
    public class WizardTriumvirate_ElectrocutePlugin : AbstractSkillHandler, ISkillHandler
    {
        public WizardTriumvirate_ElectrocutePlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.UseWpStart, CastPhase.Move, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Wizard_Electrocute;
            CreateCastRule()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Triumvirate).ThenContinueElseNoCast()//��Ԫ����
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Triumvirate, 2, 1500, 1500).ThenCastElseContinue()//��Ԫ����BUFFʣ��ʱ�伴������
                .IfTrue(ctx =>
                {
                    return PublicClassPlugin.GetBuffCount(Hud, Hud.Sno.SnoPowers.Triumvirate.Sno, 2) < 3;//��Ԫ����BUFF����3��
                }).ThenCastElseContinue()
                ;
        }
    }
}
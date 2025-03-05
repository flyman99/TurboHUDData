using Turbo.Plugins.glq;
namespace Turbo.Plugins.LightningMod
{
    public class WizardMirrorImagePlugin : AbstractSkillHandler, ISkillHandler
    {
        public WizardMirrorImagePlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.UseWpStart, CastPhase.Move, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Wizard_MirrorImage;
            CreateCastRule()//�Ծ�Ӣ
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Wizard_MirrorImage, 0).ThenNoCastElseContinue()
                .IfTrue(ctx => 
                ctx.Skill.Player.GetSetItemCount(84014) >= 6).ThenContinueElseNoCast()//����6��
                .IfTrue(ctx =>
                {
                    double coe = PublicClassPlugin.GetHighestElementLeftSecond(Hud, ctx.Skill.Player, 1);
                    bool isCOE = ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.ConventionOfElements.Sno);
                    return (!isCOE || (isCOE && coe <= 11 && coe >= 0));//��3~~��0
                }
                ).ThenContinueElseNoCast()
                .IfEliteOrBossIsNearby(ctx => 15, false).ThenCastElseContinue()
                ;

            CreateCastRule()//�԰׹�
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Wizard_MirrorImage, 0).ThenNoCastElseContinue()
                .IfTrue(ctx =>
                ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.ConventionOfElements.Sno) &&
                ctx.Skill.Player.GetSetItemCount(84014) >= 6).ThenContinueElseNoCast()//Ԫ�ؽ�+����6��
                .IfTrue(ctx =>
                {
                    double coe = PublicClassPlugin.GetHighestElementLeftSecond(Hud, ctx.Skill.Player, 1);
                    return (coe <= 9 && coe >= 0);//��1~��0
                }
                ).ThenContinueElseNoCast()
                .IfEnoughMonstersNearby(ctx => 15, ctx => 10).ThenCastElseContinue()
                ;
        }
    }
}
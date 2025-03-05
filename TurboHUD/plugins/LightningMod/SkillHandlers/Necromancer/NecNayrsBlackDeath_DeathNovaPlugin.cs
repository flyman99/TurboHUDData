using Turbo.Plugins.glq;
namespace Turbo.Plugins.LightningMod
{
    public class NecNayrsBlackDeath_DeathNovaPlugin : AbstractSkillHandler, ISkillHandler
    {

        public NecNayrsBlackDeath_DeathNovaPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Necromancer_DeathNova;
            CreateCastRule()
                .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Rune == 3 || ctx.Skill.Rune == 4).ThenContinueElseNoCast()
                .IfSpecificBuffIsActive(hud.Sno.SnoPowers.NayrsBlackDeath, 0).ThenContinueElseNoCast()//װ������
                .IfPrimaryResourceAmountIsAbove(ctx => (int)ctx.Skill.GetResourceRequirement() + 1).ThenContinueElseNoCast()
                .IfTrue(ctx =>
                {
                    int IconIndex = ctx.Skill.Key.GetHashCode() + 1;
                    var buff = ctx.Skill.Player.Powers.GetBuff(hud.Sno.SnoPowers.NayrsBlackDeath.Sno);
                    var remaining = buff?.Active == true ? buff.TimeLeftSeconds[IconIndex] : 0.0d;
                    if (remaining < 0.5d)
                    {
                        return true;//BUFFС��0.5���ʩ��
                    }
                    else if (ctx.Skill.Player.Powers.BuffIsActive(hud.Sno.SnoPowers.ConventionOfElements.Sno))//Ԫ�ؽ�
                    {
                        var Coe = PublicClassPlugin.GetHighestElementLeftSecond(hud, hud.Game.Me, 2);
                        return remaining < Coe;//ʣ��BUFF���㸲�Ǳ���ʱ��ʱʩ��
                    }
                    return false;
                }).ThenCastElseContinue()
            ;
        }
    }
}
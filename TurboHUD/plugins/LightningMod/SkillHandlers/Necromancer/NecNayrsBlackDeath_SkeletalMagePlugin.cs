using Turbo.Plugins.glq;
namespace Turbo.Plugins.LightningMod
{
    public class NecNayrsBlackDeath_SkeletalMagePlugin : AbstractSkillHandler, ISkillHandler
    {

        public NecNayrsBlackDeath_SkeletalMagePlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Necromancer_SkeletalMage;
            CreateCastRule()
                .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Rune == 3).ThenContinueElseNoCast()
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
                        var buffSkeletalMage = PublicClassPlugin.GetBuffLeftTime(hud, Hud.Sno.SnoPowers.Necromancer_SkeletalMage.Sno, 6);
                        return Coe > 4 && Coe < 5 && buffSkeletalMage < 5;//�뱬����ʣ1��ʱ�ͷ������÷�ʦʱ�䲻��5��
                    }
                    return false;
                }).ThenCastElseContinue()
            ;
        }
    }
}
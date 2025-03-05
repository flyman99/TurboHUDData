namespace Turbo.Plugins.LightningMod
{
    using System.Linq;
    public class MonkSerenityPlugin : AbstractSkillHandler, ISkillHandler
	{
        public MonkSerenityPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Attack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Monk_Serenity;
            CreateCastRule()
                .IfCanCastSkill(50, 100, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Skill.BuffIsActive).ThenNoCastElseContinue()
                .IfEnoughMonstersNearby(ctx => 100, ctx => 1).ThenContinueElseNoCast()//100��������1����
                .IfTrue(ctx =>//������Զ
                {
                    return ctx.Skill.Rune == 3;
                }
                ).ThenContinueElseNoCast()
                .IfNearbyPartyMemberIsInDanger(45, 60, 80, 70, true).ThenCastElseContinue()//����Σ��ʱʩ��
                .IfTrue(ctx => ctx.Skill.Player.Stats.CooldownReduction >= 0.7).ThenContinueElseNoCast()//CD����70%ʱ����
                .IfTrue(ctx =>
                {
                    var players = ctx.Hud.Game.Players.Where(p => (p.HeroClassDefinition.HeroClass == HeroClass.WitchDoctor || p.HeroClassDefinition.HeroClass == HeroClass.Necromancer || p.HeroClassDefinition.HeroClass == HeroClass.Crusader || p.HeroClassDefinition.HeroClass == HeroClass.Wizard) && 
                    !p.IsDead && p.InGreaterRift);//�������ҽ��ʥ�̾���ʦ
                    if (players == null)
                    {//û���������ҽ��ʥ�̾���ʦ��ʱ���򱣻���������
                        players = ctx.Hud.Game.Players.Where(p => !p.IsDead && p.InGreaterRift);//�������
                    }
                    if (players == null)
                    {
                        return false;//û�ж���ʱ����false
                    }
                    bool CloseToThePlayer = false;
                    foreach (var player in players)
                    {
                        if(player.CentralXyDistanceToMe <= 45)
                        {
                            //���ȱ����Ķ�����45����
                            CloseToThePlayer = true;
                            break;
                        }
                    }
                    return CloseToThePlayer;
                }).ThenCastElseContinue()
                ;
            CreateCastRule()//���з���
                .IfCanCastSkill(50, 100, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Skill.BuffIsActive).ThenNoCastElseContinue()
                .IfEnoughMonstersNearby(ctx => 60, ctx => 1).ThenContinueElseNoCast()//60��������1����
                .IfHealthWarning(60, 80).ThenCastElseContinue()//Ѫ�������Զ�ʩ��
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Generic_PagesBuffInvulnerable).ThenNoCastElseContinue()//����������Ч
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.ConventionOfElements).ThenNoCastElseContinue()//��Ԫ�ؽ�ָ����Ч
                .IfTrue(ctx => ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.SquirtsNecklace.Sno) || Hud.Game.Me.Stats.CooldownReduction >= 0.5 && (
                ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Ingeom.Sno) || 
                ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.MesserschmidtsReaver.Sno) || 
                ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_PagesBuffInfiniteCasting.Sno) ||
                ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.ObsidianRingOfTheZodiac.Sno))).ThenCastElseContinue()//CDR����50%��װ��������÷����Ƶ�����˼�����ʱʩ��
                ;
        }
    }
}
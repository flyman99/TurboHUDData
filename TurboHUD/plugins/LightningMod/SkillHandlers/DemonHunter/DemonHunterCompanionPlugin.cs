namespace Turbo.Plugins.LightningMod
{
    using System.Linq;
    using Turbo.Plugins.glq;
    public class DemonHunterCompanionPlugin : AbstractSkillHandler, ISkillHandler
    {
        public DemonHunterCompanionPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Move, CastPhase.Attack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.DemonHunter_Companion;
            CreateCastRule()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfTrue(ctx => ctx.Skill.Player.Stats.CooldownReduction >= 0.69 || Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.ObsidianRingOfTheZodiac.Sno)).ThenCastElseContinue()//69CDR��Ƶ�ʱ��������
                .IfTrue(ctx => ctx.Skill.Rune == 3 && ctx.Skill.Player.Stats.ResourcePctHatred < 15//������������޵���15%ʱʹ��
                ).ThenCastElseContinue()
                .IfTrue(ctx => (ctx.Skill.Rune == 1 || ctx.Skill.Rune == 0 || ctx.Skill.Rune == 255) && ctx.Hud.Game.ActorQuery.IsEliteOrBossCloserThan(40)//Ұ��֩�������40�����о�Ӣ��Bossʱʹ��
                ).ThenCastElseContinue()
                .IfTrue(ctx =>
                {
                    int CoeIndex = Hud.GetPlugin<PublicClassPlugin>().CoeIndex;
                    int PartyCoeIndex = Hud.GetPlugin<PublicClassPlugin>().PartyCoeIndex;
                    if (ctx.Skill.Rune != 2 && Hud.Game.Me.GetSetItemCount(254427) < 2) return false;//��ս�Ƿ����Ҳ����Ӷ���
                    bool _cast;
                    var DPSPlayer = ctx.Hud.Game.Players.FirstOrDefault(p => p.InGreaterRift &&
                p.Powers.UsedLegendaryPowers.ConventionOfElements?.Active == true//Ԫ�ؽ�ָ
                );

                    if (DPSPlayer != null)
                    {
                        double CoeLeftTime = PublicClassPlugin.GetHighestElementLeftSecondAssingedPlayer(Hud, DPSPlayer, PartyCoeIndex);//��ȡ�����DPS���Ԫ�ص���ʱ
                        _cast = CoeLeftTime < 6 && CoeLeftTime > 0;//����Ԫ��ǰ6��
                    }
                    else if (Hud.Game.Me.Powers.BuffIsActive(430674))//Ԫ�ؽ�
                    {
                        double CoeLeftTime = PublicClassPlugin.GetHighestElementLeftSecond(Hud, ctx.Skill.Player, CoeIndex);//��ȡ���Լ����Ԫ�ص���ʱ
                        _cast = CoeLeftTime < 6 && CoeLeftTime > 0 && ctx.Hud.Game.ActorQuery.IsEliteOrBossCloserThan(40);
                    }
                    else
                    {
                        _cast = ctx.Hud.Game.ActorQuery.IsEliteOrBossCloserThan(40, false);//������Ӣʱʩ��
                    }
                    return _cast;
                }).ThenCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Rune == 4 && ctx.Hud.Game.ActorQuery.NearestHealthGlobe != null && ctx.Hud.Game.ActorQuery.NearestHealthGlobe.NormalizedXyDistanceToMe <= 60 && ctx.Skill.Player.Defense.HealthPct < 60//ѩ��������60������Ѫ������������60%ʱʹ��
                ).ThenCastElseContinue()
                .IfTrue(ctx => Hud.Game.Me.GetSetItemCount(254427) >= 2 && !Hud.Game.Me.Powers.BuffIsActive(430674) &&(ctx.Skill.Player.Stats.ResourcePctHatred < 15 || ctx.Hud.Game.ActorQuery.IsEliteOrBossCloserThan(40) || (ctx.Hud.Game.ActorQuery.NearestHealthGlobe != null && ctx.Hud.Game.ActorQuery.NearestHealthGlobe.NormalizedXyDistanceToMe <= 60 && ctx.Skill.Player.Defense.HealthPct < 60))//�Ӷ����Ҳ���Ԫ�ؽ�ʱ
                ).ThenCastElseContinue()
                ;
        }
    }
}
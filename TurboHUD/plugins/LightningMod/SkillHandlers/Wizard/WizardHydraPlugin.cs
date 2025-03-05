using System.Linq;
namespace Turbo.Plugins.LightningMod
{
    public class WizardHydraPlugin : AbstractSkillHandler, ISkillHandler
    {
        public WizardHydraPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Wizard_Hydra;
            CreateCastRule()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfEnoughMonstersNearby(ctx => 100, ctx => 1).ThenContinueElseNoCast()
                .IfTrue(ctx => ctx.Skill.Player.GetSetItemCount(59609) >=4 && ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.SerpentsSparker.Sno) && ctx.Skill.Rune != 3).ThenContinueElseNoCast()//����ר��(���+���� + �Ǿ��߷���)
                .IfTrue(ctx =>
                {
                    var HydraBuff = ctx.Skill.Player.Powers.GetBuff(ctx.Hud.Sno.SnoPowers.Wizard_Hydra.Sno);
                    return !ctx.Skill.BuffIsActive || HydraBuff?.IconCounts[7] <= 8;//<=��ͷ��
                }
                ).ThenCastElseContinue()
                /*.IfTrue(ctx =>
                {
                    IWorldCoordinate cursor = Hud.Window.CreateScreenCoordinate(Hud.Window.CursorX, Hud.Window.CursorY).ToWorldCoordinate();
                    bool isInBlizzard = ctx.Hud.Game.Actors.Any(x => (
                    x.SnoActor.Sno == ActorSnoEnum._wizard_blizzard ||
                    x.SnoActor.Sno == ActorSnoEnum._wizard_blizzard_addfreeze ||
                    x.SnoActor.Sno == ActorSnoEnum._wizard_blizzard_addtime ||
                    x.SnoActor.Sno == ActorSnoEnum._wizard_blizzard_addsize ||
                    x.SnoActor.Sno == ActorSnoEnum._wizard_blizzard_reducecost
                    ) && (x.FloorCoordinate.XYZDistanceTo(cursor) > (ctx.Skill.Rune == 1 ? 15 : 6)));//�ж�����Ƿ��ڱ���ѩ������
                    var ArcaneDynamo = ctx.Skill.Player.Powers.GetBuff(ctx.Hud.Sno.SnoPowers.Wizard_Passive_ArcaneDynamo.Sno);
                    bool isArcaneDynamoStackEnough = (ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.Wizard_Passive_ArcaneDynamo.Sno) ? ArcaneDynamo?.IconCounts[1] >= 5 : true);// ���ܱŽ�5�㣨�����ñ���ʱ���жϴ˲�����
                    bool isHydraEnough = ctx.Hud.Game.Actors.Where(act => act.SummonerAcdDynamicId == ctx.Skill.Player.SummonerAcdDynamicId &&
                    (
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_defaultfire_pool ||
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_runearcane_pool ||
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_runefrost_pool ||
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_runelightning_pool
                    ) && act.CentralXyDistanceToMe <= 50).Count() < 2;//��Χ50���ڶ�ͷ���Ƿ�������
                    return isInBlizzard && isArcaneDynamoStackEnough && isHydraEnough;
                }
                ).ThenCastElseContinue()*/
                .IfEnoughMonstersNearbyCursor(ctx => 15, ctx => 1).ThenContinueElseNoCast()//15�����������ʱ
                .IfTrue(ctx =>
                {
                    IWorldCoordinate cursor = Hud.Window.CreateScreenCoordinate(Hud.Window.CursorX, Hud.Window.CursorY).ToWorldCoordinate();
                    var HydraCount = ctx.Hud.Game.Actors.Where(act => act.SummonerAcdDynamicId == ctx.Skill.Player.SummonerAcdDynamicId && 
                    (
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_defaultfire_pool ||
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_runearcane_pool ||
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_runefrost_pool ||
                    act.SnoActor.Sno == ActorSnoEnum._wizard_hydra_runelightning_pool
                    ) && act.FloorCoordinate.XYZDistanceTo(cursor) <= 15).Count();//15���ڶ�ͷ������
                    var ArcaneDynamo = ctx.Skill.Player.Powers.GetBuff(ctx.Hud.Sno.SnoPowers.Wizard_Passive_ArcaneDynamo.Sno);
                    bool isArcaneDynamoStackEnough = (ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.Wizard_Passive_ArcaneDynamo.Sno) ? ArcaneDynamo?.IconCounts[1] >= 5 : true);// ���ܱŽ�5�㣨�����ñ���ʱ���жϴ˲�����
                    return HydraCount < 2 && isArcaneDynamoStackEnough;
                }).ThenCastElseContinue()
                ;
        }
    }
}
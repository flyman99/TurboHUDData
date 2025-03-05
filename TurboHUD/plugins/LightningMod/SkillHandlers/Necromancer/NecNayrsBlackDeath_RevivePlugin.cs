using System.Linq;
namespace Turbo.Plugins.LightningMod
{
    public class NecNayrsBlackDeath_RevivePlugin : AbstractSkillHandler, ISkillHandler
    {
        public NecNayrsBlackDeath_RevivePlugin()
            : base(CastType.SimpleSkill, CastPhase.AutoCast, CastPhase.UseWpStart, CastPhase.Move, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Necromancer_Revive;
            //Rune = 4//������
            CreateCastRule()
                .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Rune == 4).ThenContinueElseNoCast()
                .IfSpecificBuffIsActive(hud.Sno.SnoPowers.NayrsBlackDeath, 0).ThenContinueElseNoCast()//װ������
                .IfTrue(ctx=>
                {
                    int IconIndex = ctx.Skill.Key.GetHashCode() + 1;
                    var buff = ctx.Skill.Player.Powers.GetBuff(hud.Sno.SnoPowers.NayrsBlackDeath.Sno);
                    var remaining = buff?.Active == true ? buff.TimeLeftSeconds[IconIndex] : 0.0d;
                    bool NayrsBlackDeath = remaining < 8d;//����BUFF��ʣ��ʱ��
                    return (remaining == 0 ? true: isNoElite()) && //����BUFFû����ʧʱ��С�ֺ�BOSS�����ʱʩ�ţ������жϹ�������
                    isCorpse() && //20������ʬ��
                    NayrsBlackDeath;//����BUFF����8��ʣ��ʱ��
                }).ThenCastElseContinue()
                ;
        }
        private bool isNoElite()
        {
            IWorldCoordinate cur = Hud.Window.CreateScreenCoordinate(Hud.Window.CursorX, Hud.Window.CursorY).ToWorldCoordinate();
            bool isNoElite = Hud.Game.AliveMonsters.Any(m => m.FloorCoordinate.XYDistanceTo(cur) <= 20 && ((m.Rarity != ActorRarity.Champion && m.Rarity != ActorRarity.Rare) || m.AffixSnoList.Any(a => a.Affix == MonsterAffix.Juggernaut)) && !m.Illusion );
            return isCorpse();
        }
        private bool isCorpse()
        {
            IWorldCoordinate cur = Hud.Window.CreateScreenCoordinate(Hud.Window.CursorX, Hud.Window.CursorY).ToWorldCoordinate();
            bool isCorpse = Hud.Game.Actors.Any(a => a.SnoActor.Sno == ActorSnoEnum._p6_necro_corpse_flesh && a.FloorCoordinate.XYDistanceTo(cur) <= 20);//���20���ڴ���ʬ��
            return isCorpse;
        }
    }
}
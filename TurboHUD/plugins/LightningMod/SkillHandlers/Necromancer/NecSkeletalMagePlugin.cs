using System.Linq;
namespace Turbo.Plugins.LightningMod
{
    
    public class NecSkeletalMagePlugin : AbstractSkillHandler, ISkillHandler
    {
        private bool tempwalk1;
        private bool tempwalk2;
        public NecSkeletalMagePlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        public override void Load(IController hud)
        {
            
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Necromancer_SkeletalMage;
            CreateCastRule()
                .IfTrue(ctx =>
                {
                    return ctx.Skill.Rune == 4 && !ctx.Hud.Game.Me.Powers.BuffIsActive(484311);//��������˹����־
                }
                ).ThenContinueElseNoCast()//�����ַ��� 
                .IfCanCastSkill((int)Hud.Game.CurrentLatency + 50, (int)Hud.Game.CurrentLatency + 100, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfPrimaryResourceAmountIsAbove(ctx => (int)(40 - 40 * Hud.Game.Me.Stats.ResourceCostReduction) + 1).ThenContinueElseNoCast()//ȷ���б�������
                .IfBossIsNearby(ctx => 60).ThenContinueElseNoCast()//����60������BOSS
                .IfTrue(ctx =>
                {//ʩ����������ʱʩ���ٻ����ù�����ȷ����������ȫ�̸��ǹ���BUFF
                    var buffSimulacrum = Hud.Game.Me.Powers.GetBuff(Hud.Sno.SnoPowers.Necromancer_Simulacrum.Sno);//Ѫ��˫���ڼ�
                    var buffSkeletalMage = Hud.Game.Me.Powers.GetBuff(Hud.Sno.SnoPowers.Necromancer_SkeletalMage.Sno);//���÷�ʦ
                    return buffSkeletalMage?.IconCounts[6] < 2 && buffSimulacrum?.TimeElapsedSeconds[1] < 0.5 && buffSimulacrum?.TimeElapsedSeconds[1] != 0;
                }).ThenCastElseContinue()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.AquilaCuirass, 1).ThenContinueElseNoCast()//��ӥ����
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Necromancer_SkeletalMage, 6).ThenNoCastElseContinue()//���÷�ʦ����
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Necromancer_SkeletalMage, 3, 2000, 3000).ThenCastElseContinue()//������BUFF�������ڣ�2~3�����ڣ�
                ;

            CreateCastRule()//�귨
                .IfTrue(ctx =>
                {
                    return ctx.Skill.Rune == 1 || ctx.Hud.Game.Me.Powers.BuffIsActive(484311);//����˹����־
                }
                ).ThenContinueElseNoCast()//�����ע����
                .IfTrue(ctx =>
                {
                    return ctx.Skill.Rune == 3 && ctx.Hud.Game.Me.Powers.BuffIsActive(hud.Sno.SnoPowers.NayrsBlackDeath.Sno, 0);//����+�����ò�ʹ��
                }
                ).ThenNoCastElseContinue()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfEnoughMonstersNearby(ctx => 55, ctx => 1).ThenContinueElseNoCast()//������ΧҪ�й�
                /*.IfTrue(ctx =>//�Զ�������㣬��ΪЧ����������ʱ����
                {
                    int tempX = Hud.Window.CursorX;
                    int tempY = Hud.Window.CursorY;
                    IScreenCoordinate myCoordinate = ctx.Skill.Player.FloorCoordinate.ToScreenCoordinate();
                    if (ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.HexingPantsOfMrYan.Sno) && (ctx.Hud.Interaction.IsHotKeySet(ActionKey.Move) && !ctx.Hud.Interaction.IsContinuousActionStarted(ActionKey.Move)))
                    {
                        ctx.Hud.Interaction.MouseMove(myCoordinate.X + (tempwalk2 ?  0 : (tempwalk1 ? 1 : -1)), myCoordinate.Y + (tempwalk1 ? 0  :(tempwalk2 ? 1 : -1)));
                        ctx.Hud.Interaction.DoAction(ActionKey.Move);
                        ctx.Hud.Interaction.MouseMove(tempX, tempY);
                        tempwalk1 = !tempwalk1;
                        tempwalk2 = !tempwalk2;
                    }
                    return true;
                })*/
                .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()
                .IfPrimaryResourceAmountIsAbove(ctx => (int)(40 - 40 * Hud.Game.Me.Stats.ResourceCostReduction) + 1).ThenContinueElseNoCast()//ȷ���б�������
                .IfTrue(ctx =>
                {
                    int skeletons = 2;
                    if (ctx.Hud.Game.ActorQuery.IsEliteOrBossCloserThan(55, false))//�о�Ӣʱ
                    {
                        skeletons = 2;
                    }
                    else if (ctx.Skill.Player.Density.GetDensity(55) <= 15)//û�о�Ӣ��С�ڵ���15����ʱ
                    {
                        skeletons = 2;
                    }
                    else//û�о�Ӣ�Ҵ���15����ʱ
                    {
                        skeletons = 8;
                    }
                    var buff = Hud.Game.Me.Powers.GetBuff(Hud.Sno.SnoPowers.Necromancer_SkeletalMage.Sno);
                    return (buff?.IconCounts[6] < skeletons);//С��ָ��������ʩ��
                }).ThenCastElseContinue()//���ȱ�֤������������ٱ�֤��������
                .IfPrimaryResourcePercentageIsAbove((Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Necromancer_LandOfTheDead.Sno) || Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Necromancer_Simulacrum.Sno) || (Hud.Game.Actors.Where(x => x.SnoActor.Kind == ActorKind.HealthGlobe && x.IsOnScreen).Count() * Hud.Game.Me.Stats.ResourceMaxEssence * GetReapersWrapspercent() + (Hud.Game.Me.Powers.UsedSkills.Any(x => x.SnoPower.Sno == 460757) ? Hud.Game.Actors.Where(x => x.SnoActor.Sno == ActorSnoEnum._p6_necro_corpse_flesh && x.CentralXyDistanceToMe <= 60).Count() * 10 : 0) + Hud.Game.Me.Stats.ResourceCurEssence >= Hud.Game.Me.Stats.ResourceMaxEssence)) ? 100 : 90).ThenContinueElseNoCast()//�ж�Ϊ����״̬
                .IfTrue(ctx =>
                {
                    var actorsSkeletonMage = Hud.Game.Actors.Where(x => (
                    x.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_b ||//�޷��ġ�����֮��
                    x.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_c ||//�����ע
                    x.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_d ||//��������
                    x.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_e ||//��Ⱦ
                    x.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_f_archer//���ù�����
                    ) && x.SummonerAcdDynamicId == ctx.Hud.Game.Me.SummonerId //x.GetAttributeValueAsInt(Hud.Sno.Attributes.Pet_Owner, 0xFFFFF) == 0 
                    && (x.GetAttributeValue(Hud.Sno.Attributes.Multiplicative_Damage_Percent_Bonus, 0xFFFFF) >= (Hud.Game.Me.Stats.ResourceMaxEssence * 0.9 - (40 - 40 * Hud.Game.Me.Stats.ResourceCostReduction)) * 3 / 100 + 1));//�Լ��еĸ������ã��涯��󾫻����޵�90%
                    return actorsSkeletonMage.Count() < 10;
                }).ThenCastElseContinue()//10����������ʱ�����ж�
                .IfTrue(ctx => {
                    var monster = ctx.Hud.Game.SelectedMonster2;
                    return monster != null && monster.Invisible == false && (monster.IsElite == true || (monster.SnoMonster.Priority == MonsterPriority.goblin) || (monster.SnoMonster.Priority == MonsterPriority.boss) || (monster.SnoMonster.Priority == MonsterPriority.keywarden));
                    }
                ).ThenCastElseContinue()//���ѡ�о�Ӣ��BOSS���粼�֡�Կ�׹�ʱʩ��
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Necromancer_SkeletalMage, 6, 100, 500).ThenCastElseContinue()//�и������ü�����ʧ��0.5�����ڣ�
                ;
        }

        private float GetReapersWrapspercent()//��ȡ����߹�����Ч
        {
            float percent = 0;
            if (Hud.Game.Me.CubeSnoItem2 != null && Hud.Game.Me.CubeSnoItem2.Sno == Hud.Sno.SnoItems.Unique_Bracer_103_x1.Sno)
            {
                percent = 0.3f;
            }
            else
            {
                var Reapers = Hud.Game.Items.FirstOrDefault(item => item.Location == ItemLocation.Bracers && item.SnoItem.Sno == Hud.Sno.SnoItems.Unique_Bracer_103_x1.Sno);
                percent = Reapers == null ? 0 : (float)Reapers.Perfections.FirstOrDefault(p => p.Attribute.Code == "Item_Power_Passive").Cur;
            }
            return percent;
        }
    }
}
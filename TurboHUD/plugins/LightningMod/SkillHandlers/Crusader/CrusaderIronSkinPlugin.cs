namespace Turbo.Plugins.LightningMod
{
    using System.Linq;
    using Turbo.Plugins.glq;
    public class CrusaderIronSkinPlugin : AbstractSkillHandler, ISkillHandler
	{
        public CrusaderIronSkinPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Collect, CastPhase.Move, CastPhase.Attack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Crusader_IronSkin;

            CreateCastRule()//��������
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Rune == 3//���˷���ʱ����Ч
                   ).ThenNoCastElseContinue()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge).ThenNoCastElseContinue()//����ʱ����Ч
                .IfEnoughMonstersNearby(ctx => 100, ctx => 1).ThenContinueElseNoCast()
                .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Crusader_IronSkin, 0).ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Hud.Avoidance.CurrentValue).ThenCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Player.AvoidablesInRange.Any(x => x.AvoidableDefinition.InstantDeath)).ThenCastElseContinue()
                .IfHealthWarning(60, 80).ThenCastElseContinue()
                .IfTrue(ctx => (ctx.Skill.Player.Stats.CooldownReduction >= 0.5 || ctx.Hud.Game.Me.Powers.BuffIsActive(402459))).ThenContinueElseNoCast()//CDR����50����˻Ƶ�
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Crusader_IronSkin, 0, 50, 200).ThenCastElseContinue()
                ;
            CreateCastRule()//����֮��-����淨
               .IfInTown().ThenNoCastElseContinue()
               .IfCastingIdentify().ThenNoCastElseContinue()
               .IfCastingPortal().ThenNoCastElseContinue()
               .IfOnCooldown().ThenNoCastElseContinue()
               .IfTrue(ctx => ctx.Skill.Player.GetSetItemCount(580748) >= 6 && ctx.Skill.Player.Powers.GetUsedSkill(Hud.Sno.SnoPowers.Crusader_AkaratsChampion)?.Rune == 2).ThenNoCastElseContinue()//���˺�6��+����������ʿ������ʹ�ô˹���
               .IfTrue(ctx => ctx.Skill.Rune == 3 && ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.TheMortalDrama.Sno) &&//�����޳�
                   ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.ConventionOfElements.Sno)//Ԫ�ؽ�ָ
                   ).ThenContinueElseNoCast()
               .IfEnoughMonstersNearby(ctx => 30, ctx => 1).ThenContinueElseNoCast()
               .IfTrue(ctx =>
               {
                   return 
                   PublicClassPlugin.IsElementReady(hud, 3, ctx.Skill.Player, 6) || //������ǰ3��
                   (ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_PagesBuffInfiniteCasting.Sno) && !ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge.Sno)//���˼������������ʱ��ʩ�ţ���������ʱҲʩ��
                   );
               }
               ).ThenCastElseContinue()
               ;

            CreateCastRule()//����֮��-���˺����5222�淨
               .IfInTown().ThenNoCastElseContinue()
               .IfCastingIdentify().ThenNoCastElseContinue()
               .IfCastingPortal().ThenNoCastElseContinue()
               .IfOnCooldown().ThenNoCastElseContinue()
               .IfTrue(ctx => ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge.Sno)).ThenNoCastElseContinue()//������
               .IfTrue(ctx => ctx.Skill.Rune == 3 && ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.TheMortalDrama.Sno)//�����޳�
                   ).ThenContinueElseNoCast()
               .IfTrue(ctx => ctx.Skill.Player.GetSetItemCount(580748) >= 6 && ctx.Skill.Player.Powers.GetUsedSkill(Hud.Sno.SnoPowers.Crusader_AkaratsChampion)?.Rune == 2).ThenContinueElseNoCast()//���˺�6��+����������ʿ�������
               .IfEnoughMonstersNearby(ctx => 30, ctx => 1).ThenCastElseContinue()
               ;

            CreateCastRule()//����֮��-��ħ6��
               .IfInTown().ThenNoCastElseContinue()
               .IfCastingIdentify().ThenNoCastElseContinue()
               .IfCastingPortal().ThenNoCastElseContinue()
               .IfOnCooldown().ThenNoCastElseContinue()
               .IfTrue(ctx =>ctx.Skill.Player.GetSetItemCount(220113) >= 6).ThenContinueElseNoCast()//��ħ6��
               .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge).ThenNoCastElseContinue()//����ʱ��ʩ��
               .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Crusader_IronSkin, 0).ThenNoCastElseContinue()//����֮����Чʱ��ʩ��
               .IfEnoughMonstersNearby(ctx => 60, ctx => 1).ThenCastElseContinue()
               ;

        }
    }
}
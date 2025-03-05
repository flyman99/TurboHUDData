namespace Turbo.Plugins.LightningMod
{
    using Turbo.Plugins.glq;
    public class CrusaderBombardmentPlugin : AbstractSkillHandler, ISkillHandler
	{
        public CrusaderBombardmentPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Collect, CastPhase.Move, CastPhase.Attack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Crusader_Bombardment;

            CreateCastRule()
               .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()//�����ļ��100~150�ӳ�
               .IfInTown().ThenNoCastElseContinue()
               .IfCastingIdentify().ThenNoCastElseContinue()
               .IfCastingPortal().ThenNoCastElseContinue()
               .IfOnCooldown().ThenNoCastElseContinue()
               .IfCanCastSimple().ThenContinueElseNoCast()
               .IfTrue(ctx => ctx.Skill.Rune == 0).ThenContinueElseNoCast()//���Ͱ
               .IfTrue(ctx => ctx.Skill.Player.GetSetItemCount(580748) >= 6 && ctx.Skill.Player.Powers.GetUsedSkill(Hud.Sno.SnoPowers.Crusader_AkaratsChampion)?.Rune == 2).ThenNoCastElseContinue()//���˺�6��+����������ʿ������ʹ�ô˹���
               .IfTrue(ctx=> ctx.Skill.Player.GetSetItemCount(220113) >= 4).ThenNoCastElseContinue()//��ħ4����ħ�ļ���ʹ�ô˹���
               .IfTrue(ctx => ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.ConventionOfElements.Sno)).ThenContinueElseNoCast()//Ԫ�ؽ�ָ
               .IfEnoughMonstersNearby(ctx => 30, ctx => 1).ThenContinueElseNoCast()
               .IfTrue(ctx =>
               {
                   double LeftTime = PublicClassPlugin.GetHighestElementLeftSecondAssingedPlayer(hud, ctx.Skill.Player, 6);
                   if (ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_PagesBuffInfiniteCasting.Sno))//�������򣨰��˺�6��+����������ʿ������
                   {
                       if(!ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge.Sno))//������״̬
                       {
                           return (ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_PagesBuffInfiniteCasting.Sno) &&//�����޳�
                            ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.ConventionOfElements.Sno)) ||//Ԫ�ؽ�ָ
                            (LeftTime >= 15 || LeftTime <= 1)//��3~����1��֮���2��
                             ;
                       }
                       else
                       {
                           return false;
                       }
                   }
                   else
                   {
                       return
                       ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.ConventionOfElements.Sno) &&//Ԫ�ؽ�ָ
                       (LeftTime >= 15 || LeftTime <= 1)//��3~����1��֮���2��
                       ;
                   }
               }
               ).ThenCastElseContinue()
               ;

            CreateCastRule()
               .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()//�����ļ��100~150�ӳ�
               .IfInTown().ThenNoCastElseContinue()
               .IfCastingIdentify().ThenNoCastElseContinue()
               .IfCastingPortal().ThenNoCastElseContinue()
               .IfOnCooldown().ThenNoCastElseContinue()
               .IfCanCastSimple().ThenContinueElseNoCast()
               .IfTrue(ctx=> ctx.Skill.Player.GetSetItemCount(220113) >= 4 && !ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge.Sno)).ThenContinueElseNoCast()//��ħ4���ҷ�����״̬
               .IfEnoughMonstersNearbyCursor(ctx => 12, ctx => 1).ThenContinueElseNoCast()
               .IfSpecificBuffIsAboutToExpire(Hud.Sno.GetSnoPower(445639), 1, 500, 1000).ThenCastElseContinue()//���ֻ�ħ4������BUFF
               ;

            CreateCastRule()//����֮��-���˺����5222�淨
                .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()//�����ļ��100~150�ӳ�
               .IfInTown().ThenNoCastElseContinue()
               .IfCastingIdentify().ThenNoCastElseContinue()
               .IfCastingPortal().ThenNoCastElseContinue()
               .IfOnCooldown().ThenNoCastElseContinue()
               .IfCanCastSimple().ThenContinueElseNoCast()
               .IfTrue(ctx => ctx.Skill.Rune == 0).ThenContinueElseNoCast()//���Ͱ
               .IfTrue(ctx => ctx.Skill.Player.Powers.BuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge.Sno)).ThenNoCastElseContinue()//������
               .IfTrue(ctx => ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.TheMortalDrama.Sno)//�����޳�
                   ).ThenContinueElseNoCast()
               .IfTrue(ctx => ctx.Skill.Player.GetSetItemCount(580748) >= 6 && ctx.Skill.Player.Powers.GetUsedSkill(Hud.Sno.SnoPowers.Crusader_AkaratsChampion)?.Rune == 2 && ctx.Skill.Player.Powers.BuffIsActive(ctx.Hud.Sno.SnoPowers.Crusader_IronSkin.Sno)).ThenContinueElseNoCast()//���˺�6��+����������ʿ�������+����֮������
               .IfEnoughMonstersNearby(ctx => 30, ctx => 1).ThenCastElseContinue()
               ;
        }
    }
}
using System;
using System.Linq;
namespace Turbo.Plugins.LightningMod
{
    public class CrusaderPhalanxPlugin : AbstractSkillHandler, ISkillHandler
	{
        public CrusaderPhalanxPlugin()
            : base(CastType.SimpleSkill, CastPhase.AutoCast, CastPhase.Collect, CastPhase.Move, CastPhase.Attack)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Crusader_Phalanx;
            CreateCastRule()//���˺�
               .IfInTown().ThenNoCastElseContinue()
               .IfCastingIdentify().ThenNoCastElseContinue()
               .IfCastingPortal().ThenNoCastElseContinue()
               .IfOnCooldown().ThenNoCastElseContinue()
               .IfSpecificBuffIsActive(Hud.Sno.SnoPowers.Crusader_SteedCharge).ThenNoCastElseContinue()//����ʱ
               .IfTrue(ctx => ctx.Skill.Player.GetSetItemCount(580748) >= 2 && Hud.Game.Me.AnimationState == AcdAnimationState.Attacking).ThenCastElseContinue()//���˺����������ҹ���ʱʩ��
               ;
        }
    }
}
﻿using Turbo.Plugins.glq;
namespace Turbo.Plugins.LightningMod
{
    public class NecNayrsBlackDeath_BoneSpikesPlugin : AbstractSkillHandler, ISkillHandler
    {

        public NecNayrsBlackDeath_BoneSpikesPlugin()
            : base(CastType.BuffSkill, CastPhase.AutoCast, CastPhase.Attack, CastPhase.AttackIdle)
        {
            Enabled = false;
        }
        
        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Necromancer_BoneSpikes;
            CreateCastRule()
                .IfCanCastSkill(100, 150, 1000).ThenContinueElseNoCast()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingIdentify().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfOnCooldown().ThenNoCastElseContinue()
                .IfTrue(ctx => ctx.Skill.Rune == 2).ThenContinueElseNoCast()
                .IfSpecificBuffIsActive(hud.Sno.SnoPowers.NayrsBlackDeath, 0).ThenContinueElseNoCast()//装备黑镰
                .IfTrue(ctx =>
                {
                    int IconIndex = ctx.Skill.Key.GetHashCode() + 1;
                    var buff = ctx.Skill.Player.Powers.GetBuff(hud.Sno.SnoPowers.NayrsBlackDeath.Sno);
                    var remaining = buff?.Active == true ? buff.TimeLeftSeconds[IconIndex] : 0.0d;
                    if (remaining < 0.5d)
                    {
                        return true;//BUFF小于0.5秒后施放
                    }
                    else if (ctx.Skill.Player.Powers.BuffIsActive(hud.Sno.SnoPowers.ConventionOfElements.Sno))//元素戒
                    {
                        var Coe = PublicClassPlugin.GetHighestElementLeftSecond(hud, hud.Game.Me, 2);
                        return remaining < Coe;//剩余BUFF不足覆盖爆发时间时施放
                    }
                    return false;
                }).ThenCastElseContinue()
            ;
        }
    }
}
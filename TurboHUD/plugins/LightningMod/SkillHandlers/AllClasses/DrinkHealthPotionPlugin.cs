﻿namespace Turbo.Plugins.LightningMod
{
    using System.Linq;

    public class DrinkHealthPotionPlugin : AbstractSkillHandler, ISkillHandler
    {
        public int SDT { get; set; }
        public int HC { get; set; }
        public int InDanger { get; set; }
        public DrinkHealthPotionPlugin()
            : base(CastType.SimpleSkill, CastPhase.AutoCast, CastPhase.Collect)
        {
            Enabled = false;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            AssignedSnoPower = Hud.Sno.SnoPowers.Generic_DrinkHealthPotion;

            CreateCastRule()
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                //.IfOnCooldown().ThenNoCastElseContinue() //It is ineffective for Potion
                .IfTrue(IsPotionOnCoolDown).ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                //.IfCanCastSkill(50, 50, 50).ThenContinueElseNoCast()
                .IfHealthPercentageIsBelow(ctx =>
                {
                    var limit = SDT;
                    if (ctx.Skill.Player.HeroIsHardcore) limit = HC;
                    if (ctx.Skill.Player.AvoidablesInRange.Any(x => x.AvoidableDefinition.Type == AvoidableType.IceBalls)) limit = InDanger;
                    return limit;
                }).ThenCastElseContinue()
                ;

            CreateCastRule()//随机触发三神圈
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfTrue(IsPotionOnCoolDown).ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfTrue(ctx => Hud.Game.Me.Powers.BuffIsActive(488004)).ThenContinueElseNoCast()//祭坛药水buff1
                //.IfTrue(ctx => Hud.Game.AliveMonsters?.Any(m => m.IsOnScreen && m.Rarity == ActorRarity.Boss && !m.Invulnerable) == true && (Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.ZeisStoneOfVengeancePrimary.Sno) || Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Wizard_Passive_PowerHungry.Sno))).ThenCastElseContinue()//屏幕内有BOSS且法师奥能渴求被动或贼神时施放
                .IfEliteOrBossIsNearby(ctx => 25).ThenCastElseContinue()
                ;

            CreateCastRule()//喝药水减少附近25码内敌人伤害
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfTrue(IsPotionOnCoolDown).ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfTrue(ctx => Hud.Game.Me.Powers.BuffIsActive(488036)).ThenContinueElseNoCast()//祭坛药水buff2
                .IfEliteOrBossIsNearby(ctx => 25).ThenCastElseContinue()
                ;

            CreateCastRule()//喝药水获得圣坛效果
                .IfInTown().ThenNoCastElseContinue()
                .IfCastingPortal().ThenNoCastElseContinue()
                .IfTrue(IsPotionOnCoolDown).ThenNoCastElseContinue()
                .IfCanCastSimple().ThenContinueElseNoCast()
                .IfTrue(ctx => Hud.Game.Me.Powers.BuffIsActive(488037)).ThenContinueElseNoCast()//祭坛药水buff3
                /*
                .IfTrue(ctx => {
                    var powerbuff = Hud.Game.Me.Powers.GetBuff(Hud.Sno.SnoPowers.Generic_PagesBuffDamage.Sno);
                    if (Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_PagesBuffDamage.Sno) == false || (powerbuff != null && powerbuff.TimeLeftSeconds[0] < 16 && powerbuff.TimeLeftSeconds[0] > 0) || !Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.BaneOfThePowerfulPrimary.Sno))//威能塔剩余16秒以上不生效(不带困者该规则无效)
                    {
                        return true;
                    }
                    return false;
                }).ThenContinueElseNoCast()*/
                //.IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Generic_PagesBuffDamage, 0, 16, 16).ThenContinueElseNoCast()//威能塔剩余大于16秒时不放
                .IfEliteOrBossIsNearby(ctx => 25).ThenCastElseContinue()//30码遭遇精英或BOSS施放
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Generic_ShrineDesecratedBlessed, 0, 120, 120).ThenCastElseContinue()//祝福圣坛
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Generic_ShrineDesecratedEnlightened, 0, 120, 120).ThenCastElseContinue()//启迪圣坛
                //.IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Generic_ShrineDesecratedFortune, 0, 120, 120).ThenCastElseContinue()//幸运圣坛
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Generic_ShrineDesecratedFrenzied, 0, 120, 120).ThenCastElseContinue()//狂怒圣坛
                .IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Generic_ShrineDesecratedHoarder, 0, 120, 120).ThenCastElseContinue()//疾行圣坛
                //.IfSpecificBuffIsAboutToExpire(Hud.Sno.SnoPowers.Generic_ShrineDesecratedReloaded, 0, 120, 120).ThenCastElseContinue()//增效圣坛
                ;
        }
        private bool IsPotionOnCoolDown(TestContext ctx)
        {
            bool IsOnCooldown;
            double Cooldown;
            Cooldown = (Hud.Game.Me.Powers.HealthPotionSkill.CooldownFinishTick - Hud.Game.CurrentGameTick) / 60d;
            IsOnCooldown = Cooldown <= 30 && Cooldown >= 0 ? true : false;
            return IsOnCooldown;
        }
    }
}
﻿using System.Collections.Generic;

namespace Turbo.Plugins
{
    public interface ISnoPowerList
    {
        IEnumerable<ISnoPower> GetClassSpecificPowers(HeroClass heroClass);
        IEnumerable<ISnoPower> GetLegendaryGemPowers();
        IEnumerable<ISnoPower> GetLegendaryItemPowers();

        // Barbarian skills
        ISnoPower Barbarian_AncientSpear { get; } // 377453
        ISnoPower Barbarian_Avalanche { get; } // 353447
        ISnoPower Barbarian_Bash { get; } // 79242
        ISnoPower Barbarian_BattleRage { get; } // 79076
        ISnoPower Barbarian_CallOfTheAncients { get; } // 80049
        ISnoPower Barbarian_Cleave { get; } // 80263
        ISnoPower Barbarian_Earthquake { get; } // 98878
        ISnoPower Barbarian_Frenzy { get; } // 78548
        ISnoPower Barbarian_FuriousCharge { get; } // 97435
        ISnoPower Barbarian_GroundStomp { get; } // 79446
        ISnoPower Barbarian_HammerOfTheAncients { get; } // 80028
        ISnoPower Barbarian_IgnorePain { get; } // 79528
        ISnoPower Barbarian_Leap { get; } // 93409
        ISnoPower Barbarian_Overpower { get; } // 159169
        ISnoPower Barbarian_Rend { get; } // 70472
        ISnoPower Barbarian_Revenge { get; } // 109342
        ISnoPower Barbarian_SeismicSlam { get; } // 86989
        ISnoPower Barbarian_Sprint { get; } // 78551
        ISnoPower Barbarian_ThreateningShout { get; } // 79077
        ISnoPower Barbarian_WarCry { get; } // 375483
        ISnoPower Barbarian_WeaponThrow { get; } // 377452
        ISnoPower Barbarian_Whirlwind { get; } // 96296
        ISnoPower Barbarian_WrathOfTheBerserker { get; } // 79607
        ISnoPower Barbarian_Passive_Animosity { get; } // 205228
        ISnoPower Barbarian_Passive_BerserkerRage { get; } // 205187
        ISnoPower Barbarian_Passive_Bloodthirst { get; } // 205217
        ISnoPower Barbarian_Passive_BoonOfBulKathos { get; } // 204603
        ISnoPower Barbarian_Passive_Brawler { get; } // 205133
        ISnoPower Barbarian_Passive_EarthenMight { get; } // 361661
        ISnoPower Barbarian_Passive_InspiringPresence { get; } // 205546
        ISnoPower Barbarian_Passive_Juggernaut { get; } // 205707
        ISnoPower Barbarian_Passive_NervesOfSteel { get; } // 217819
        ISnoPower Barbarian_Passive_NoEscape { get; } // 204725
        ISnoPower Barbarian_Passive_PoundOfFlesh { get; } // 205205
        ISnoPower Barbarian_Passive_Rampage { get; } // 296572
        ISnoPower Barbarian_Passive_Relentless { get; } // 205398
        ISnoPower Barbarian_Passive_Ruthless { get; } // 205175
        ISnoPower Barbarian_Passive_Superstition { get; } // 205491
        ISnoPower Barbarian_Passive_SwordAndBoard { get; } // 340877
        ISnoPower Barbarian_Passive_ToughAsNails { get; } // 205848
        ISnoPower Barbarian_Passive_Unforgiving { get; } // 205300
        ISnoPower Barbarian_Passive_WeaponsMaster { get; } // 206147

        // Crusader skills
        ISnoPower Crusader_AkaratsChampion { get; } // 269032
        ISnoPower Crusader_BlessedHammer { get; } // 266766
        ISnoPower Crusader_BlessedShield { get; } // 266951
        ISnoPower Crusader_Bombardment { get; } // 284876
        ISnoPower Crusader_Condemn { get; } // 266627
        ISnoPower Crusader_Consecration { get; } // 273941
        ISnoPower Crusader_CrushingResolve { get; } // 267818
        ISnoPower Crusader_FallingSword { get; } // 239137
        ISnoPower Crusader_FistOfTheHeavens { get; } // 239218
        ISnoPower Crusader_HeavensFury { get; } // 316014
        ISnoPower Crusader_IronSkin { get; } // 291804
        ISnoPower Crusader_Judgment { get; } // 267600
        ISnoPower Crusader_Justice { get; } // 325216
        ISnoPower Crusader_LawsOfHope { get; } // 342279
        ISnoPower Crusader_LawsOfJustice { get; } // 342280
        ISnoPower Crusader_LawsOfValor { get; } // 342281
        ISnoPower Crusader_Phalanx { get; } // 330729
        ISnoPower Crusader_Provoke { get; } // 290545
        ISnoPower Crusader_Punish { get; } // 285903
        ISnoPower Crusader_ShieldBash { get; } // 353492
        ISnoPower Crusader_ShieldGlare { get; } // 268530
        ISnoPower Crusader_Slash { get; } // 289243
        ISnoPower Crusader_Smite { get; } // 286510
        ISnoPower Crusader_SteedCharge { get; } // 243853
        ISnoPower Crusader_SweepAttack { get; } // 239042
        ISnoPower Crusader_Passive_Blunt { get; } // 348773
        ISnoPower Crusader_Passive_DivineFortress { get; } // 356176
        ISnoPower Crusader_Passive_Fanaticism { get; } // 357269
        ISnoPower Crusader_Passive_Fervor { get; } // 357218
        ISnoPower Crusader_Passive_Finery { get; } // 311629
        ISnoPower Crusader_Passive_HeavenlyStrength { get; } // 286177
        ISnoPower Crusader_Passive_HoldYourGround { get; } // 302500
        ISnoPower Crusader_Passive_HolyCause { get; } // 310804
        ISnoPower Crusader_Passive_Indestructible { get; } // 309830
        ISnoPower Crusader_Passive_Insurmountable { get; } // 310640
        ISnoPower Crusader_Passive_IronMaiden { get; } // 310783
        ISnoPower Crusader_Passive_LongArmOfTheLaw { get; } // 310678
        ISnoPower Crusader_Passive_LordCommander { get; } // 348741
        ISnoPower Crusader_Passive_Renewal { get; } // 356173
        ISnoPower Crusader_Passive_Righteousness { get; } // 356147
        ISnoPower Crusader_Passive_ToweringShield { get; } // 356052
        ISnoPower Crusader_Passive_Vigilant { get; } // 310626
        ISnoPower Crusader_Passive_Wrathful { get; } // 310775

        // Demon Hunter skills
        ISnoPower DemonHunter_Bolas { get; } // 77552
        ISnoPower DemonHunter_Caltrops { get; } // 129216
        ISnoPower DemonHunter_Chakram { get; } // 129213
        ISnoPower DemonHunter_ClusterArrow { get; } // 129214
        ISnoPower DemonHunter_Companion { get; } // 365311
        ISnoPower DemonHunter_ElementalArrow { get; } // 131325
        ISnoPower DemonHunter_EntanglingShot { get; } // 361936
        ISnoPower DemonHunter_EvasiveFire { get; } // 377450
        ISnoPower DemonHunter_FanOfKnives { get; } // 77546
        ISnoPower DemonHunter_Grenades { get; } // 86610
        ISnoPower DemonHunter_HungeringArrow { get; } // 129215
        ISnoPower DemonHunter_Impale { get; } // 131366
        ISnoPower DemonHunter_MarkedForDeath { get; } // 130738
        ISnoPower DemonHunter_Multishot { get; } // 77649
        ISnoPower DemonHunter_P74Ballista { get; } // 487822
        ISnoPower DemonHunter_Preparation { get; } // 129212
        ISnoPower DemonHunter_RainOfVengeance { get; } // 130831
        ISnoPower DemonHunter_RapidFire { get; } // 131192
        ISnoPower DemonHunter_Sentry { get; } // 129217
        ISnoPower DemonHunter_ShadowPower { get; } // 130830
        ISnoPower DemonHunter_SmokeScreen { get; } // 130695
        ISnoPower DemonHunter_SpikeTrap { get; } // 75301
        ISnoPower DemonHunter_Strafe { get; } // 134030
        ISnoPower DemonHunter_Vault { get; } // 111215
        ISnoPower DemonHunter_Vengeance { get; } // 302846
        ISnoPower DemonHunter_Passive_Ambush { get; } // 352920
        ISnoPower DemonHunter_Passive_Archery { get; } // 209734
        ISnoPower DemonHunter_Passive_Awareness { get; } // 324770
        ISnoPower DemonHunter_Passive_Ballistics { get; } // 155723
        ISnoPower DemonHunter_Passive_Brooding { get; } // 210801
        ISnoPower DemonHunter_Passive_CompanionPassiveEffect { get; } // 365312
        ISnoPower DemonHunter_Passive_CullTheWeak { get; } // 155721
        ISnoPower DemonHunter_Passive_CustomEngineering { get; } // 208610
        ISnoPower DemonHunter_Passive_Grenadier { get; } // 208779
        ISnoPower DemonHunter_Passive_HotPursuit { get; } // 155725
        ISnoPower DemonHunter_Passive_Leech { get; } // 439525
        ISnoPower DemonHunter_Passive_NightStalker { get; } // 218350
        ISnoPower DemonHunter_Passive_NumbingTraps { get; } // 218398
        ISnoPower DemonHunter_Passive_Perfectionist { get; } // 155722
        ISnoPower DemonHunter_Passive_PreparationPassiveEffect { get; } // 324845
        ISnoPower DemonHunter_Passive_Sharpshooter { get; } // 155715
        ISnoPower DemonHunter_Passive_SingleOut { get; } // 338859
        ISnoPower DemonHunter_Passive_SteadyAim { get; } // 164363
        ISnoPower DemonHunter_Passive_TacticalAdvantage { get; } // 218385
        ISnoPower DemonHunter_Passive_ThrillOfTheHunt { get; } // 211225
        ISnoPower DemonHunter_Passive_VengeancePassiveEffect { get; } // 155714

        // Monk skills
        ISnoPower Monk_BlindingFlash { get; } // 136954
        ISnoPower Monk_BreathOfHeaven { get; } // 69130
        ISnoPower Monk_CripplingWave { get; } // 96311
        ISnoPower Monk_CycloneStrike { get; } // 223473
        ISnoPower Monk_DashingStrike { get; } // 312736
        ISnoPower Monk_DeadlyReach { get; } // 96019
        ISnoPower Monk_Epiphany { get; } // 312307
        ISnoPower Monk_ExplodingPalm { get; } // 97328
        ISnoPower Monk_FistsOfThunder { get; } // 95940
        ISnoPower Monk_InnerSanctuary { get; } // 317076
        ISnoPower Monk_LashingTailKick { get; } // 111676
        ISnoPower Monk_MantraOfConviction { get; } // 375088
        ISnoPower Monk_MantraOfHealing { get; } // 373143
        ISnoPower Monk_MantraOfRetribution { get; } // 375082
        ISnoPower Monk_MantraOfSalvation { get; } // 375049
        ISnoPower Monk_MysticAlly { get; } // 362102
        ISnoPower Monk_P74WayOfTheHundredFists { get; } // 487707
        ISnoPower Monk_Serenity { get; } // 96215
        ISnoPower Monk_SevenSidedStrike { get; } // 96694
        ISnoPower Monk_SweepingWind { get; } // 96090
        ISnoPower Monk_TempestRush { get; } // 121442
        ISnoPower Monk_WaveOfLight { get; } // 96033
        ISnoPower Monk_WayOfTheHundredFists { get; } // 97110
        ISnoPower Monk_Passive_Alacrity { get; } // 156492
        ISnoPower Monk_Passive_BeaconOfYtar { get; } // 209104
        ISnoPower Monk_Passive_ChantOfResonance { get; } // 156467
        ISnoPower Monk_Passive_CombinationStrike { get; } // 218415
        ISnoPower Monk_Passive_Determination { get; } // 402633
        ISnoPower Monk_Passive_ExaltedSoul { get; } // 209027
        ISnoPower Monk_Passive_FleetFooted { get; } // 209029
        ISnoPower Monk_Passive_Harmony { get; } // 404168
        ISnoPower Monk_Passive_MantraOfConvictionV2 { get; } // 375089
        ISnoPower Monk_Passive_MantraOfEvasionV2 { get; } // 375050
        ISnoPower Monk_Passive_MantraOfHealingV2 { get; } // 373154
        ISnoPower Monk_Passive_MantraOfRetributionV2 { get; } // 375083
        ISnoPower Monk_Passive_Momentum { get; } // 341559
        ISnoPower Monk_Passive_MythicRhythm { get; } // 315271
        ISnoPower Monk_Passive_NearDeathExperience { get; } // 156484
        ISnoPower Monk_Passive_RelentlessAssault { get; } // 404245
        ISnoPower Monk_Passive_Resolve { get; } // 211581
        ISnoPower Monk_Passive_SeizeTheInitiative { get; } // 209628
        ISnoPower Monk_Passive_SixthSense { get; } // 209622
        ISnoPower Monk_Passive_TheGuardiansPath { get; } // 209812
        ISnoPower Monk_Passive_Transcendence { get; } // 209250
        ISnoPower Monk_Passive_Unity { get; } // 368899

        // Necromancer skills
        ISnoPower Necromancer_ArmyOfTheDead { get; } // 460358
        ISnoPower Necromancer_BloodRush { get; } // 454090
        ISnoPower Necromancer_BoneArmor { get; } // 466857
        ISnoPower Necromancer_BoneSpear { get; } // 451490
        ISnoPower Necromancer_BoneSpikes { get; } // 462147
        ISnoPower Necromancer_BoneSpirit { get; } // 464896
        ISnoPower Necromancer_CommandGolem { get; } // 451537
        ISnoPower Necromancer_CommandSkeletons { get; } // 453801
        ISnoPower Necromancer_CorpseExplosion { get; } // 454174
        ISnoPower Necromancer_CorpseLance { get; } // 461650
        ISnoPower Necromancer_DeathNova { get; } // 462243
        ISnoPower Necromancer_Decrepify { get; } // 451491
        ISnoPower Necromancer_Devour { get; } // 460757
        ISnoPower Necromancer_Frailty { get; } // 460870
        ISnoPower Necromancer_GrimScythe { get; } // 462198
        ISnoPower Necromancer_LandOfTheDead { get; } // 465839
        ISnoPower Necromancer_Leech { get; } // 462255
        ISnoPower Necromancer_Revive { get; } // 462239
        ISnoPower Necromancer_Simulacrum { get; } // 465350
        ISnoPower Necromancer_SiphonBlood { get; } // 453563
        ISnoPower Necromancer_SkeletalMage { get; } // 462089
        ISnoPower Necromancer_Passive_AberrantAnimator { get; } // 472949
        ISnoPower Necromancer_Passive_BloodForBlood { get; } // 465821
        ISnoPower Necromancer_Passive_BloodIsPower { get; } // 465037
        ISnoPower Necromancer_Passive_BonePrison { get; } // 472965
        ISnoPower Necromancer_Passive_CommanderOfTheRisenDead { get; } // 472962
        ISnoPower Necromancer_Passive_DarkReaping { get; } // 470812
        ISnoPower Necromancer_Passive_DecrepifyPassiveEffect { get; } // 471738
        ISnoPower Necromancer_Passive_DrawLife { get; } // 465264
        ISnoPower Necromancer_Passive_EternalTorment { get; } // 472795
        ISnoPower Necromancer_Passive_ExtendedServitude { get; } // 464994
        ISnoPower Necromancer_Passive_FinalService { get; } // 465952
        ISnoPower Necromancer_Passive_FrailtyPassiveEffect { get; } // 471845
        ISnoPower Necromancer_Passive_FueledByDeath { get; } // 465917
        ISnoPower Necromancer_Passive_GrislyTribute { get; } // 473019
        ISnoPower Necromancer_Passive_LeechPassiveEffect { get; } // 471869
        ISnoPower Necromancer_Passive_LifeFromDeath { get; } // 465703
        ISnoPower Necromancer_Passive_OverwhelmingEssence { get; } // 470764
        ISnoPower Necromancer_Passive_RathmasShield { get; } // 472910
        ISnoPower Necromancer_Passive_RigorMortis { get; } // 466415
        ISnoPower Necromancer_Passive_Serration { get; } // 472905
        ISnoPower Necromancer_Passive_SpreadingMalediction { get; } // 472220
        ISnoPower Necromancer_Passive_StandAlone { get; } // 470725
        ISnoPower Necromancer_Passive_SwiftHarvesting { get; } // 470805

        // Witch Doctor skills
        ISnoPower WitchDoctor_AcidCloud { get; } // 70455
        ISnoPower WitchDoctor_BigBadVoodoo { get; } // 117402
        ISnoPower WitchDoctor_CorpseSpider { get; } // 69866
        ISnoPower WitchDoctor_FetishArmy { get; } // 72785
        ISnoPower WitchDoctor_Firebats { get; } // 105963
        ISnoPower WitchDoctor_Firebomb { get; } // 67567
        ISnoPower WitchDoctor_Gargantuan { get; } // 30624
        ISnoPower WitchDoctor_GraspOfTheDead { get; } // 69182
        ISnoPower WitchDoctor_Haunt { get; } // 83602
        ISnoPower WitchDoctor_Hex { get; } // 30631
        ISnoPower WitchDoctor_Horrify { get; } // 67668
        ISnoPower WitchDoctor_LocustSwarm { get; } // 69867
        ISnoPower WitchDoctor_MassConfusion { get; } // 67600
        ISnoPower WitchDoctor_Piranhas { get; } // 347265
        ISnoPower WitchDoctor_PlagueOfToads { get; } // 106465
        ISnoPower WitchDoctor_PoisonDart { get; } // 103181
        ISnoPower WitchDoctor_Sacrifice { get; } // 102572
        ISnoPower WitchDoctor_SoulHarvest { get; } // 67616
        ISnoPower WitchDoctor_SpiritBarrage { get; } // 108506
        ISnoPower WitchDoctor_SpiritWalk { get; } // 106237
        ISnoPower WitchDoctor_SummonZombieDog { get; } // 102573
        ISnoPower WitchDoctor_WallOfDeath { get; } // 134837
        ISnoPower WitchDoctor_ZombieCharger { get; } // 74003
        ISnoPower WitchDoctor_Passive_BadMedicine { get; } // 217826
        ISnoPower WitchDoctor_Passive_BloodRitual { get; } // 208568
        ISnoPower WitchDoctor_Passive_CircleOfLife { get; } // 208571
        ISnoPower WitchDoctor_Passive_ConfidenceRitual { get; } // 442741
        ISnoPower WitchDoctor_Passive_CreepingDeath { get; } // 340908
        ISnoPower WitchDoctor_Passive_FetishSycophants { get; } // 218588
        ISnoPower WitchDoctor_Passive_FierceLoyalty { get; } // 208639
        ISnoPower WitchDoctor_Passive_GraveInjustice { get; } // 218191
        ISnoPower WitchDoctor_Passive_GruesomeFeast { get; } // 208594
        ISnoPower WitchDoctor_Passive_JungleFortitude { get; } // 217968
        ISnoPower WitchDoctor_Passive_MidnightFeast { get; } // 340909
        ISnoPower WitchDoctor_Passive_PierceTheVeil { get; } // 208628
        ISnoPower WitchDoctor_Passive_RushOfEssence { get; } // 208565
        ISnoPower WitchDoctor_Passive_SpiritualAttunement { get; } // 208569
        ISnoPower WitchDoctor_Passive_SpiritVessel { get; } // 218501
        ISnoPower WitchDoctor_Passive_SwamplandAttunement { get; } // 340910
        ISnoPower WitchDoctor_Passive_TraitZombieDogSpawner { get; } // 109560
        ISnoPower WitchDoctor_Passive_TribalRites { get; } // 208601
        ISnoPower WitchDoctor_Passive_VisionQuest { get; } // 209041
        ISnoPower WitchDoctor_Passive_ZombieHandler { get; } // 208563

        // Wizard skills
        ISnoPower Wizard_ArcaneOrb { get; } // 30668
        ISnoPower Wizard_ArcaneTorrent { get; } // 134456
        ISnoPower Wizard_Archon { get; } // 134872
        ISnoPower Wizard_ArchonArcaneBlast { get; } // 167355
        ISnoPower Wizard_ArchonArcaneBlastCold { get; } // 392883
        ISnoPower Wizard_ArchonArcaneBlastFire { get; } // 392884
        ISnoPower Wizard_ArchonArcaneBlastLightning { get; } // 392885
        ISnoPower Wizard_ArchonArcaneStrike { get; } // 135166
        ISnoPower Wizard_ArchonArcaneStrikeCold { get; } // 392886
        ISnoPower Wizard_ArchonArcaneStrikeFire { get; } // 392887
        ISnoPower Wizard_ArchonArcaneStrikeLightning { get; } // 392888
        ISnoPower Wizard_ArchonCancel { get; } // 166616
        ISnoPower Wizard_ArchonDisintegrationWave { get; } // 135238
        ISnoPower Wizard_ArchonDisintegrationWaveCold { get; } // 392889
        ISnoPower Wizard_ArchonDisintegrationWaveFire { get; } // 392890
        ISnoPower Wizard_ArchonDisintegrationWaveLightning { get; } // 392891
        ISnoPower Wizard_ArchonSlowTime { get; } // 135663
        ISnoPower Wizard_ArchonTeleport { get; } // 167648
        ISnoPower Wizard_BlackHole { get; } // 243141
        ISnoPower Wizard_Blizzard { get; } // 30680
        ISnoPower Wizard_DiamondSkin { get; } // 75599
        ISnoPower Wizard_Disintegrate { get; } // 91549
        ISnoPower Wizard_Electrocute { get; } // 1765
        ISnoPower Wizard_EnergyArmor { get; } // 86991
        ISnoPower Wizard_EnergyTwister { get; } // 77113
        ISnoPower Wizard_ExplosiveBlast { get; } // 87525
        ISnoPower Wizard_Familiar { get; } // 99120
        ISnoPower Wizard_FrostNova { get; } // 30718
        ISnoPower Wizard_Hydra { get; } // 30725
        ISnoPower Wizard_IceArmor { get; } // 73223
        ISnoPower Wizard_MagicMissile { get; } // 30744
        ISnoPower Wizard_MagicWeapon { get; } // 76108
        ISnoPower Wizard_Meteor { get; } // 69190
        ISnoPower Wizard_MirrorImage { get; } // 98027
        ISnoPower Wizard_RayOfFrost { get; } // 93395
        ISnoPower Wizard_ShockPulse { get; } // 30783
        ISnoPower Wizard_SlowTime { get; } // 1769
        ISnoPower Wizard_SpectralBlade { get; } // 71548
        ISnoPower Wizard_StormArmor { get; } // 74499
        ISnoPower Wizard_Teleport { get; } // 168344
        ISnoPower Wizard_WaveOfForce { get; } // 30796
        ISnoPower Wizard_Passive_ArcaneDynamo { get; } // 208823
        ISnoPower Wizard_Passive_AstralPresence { get; } // 208472
        ISnoPower Wizard_Passive_Audacity { get; } // 341540
        ISnoPower Wizard_Passive_Blur { get; } // 208468
        ISnoPower Wizard_Passive_ColdBlooded { get; } // 226301
        ISnoPower Wizard_Passive_Conflagration { get; } // 218044
        ISnoPower Wizard_Passive_Dominance { get; } // 341344
        ISnoPower Wizard_Passive_ElementalExposure { get; } // 342326
        ISnoPower Wizard_Passive_Evocation { get; } // 208473
        ISnoPower Wizard_Passive_GalvanizingWard { get; } // 208541
        ISnoPower Wizard_Passive_GlassCannon { get; } // 208471
        ISnoPower Wizard_Passive_Illusionist { get; } // 208547
        ISnoPower Wizard_Passive_Paralysis { get; } // 226348
        ISnoPower Wizard_Passive_PowerHungry { get; } // 208478
        ISnoPower Wizard_Passive_Prodigy { get; } // 208493
        ISnoPower Wizard_Passive_TemporalFlux { get; } // 208477
        ISnoPower Wizard_Passive_UnstableAnomaly { get; } // 208474
        ISnoPower Wizard_Passive_UnwaveringWill { get; } // 298038

        // Legendary gems
		ISnoPower BaneOfThePowerfulPrimary { get; } // 383014
		ISnoPower BaneOfThePowerfulSecondary { get; } // 451157
		ISnoPower BaneOfTheStrickenPrimary { get; } // 428348
		ISnoPower BaneOfTheStrickenSecondary { get; } // 428349
		ISnoPower BaneOfTheTrappedPrimary { get; } // 403456
		ISnoPower BaneOfTheTrappedSecondary { get; } // 403457
		ISnoPower BoonOfTheHoarderPrimary { get; } // 403470
		ISnoPower BoonOfTheHoarderSecondary { get; } // 403784
		ISnoPower BoyarskysChipPrimary { get; } // 428352
		ISnoPower BoyarskysChipSecondary { get; } // 428353
		ISnoPower EnforcerPrimary { get; } // 403466
		ISnoPower EnforcerSecondary { get; } // 403472
		ISnoPower EsotericAlterationPrimary { get; } // 428029
		ISnoPower EsotericAlterationSecondary { get; } // 428030
		ISnoPower GemOfEasePrimary { get; } // 403459
		ISnoPower GemOfEaseSecondary { get; } // 428691
		ISnoPower GemOfEfficaciousToxinPrimary { get; } // 403461
		ISnoPower GemOfEfficaciousToxinSecondary { get; } // 403556
		ISnoPower GogokOfSwiftnessPrimary { get; } // 403464
		ISnoPower GogokOfSwiftnessSecondary { get; } // 403524
		ISnoPower IceblinkPrimary { get; } // 428354
		ISnoPower IceblinkSecondary { get; } // 428356
		ISnoPower InvigoratingGemstonePrimary { get; } // 403465
		ISnoPower InvigoratingGemstoneSecondary { get; } // 403624
		ISnoPower LegacyOfDreamsPrimary { get; } // 483319
		ISnoPower LegacyOfDreamsSecondary { get; } // 483320
		ISnoPower MirinaeTeardropOfTheStarweaverPrimary { get; } // 403463
		ISnoPower MirinaeTeardropOfTheStarweaverSecondary { get; } // 403620
		ISnoPower MoltenWildebeestsGizzardPrimary { get; } // 428031
		ISnoPower MoltenWildebeestsGizzardSecondary { get; } // 428032
		ISnoPower MoratoriumPrimary { get; } // 403467
		ISnoPower MoratoriumSecondary { get; } // 403687
		ISnoPower MutilationGuardPrimary { get; } // 428350
		ISnoPower MutilationGuardSecondary { get; } // 428351
		ISnoPower PainEnhancerPrimary { get; } // 403462
		ISnoPower PainEnhancerSecondary { get; } // 403600
		ISnoPower RedSoulShardPrimary { get; } // 454736
		ISnoPower RedSoulShardSecondary { get; } // 454737
		ISnoPower SimplicitysStrengthPrimary { get; } // 403469
		ISnoPower SimplicitysStrengthSecondary { get; } // 403473
		ISnoPower TaegukPrimary { get; } // 403471
		ISnoPower TaegukSecondary { get; } // 403785
		ISnoPower WhisperOfAtonementPrimary { get; } // 486910
		ISnoPower WhisperOfAtonementSecondary { get; } // 486910
		ISnoPower WreathOfLightningPrimary { get; } // 403460
		ISnoPower WreathOfLightningSecondary { get; } // 403560
		ISnoPower ZeisStoneOfVengeancePrimary { get; } // 403468
		ISnoPower ZeisStoneOfVengeanceSecondary { get; } // 403727

        // Legendary items
        ISnoPower AetherWalker { get; } // 397788 - ItemPassive_Unique_Ring_759_x1
        ISnoPower AhavarionSpearOfLycander { get; } // 318868 - ItemPassive_Unique_Ring_672_x1
        ISnoPower AkaratsAwakening { get; } // 318888 - ItemPassive_Unique_Ring_692_x1
        ISnoPower AkkhansAddendum { get; } // 445943 - P4_ItemPassive_Unique_Ring_019
        ISnoPower AkkhansLeniency { get; } // 488910 - P76_ItemPassive_Unique_Ring_003
        ISnoPower AkkhansManacles { get; } // 446008 - P4_ItemPassive_Unique_Ring_020
        ISnoPower AmbosPride { get; } // 483675 - P67_ItemPassive_Unique_Ring_954
        ISnoPower AncestorsGrace { get; } // 318378 - ItemPassive_Unique_Ring_516_x1
        ISnoPower AncientParthanDefenders { get; } // 318770 - ItemPassive_Unique_Ring_588_x1
        ISnoPower AndarielsVisage { get; } // 434034 - itemPassive_Unique_Helm_003_p2
        ISnoPower AnessaziEdge { get; } // 318720 - ItemPassive_Unique_Ring_549_x1
        ISnoPower AngelHairBraid { get; } // 402415 - ItemPassive_Unique_Ring_907_x1
        ISnoPower AquilaCuirass { get; } // 449064 - P4_ItemPassive_Unique_Ring_075
        ISnoPower ArchmagesVicalyke { get; } // 318777 - ItemPassive_Unique_Ring_595_x1
        ISnoPower Arcstone { get; } // 359598 - ItemPassive_Unique_Ring_745_x1
        ISnoPower ArmorOfTheKindRegent { get; } // 318892 - ItemPassive_Unique_Ring_696_x1
        ISnoPower ArreatsLaw { get; } // 486951 - P73_ItemPassive_Unique_Ring_002
        ISnoPower ArthefsSparkOfLife { get; } // 318757 - ItemPassive_Unique_Ring_575_x1
        ISnoPower AshnagarrsBloodBracer { get; } // 449043 - P4_ItemPassive_Unique_Ring_070
        ISnoPower AugustinesPanacea { get; } // 451169 - P41_ItemPassive_Unique_Ring_011
        ISnoPower Azurewrath { get; } // 441723 - ItemPassive_Unique_Sword_1H_012_p3
        ISnoPower BakuliJungleWraps { get; } // 451163 - P41_ItemPassive_Unique_Ring_005
        ISnoPower Balance { get; } // 478475 - P61_ItemPassive_Unique_Ring_003
        ISnoPower BalefulRemnant { get; } // 359545 - ItemPassive_Unique_Ring_704_x1
        ISnoPower BandOfHollowWhispers { get; } // 364345 - ItemPassive_Unique_Ring_001_x1
        ISnoPower BandOfMight { get; } // 447060 - P4_ItemPassive_Unique_Ring_049
        ISnoPower BandOfTheRueChambers { get; } // 318434 - ItemPassive_Unique_Ring_541_x1
        ISnoPower BastionsRevered { get; } // 484244 - P68_ItemPassive_Unique_Ring_015
        ISnoPower BeckonSail { get; } // 318420 - ItemPassive_Unique_Ring_531_x1
        ISnoPower BeltOfTheTrove { get; } // 484602 - P610_ItemPassive_Unique_Ring_008
        ISnoPower BeltOfTranscendence { get; } // 430671 - P2_ItemPassive_Unique_Ring_035
        ISnoPower BindingOfTheLost { get; } // 440598 - P3_ItemPassive_Unique_Ring_027
        ISnoPower BindingsOfTheLesserGods { get; } // 485725 - P71_ItemPassive_Unique_Ring_003
        ISnoPower Blackfeather { get; } // 318882 - ItemPassive_Unique_Ring_686_x1
        ISnoPower BladeOfProphecy { get; } // 478476 - P61_ItemPassive_Unique_Ring_004
        ISnoPower BladeOfTheTribes { get; } // 484604 - P610_ItemPassive_Unique_Ring_010
        ISnoPower BladeOfTheWarlord { get; } // 447375 - P4_ItemPassive_Unique_Ring_056
        ISnoPower BlessedOfHaull { get; } // 430681 - P2_ItemPassive_Unique_Ring_045
        ISnoPower BloodBrother { get; } // 402456 - ItemPassive_Unique_Ring_917_x1
        ISnoPower BloodsongMail { get; } // 476585 - P6_ItemPassive_Unique_Ring_064
        ISnoPower BloodtideBlade { get; } // 475251 - P6_ItemPassive_Unique_Ring_047
        ISnoPower BombardiersRucksack { get; } // 486306 - P72_ItemPassive_Unique_Ring_007
        ISnoPower BondsOfCLena { get; } // 485504 - P7_ItemPassive_Unique_Ring_007
        ISnoPower BoneRinger { get; } // 476584 - P6_ItemPassive_Unique_Ring_063
        ISnoPower BottomlessPotionOfAmplification { get; } // 434626 - X1_Legendary_Potion_09
        ISnoPower BottomlessPotionOfChaos { get; } // 451310 - X1_Legendary_Potion_10
        ISnoPower BottomlessPotionOfFear { get; } // 428812 - X1_Legendary_Potion_08
        ISnoPower BottomlessPotionOfKulleAid { get; } // 344094 - X1_Legendary_Potion_06
        ISnoPower BottomlessPotionOfRejuvenation { get; } // 433021 - P2_Legendary_Potion_07
        ISnoPower BottomlessPotionOfTheUnfettered { get; } // 483315 - X1_Legendary_Potion_11
        ISnoPower BovineBardiche { get; } // 318382 - ItemPassive_Unique_Ring_520_x1
        ISnoPower BracerOfFury { get; } // 446162 - P4_ItemPassive_Unique_Ring_025
        ISnoPower BracersOfDestruction { get; } // 483847 - P67_ItemPassive_Unique_Ring_035
        ISnoPower BracersOfTheFirstMen { get; } // 441279 - P3_ItemPassive_Unique_Ring_032
        ISnoPower BriggsWrath { get; } // 475252 - P6_ItemPassive_Unique_Ring_049
        ISnoPower BrokenCrown { get; } // 423231 - P2_ItemPassive_Unique_Ring_008
        ISnoPower BrokenPromises { get; } // 402462 - ItemPassive_Unique_Ring_923_x1
        ISnoPower BroodOfAraneae { get; } // 486136 - P72_ItemPassive_Unique_Ring_004
        ISnoPower BrynersJourney { get; } // 475245 - P6_ItemPassive_Unique_Ring_041
        ISnoPower BulKathossWeddingBand { get; } // 364340 - ItemPassive_Unique_Ring_020_x1
        ISnoPower BurizaDoKyanon { get; } // 374344 - ItemPassive_Unique_XBow_011_x1
        ISnoPower ButchersCarver { get; } // 246118 - ItemPassive_Unique_Axe_2H_001
        ISnoPower Calamity { get; } // 318360 - ItemPassive_Unique_Ring_509_x1
        ISnoPower CamsRebuttal { get; } // 318358 - ItemPassive_Unique_Ring_507_x1
        ISnoPower CapeOfTheDarkNight { get; } // 318421 - ItemPassive_Unique_Ring_532_x1
        ISnoPower Carnevil { get; } // 483481 - P65_ItemPassive_Unique_Ring_576_x1
        ISnoPower CesarsMemento { get; } // 449031 - P4_ItemPassive_Unique_Ring_068
        ISnoPower Chaingmail { get; } // 318798 - ItemPassive_Unique_Ring_616_x1
        ISnoPower ChainOfShadows { get; } // 445266 - P4_ItemPassive_Unique_Ring_006
        ISnoPower ChanonBolter { get; } // 488010 - P75_ItemPassive_Unique_Ring_004
        ISnoPower ChilaniksChain { get; } // 318821 - ItemPassive_Unique_Ring_639_x1
        ISnoPower Cindercoat { get; } // 318790 - ItemPassive_Unique_Ring_608_x1
        ISnoPower CircleOfNailujsEvol { get; } // 475247 - P6_ItemPassive_Unique_Ring_043
        ISnoPower Cluckeye { get; } // 488809 - P76_ItemPassive_Unique_Ring_002
        ISnoPower CoilsOfTheFirstSpider { get; } // 440790 - P3_ItemPassive_Unique_Ring_029
        ISnoPower ConventionOfElements { get; } // 430674 - P2_ItemPassive_Unique_Ring_038
        ISnoPower CordOfTheSherma { get; } // 434008 - ItemPassive_Unique_Ring_560_p2
        ISnoPower CorpsewhisperPauldrons { get; } // 476580 - P6_ItemPassive_Unique_Ring_059
        ISnoPower CorruptedAshbringer { get; } // 402455 - ItemPassive_Unique_Ring_916_x1
        ISnoPower CountessJuliasCameo { get; } // 318381 - ItemPassive_Unique_Ring_519_x1
        ISnoPower CrashingRain { get; } // 359554 - ItemPassive_Unique_Ring_709_x1
        ISnoPower CrownOfThePrimus { get; } // 487653 - P74_ItemPassive_Unique_Ring_003
        ISnoPower CrystalFist { get; } // 451170 - P41_ItemPassive_Unique_Ring_012
        ISnoPower CusterianWristguards { get; } // 359557 - ItemPassive_Unique_Ring_712_x1
        ISnoPower DanettasRevenge { get; } // 318813 - ItemPassive_Unique_Ring_631_x1
        ISnoPower DanettasSpite { get; } // 318348 - ItemPassive_Unique_Ring_504_x1
        ISnoPower Darklight { get; } // 483790 - P67_ItemPassive_Unique_Ring_697
        ISnoPower DarkMagesShade { get; } // 318788 - ItemPassive_Unique_Ring_606_x1
        ISnoPower Dawn { get; } // 446146 - P4_ItemPassive_Unique_Ring_023
        ISnoPower DaynteesBinding { get; } // 478534 - P61_ItemPassive_Unique_Ring_024
        ISnoPower DeadlyRebirth { get; } // 318808 - ItemPassive_Unique_Ring_626_x1
        ISnoPower DeadMansLegacy { get; } // 478486 - P61_ItemPassive_Unique_Ring_013
        ISnoPower DeathseersCowl { get; } // 318857 - ItemPassive_Unique_Ring_662_x1
        ISnoPower DeathWatchMantle { get; } // 434005 - ItemPassive_Unique_Shoulder_002_p2
        ISnoPower Deathwish { get; } // 449063 - P4_ItemPassive_Unique_Ring_074
        ISnoPower DefenderOfWestmarch { get; } // 434004 - ItemPassive_Unique_Ring_643_p2
        ISnoPower DefilerCuisses { get; } // 485506 - P7_ItemPassive_Unique_Ring_045
        ISnoPower DemonMachine { get; } // 364332 - ItemPassive_Unique_XBow_001_x1
        ISnoPower Denial { get; } // 435016 - P2_ItemPassive_Unique_Ring_058
        ISnoPower DepthDiggers { get; } // 402416 - ItemPassive_Unique_Ring_908_x1
        ISnoPower DishonoredLegacy { get; } // 441294 - P3_ItemPassive_Unique_Ring_034
        ISnoPower DovuEnergyTrap { get; } // 318867 - ItemPassive_Unique_Ring_671_x1
        ISnoPower DrakonsLesson { get; } // 430678 - P2_ItemPassive_Unique_Ring_042
        ISnoPower DreadIron { get; } // 430679 - P2_ItemPassive_Unique_Ring_043
        ISnoPower DregsOfLies { get; } // 486126 - P72_ItemPassive_Soulshard_001
        ISnoPower EberliCharo { get; } // 318853 - ItemPassive_Unique_Ring_658_x1
        ISnoPower EchoingFury { get; } // 483518 - P66_ItemPassive_Unique_Ring_927
        ISnoPower ElusiveRing { get; } // 446187 - P4_ItemPassive_Unique_Ring_026
        ISnoPower EmimeisDuffel { get; } // 484294 - P69_ItemPassive_Unique_Ring_620
        ISnoPower EnchantingFavor { get; } // 318835 - ItemPassive_Unique_Ring_653_x1
        ISnoPower EssenceOfAnguish { get; } // 486198 - P72_ItemPassive_Soulshard_017
        ISnoPower EtchedSigil { get; } // 484596 - P610_ItemPassive_Unique_Ring_002
        ISnoPower EternalUnion { get; } // 487798 - P74_ItemPassive_Unique_Ring_011
        ISnoPower Eunjangdo { get; } // 402457 - ItemPassive_Unique_Ring_918_x1
        ISnoPower EyeOfPeshkov { get; } // 318431 - ItemPassive_Unique_Ring_538_x1
        ISnoPower FaithfulMemory { get; } // 454927 - P43_ItemPassive_Unique_Ring_002
        ISnoPower FateOfTheFell { get; } // 478478 - P61_ItemPassive_Unique_Ring_006
        ISnoPower FatesVow { get; } // 478508 - P61_ItemPassive_Unique_Ring_019
        ISnoPower FazulasImprobableChain { get; } // 437854 - P3_ItemPassive_Unique_Ring_014
        ISnoPower FireWalkers { get; } // 434010 - ItemPassive_Unique_Boots_007_p2
        ISnoPower FjordCutter { get; } // 483848 - P67_ItemPassive_Unique_Mighty_1H_006
        ISnoPower FlailOfTheAscended { get; } // 451164 - P41_ItemPassive_Unique_Ring_006
        ISnoPower Fleshrake { get; } // 451168 - P41_ItemPassive_Unique_Ring_010
        ISnoPower FlyingDragon { get; } // 246562 - ItemPassive_Unique_CombatStaff_2H_009
        ISnoPower FortressBallista { get; } // 447816 - P4_ItemPassive_Unique_Ring_061
        ISnoPower FragmentOfDestiny { get; } // 484599 - P610_ItemPassive_Unique_Ring_005
        ISnoPower FragmentOfDestruction { get; } // 486213 - P72_ItemPassive_Soulshard_021
        ISnoPower FreezeOfDeflection { get; } // 318816 - ItemPassive_Unique_Ring_634_x1
        ISnoPower Frostburn { get; } // 451167 - P41_ItemPassive_Unique_Ring_009
        ISnoPower FrydehrsWrath { get; } // 478477 - P61_ItemPassive_Unique_Ring_005
        ISnoPower Fulminator { get; } // 441681 - ItemPassive_Unique_Ring_612_p3
        ISnoPower FuneraryPick { get; } // 487651 - P74_ItemPassive_Unique_Ring_001
        ISnoPower FuryOfTheAncients { get; } // 483849 - P67_ItemPassive_Unique_Ring_955
        ISnoPower FuryOfTheVanishedPeak { get; } // 478489 - P61_ItemPassive_Unique_Ring_016
        ISnoPower GabrielsVambraces { get; } // 436521 - P3_ItemPassive_Unique_Ring_008
        ISnoPower GazingDemise { get; } // 484270 - P68_ItemPassive_Unique_Ring_017
        ISnoPower GelmindorsMarrowGuards { get; } // 484588 - P610_ItemPassive_Unique_Ring_001
        ISnoPower Genzaniku { get; } // 364311 - ItemPassive_Unique_Axe_1H_003_x1
        ISnoPower GestureOfOrpheus { get; } // 318376 - ItemPassive_Unique_Ring_514_x1
        ISnoPower GirdleOfGiants { get; } // 451237 - P42_ItemPassive_Unique_Ring_002
        ISnoPower GladiatorGauntlets { get; } // 318799 - ItemPassive_Unique_Ring_617_x1
        ISnoPower GoldenFlense { get; } // 478537 - P61_ItemPassive_Unique_Ring_025
        ISnoPower Goldskin { get; } // 246515 - ItemPassive_Unique_Chest_001
        ISnoPower Goldwrap { get; } // 318875 - ItemPassive_Unique_Ring_679_x1
        ISnoPower GolemskinBreeches { get; } // 478510 - P61_ItemPassive_Unique_Ring_020
        ISnoPower GraspsOfEssence { get; } // 484310 - P69_ItemPassive_Unique_Ring_044
        ISnoPower GuardOfJohanna { get; } // 436481 - P3_ItemPassive_Unique_Ring_007
        ISnoPower GungdoGear { get; } // 484605 - P610_ItemPassive_Unique_Ring_011
        ISnoPower GyanaNaKashu { get; } // 318426 - ItemPassive_Unique_Ring_534_x1
        ISnoPower GyrfalconsFoote { get; } // 478513 - P61_ItemPassive_Unique_Ring_022
        ISnoPower Hack { get; } // 318869 - ItemPassive_Unique_Ring_673_x1
        ISnoPower HallowedBulwark { get; } // 318887 - ItemPassive_Unique_Ring_691_x1
        ISnoPower HaloOfArlyse { get; } // 429648 - P2_ItemPassive_Unique_Ring_024
        ISnoPower HaloOfKarini { get; } // 478538 - P61_ItemPassive_Unique_Ring_026
        ISnoPower HammerJammers { get; } // 446502 - P4_ItemPassive_Unique_Ring_030
        ISnoPower HandOfTheProphet { get; } // 318377 - ItemPassive_Unique_Ring_515_x1
        ISnoPower HarringtonWaistguard { get; } // 318881 - ItemPassive_Unique_Ring_685_x1
        ISnoPower HauntedVisions { get; } // 484309 - P69_ItemPassive_Unique_Ring_069
        ISnoPower HauntingGirdle { get; } // 434966 - P2_ItemPassive_Unique_Ring_054
        ISnoPower HauntOfVaxo { get; } // 318782 - ItemPassive_Unique_Ring_600_x1
        ISnoPower HeartOfIron { get; } // 446615 - P4_ItemPassive_Unique_Ring_036
        ISnoPower HellcatWaistguard { get; } // 454934 - P43_ItemPassive_Unique_Ring_006
        ISnoPower Hellrack { get; } // 247577 - itemPassive_Unique_XBow_002
        ISnoPower Hellskull { get; } // 318891 - ItemPassive_Unique_Ring_695_x1
        ISnoPower HenrisPerquisition { get; } // 440457 - P3_ItemPassive_Unique_Ring_024
        ISnoPower HergbrashsBinding { get; } // 449048 - P4_ItemPassive_Unique_Ring_072
        ISnoPower HexingPantsOfMrYan { get; } // 318817 - ItemPassive_Unique_Ring_635_x1
        ISnoPower HillenbrandsTrainingSword { get; } // 359604 - ItemPassive_Unique_Ring_748_x1
        ISnoPower HolyPointShot { get; } // 484313 - P69_ItemPassive_Unique_Ring_002
        ISnoPower HomingPads { get; } // 318801 - ItemPassive_Unique_Ring_619_x1
        ISnoPower Homunculus { get; } // 374670 - ItemPassive_Unique_Mojo_003_x1
        ISnoPower HuntersWrath { get; } // 440743 - P3_ItemPassive_Unique_Ring_028
        ISnoPower HwojWrap { get; } // 318800 - ItemPassive_Unique_Ring_618_x1
        ISnoPower IceClimbers { get; } // 318741 - ItemPassive_Unique_Ring_559_x1
        ISnoPower IncenseTorchOfTheGrandTemple { get; } // 478473 - P61_ItemPassive_Unique_Ring_001
        ISnoPower Ingeom { get; } // 402458 - ItemPassive_Unique_Ring_919_x1
        ISnoPower InviolableFaith { get; } // 318894 - ItemPassive_Unique_Ring_698_x1
        ISnoPower IronRose { get; } // 487652 - P74_ItemPassive_Unique_Ring_002
        ISnoPower IrontoeMudsputters { get; } // 318877 - ItemPassive_Unique_Ring_681_x1
        ISnoPower IvoryTower { get; } // 430683 - P2_ItemPassive_Unique_Ring_047
        ISnoPower JacesHammerOfVigilance { get; } // 318851 - ItemPassive_Unique_Ring_656_x1
        ISnoPower JangsEnvelopment { get; } // 318795 - ItemPassive_Unique_Ring_613_x1
        ISnoPower Jawbreaker { get; } // 318432 - ItemPassive_Unique_Ring_539_x1
        ISnoPower Jekangbord { get; } // 478514 - P61_ItemPassive_Unique_Ring_023
        ISnoPower JeramsBracers { get; } // 441278 - P3_ItemPassive_Unique_Ring_031
        ISnoPower JohannasArgument { get; } // 436430 - P3_ItemPassive_Unique_Ring_004
        ISnoPower JusticeLantern { get; } // 446565 - P4_ItemPassive_Unique_Ring_034
        ISnoPower JustiniansMercy { get; } // 318895 - ItemPassive_Unique_Ring_699_x1
        ISnoPower KarleisPoint { get; } // 478484 - P61_ItemPassive_Unique_Ring_011
        ISnoPower KassarsRetribution { get; } // 359538 - ItemPassive_Unique_Ring_701_x1
        ISnoPower KekegisUnbreakableSpirit { get; } // 318751 - ItemPassive_Unique_Ring_569_x1
        ISnoPower KhassettsCordOfRighteousness { get; } // 451238 - P42_ItemPassive_Unique_Ring_003
        ISnoPower KmarTenclip { get; } // 318423 - ItemPassive_Unique_Ring_533_x1
        ISnoPower KredesFlame { get; } // 318865 - ItemPassive_Unique_Ring_669_x1
        ISnoPower KrelmsBuffBelt { get; } // 359602 - ItemPassive_Unique_Ring_747_x1
        ISnoPower KrelmsBuffBracers { get; } // 359591 - ItemPassive_Unique_Ring_741_x1
        ISnoPower Kridershot { get; } // 318379 - ItemPassive_Unique_Ring_517_x1
        ISnoPower KrysbinsSentence { get; } // 475241 - P6_ItemPassive_Unique_Ring_037
        ISnoPower KymbosGold { get; } // 359597 - ItemPassive_Unique_Ring_744_x1
        ISnoPower KyoshirosBlade { get; } // 447368 - P4_ItemPassive_Unique_Ring_054
        ISnoPower KyoshirosSoul { get; } // 447130 - P4_ItemPassive_Unique_Ring_050
        ISnoPower LakumbasOrnament { get; } // 486131 - P72_ItemPassive_Unique_Ring_001
        ISnoPower Lamentation { get; } // 483792 - P67_ItemPassive_Unique_Ring_742
        ISnoPower LastBreath { get; } // 447030 - P4_ItemPassive_Unique_Ring_047
        ISnoPower LefebvresSoliloquy { get; } // 449236 - P4_ItemPassive_Unique_Ring_078
        ISnoPower LegersDisdain { get; } // 476696 - P6_ItemPassive_Unique_Ring_074
        ISnoPower LeonineBowOfHashir { get; } // 484293 - P69_ItemPassive_Unique_Ring_755
        ISnoPower LiannasWings { get; } // 447696 - P4_ItemPassive_Unique_Ring_060
        ISnoPower LightOfGrace { get; } // 318855 - ItemPassive_Unique_Ring_660_x1
        ISnoPower LionsClaw { get; } // 402451 - ItemPassive_Unique_Ring_915_x1
        ISnoPower LordGreenstonesFan { get; } // 445274 - P4_ItemPassive_Unique_Ring_007
        ISnoPower LornellesSunstone { get; } // 475244 - P6_ItemPassive_Unique_Ring_040
        ISnoPower LostTime { get; } // 476684 - P6_ItemPassive_Unique_Ring_070
        ISnoPower LutSocks { get; } // 318810 - ItemPassive_Unique_Ring_628_x1
        ISnoPower MadawcsSorrow { get; } // 318744 - ItemPassive_Unique_Ring_562_x1
        ISnoPower Madstone { get; } // 402540 - p1_ItemPassive_Unique_Ring_941
        ISnoPower Magefist { get; } // 451166 - P41_ItemPassive_Unique_Ring_008
        ISnoPower MalothsFocus { get; } // 246780 - itemPassive_Unique_Staff_006
        ISnoPower MaltoriusPetrifiedSpike { get; } // 475246 - P6_ItemPassive_Unique_Ring_042
        ISnoPower ManaldHeal { get; } // 454930 - P43_ItemPassive_Unique_Ring_004
        ISnoPower Manticore { get; } // 478483 - P61_ItemPassive_Unique_Ring_010
        ISnoPower MantleOfChanneling { get; } // 446640 - P4_ItemPassive_Unique_Ring_039
        ISnoPower MarasKaleidoscope { get; } // 318719 - ItemPassive_Unique_Ring_548_x1
        ISnoPower MaskOfJeram { get; } // 318411 - ItemPassive_Unique_Ring_526_x1
        ISnoPower MaskOfScarletDeath { get; } // 476581 - P6_ItemPassive_Unique_Ring_060
        ISnoPower Maximus { get; } // 364317 - ItemPassive_Unique_Sword_2H_010_x1
        ISnoPower MempoOfTwilight { get; } // 487972 - P74_ItemPassive_Unique_Ring_015
        ISnoPower MesserschmidtsReaver { get; } // 483522 - P66_ItemPassive_Unique_Ring_929
        ISnoPower Mirrorball { get; } // 487928 - P74_ItemPassive_Unique_Ring_013
        ISnoPower MoonlightWard { get; } // 364343 - itemPassive_Unique_Amulet_003_x1
        ISnoPower MordullusPromise { get; } // 447029 - P4_ItemPassive_Unique_Ring_046
        ISnoPower MoribundGauntlets { get; } // 476589 - P6_ItemPassive_Unique_Ring_068
        ISnoPower MorticksBrace { get; } // 430135 - P2_ItemPassive_Unique_Ring_032
        ISnoPower MykensBallOfHate { get; } // 318775 - ItemPassive_Unique_Ring_593_x1
        ISnoPower Nagelring { get; } // 402460 - ItemPassive_Unique_Ring_921_x1
        ISnoPower NayrsBlackDeath { get; } // 476587 - P6_ItemPassive_Unique_Ring_066
        ISnoPower NemesisBracers { get; } // 318820 - ItemPassive_Unique_Ring_638_x1
        ISnoPower NilfursBoast { get; } // 478554 - P61_ItemPassive_Unique_Ring_029
        ISnoPower Oathkeeper { get; } // 447372 - P4_ItemPassive_Unique_Ring_055
        ISnoPower ObsidianRingOfTheZodiac { get; } // 402459 - ItemPassive_Unique_Ring_920_x1
        ISnoPower OculusRing { get; } // 402461 - ItemPassive_Unique_Ring_922_x1
        ISnoPower OdynSon { get; } // 364325 - itemPassive_Unique_Mace_1H_002_x1
        ISnoPower OdysseysEnd { get; } // 484297 - P69_ItemPassive_Unique_Ring_023
        ISnoPower Omnislash { get; } // 430682 - P2_ItemPassive_Unique_Ring_046
        ISnoPower OmrynsChain { get; } // 423229 - P2_ItemPassive_Unique_Ring_006
        ISnoPower OrbOfInfiniteDepth { get; } // 478481 - P61_ItemPassive_Unique_Ring_009
        ISnoPower PigSticker { get; } // 245836 - ItemPassive_Unique_Dagger_007
        ISnoPower PintosPride { get; } // 447295 - P4_ItemPassive_Unique_Ring_053
        ISnoPower PoxFaulds { get; } // 434009 - itemPassive_Unique_Pants_007_p2
        ISnoPower PrideOfCassius { get; } // 318419 - ItemPassive_Unique_Ring_530_x1
        ISnoPower PrimordialSoul { get; } // 448998 - P4_ItemPassive_Unique_Ring_065
        ISnoPower PromiseOfGlory { get; } // 318871 - ItemPassive_Unique_Ring_675_x1
        ISnoPower PusSpitter { get; } // 364335 - ItemPassive_Unique_XBow_012_x1
        ISnoPower PuzzleRing { get; } // 318375 - ItemPassive_Unique_Ring_513_x1
        ISnoPower Quetzalcoatl { get; } // 318796 - ItemPassive_Unique_Ring_614_x1
        ISnoPower RabidStrike { get; } // 486099 - P71_ItemPassive_Unique_Ring_004
        ISnoPower RakoffsGlassOfLife { get; } // 318410 - ItemPassive_Unique_Ring_525_x1
        ISnoPower RanslorsFolly { get; } // 478491 - P61_ItemPassive_Unique_Ring_018
        ISnoPower RazethsVolition { get; } // 484311 - P69_ItemPassive_Unique_Ring_057
        ISnoPower RazorStrop { get; } // 318241 - ItemPassive_Unique_Ring_500_x1
        ISnoPower RechelsRingOfLarceny { get; } // 318870 - ItemPassive_Unique_Ring_674_x1
        ISnoPower ReilenasShadowhook { get; } // 475253 - P6_ItemPassive_Unique_Ring_048
        ISnoPower RelicOfAkarat { get; } // 318377 - ItemPassive_Unique_Ring_515_x1
        ISnoPower RemnantOfPain { get; } // 486134 - P72_ItemPassive_Soulshard_005
        ISnoPower Remorseless { get; } // 483793 - P67_ItemPassive_Unique_Ring_762
        ISnoPower RequiemCereplate { get; } // 476579 - P6_ItemPassive_Unique_Ring_058
        ISnoPower RhenhoFlayer { get; } // 318812 - ItemPassive_Unique_Ring_630_x1
        ISnoPower RibaldEtchings { get; } // 318377 - ItemPassive_Unique_Ring_515_x1
        ISnoPower Rimeheart { get; } // 318864 - ItemPassive_Unique_Ring_668_x1
        ISnoPower RingOfEmptiness { get; } // 445694 - P4_ItemPassive_Unique_Ring_012
        ISnoPower RiveraDancers { get; } // 447043 - P4_ItemPassive_Unique_Ring_048
        ISnoPower RogarsHugeStone { get; } // 318861 - ItemPassive_Unique_Ring_665_x1
        ISnoPower SacredHarness { get; } // 440434 - P3_ItemPassive_Unique_Ring_023
        ISnoPower SacredHarvester { get; } // 410217 - p1_ItemPassive_Unique_Ring_944
        ISnoPower SaffronWrap { get; } // 454918 - P43_ItemPassive_Unique_Ring_001
        ISnoPower SashOfKnives { get; } // 434038 - ItemPassive_Unique_Ring_753_p2
        ISnoPower Scarbringer { get; } // 478474 - P61_ItemPassive_Unique_Ring_002
        ISnoPower SchaefersHammer { get; } // 434033 - ItemPassive_Unique_Mace_2H_009_p2
        ISnoPower Scourge { get; } // 364321 - ItemPassive_Unique_Sword_2H_004_x1
        ISnoPower Scrimshaw { get; } // 484603 - P610_ItemPassive_Unique_Ring_009
        ISnoPower ScytheOfTheCycle { get; } // 476586 - P6_ItemPassive_Unique_Ring_065
        ISnoPower SeborsNightmare { get; } // 434039 - ItemPassive_Unique_Ring_651_p2
        ISnoPower SerpentsSparker { get; } // 484117 - P68_ItemPassive_Unique_Ring_510
        ISnoPower Sever { get; } // 249967 - ItemPassive_Unique_Sword_1H_007
        ISnoPower ShardOfHate { get; } // 359587 - ItemPassive_Unique_Ring_739_x1
        ISnoPower ShardOfHatred { get; } // 486178 - P72_ItemPassive_Soulshard_009
        ISnoPower ShieldOfFury { get; } // 446142 - P4_ItemPassive_Unique_Ring_022
        ISnoPower ShiMizusHaori { get; } // 318779 - ItemPassive_Unique_Ring_597_x1
        ISnoPower ShukranisTriumph { get; } // 486132 - P72_ItemPassive_Unique_Ring_002
        ISnoPower SinSeekers { get; } // 483505 - P65_ItemPassive_Unique_Ring_076
        ISnoPower SkeletonKey { get; } // 318835 - ItemPassive_Unique_Ring_653_x1
        ISnoPower SkularsSalvation { get; } // 486949 - P73_ItemPassive_Unique_Ring_001
        ISnoPower SkullGrasp { get; } // 451160 - P41_ItemPassive_Unique_Ring_002
        ISnoPower SkullOfResonance { get; } // 318773 - ItemPassive_Unique_Ring_591_x1
        ISnoPower Skycutter { get; } // 364315 - ItemPassive_Unique_Sword_1H_004_x1
        ISnoPower SkySplitter { get; } // 433993 - ItemPassive_Unique_Axe_1H_005_p2
        ISnoPower Skywarden { get; } // 359550 - ItemPassive_Unique_Ring_706_x1
        ISnoPower SlipkasLetterOpener { get; } // 359604 - ItemPassive_Unique_Ring_748_x1
        ISnoPower SliverOfTerror { get; } // 486182 - P72_ItemPassive_Soulshard_013
        ISnoPower SloraksMadness { get; } // 248686 - itemPassive_Unique_Wand_013
        ISnoPower SmokingThurible { get; } // 318835 - ItemPassive_Unique_Ring_653_x1
        ISnoPower Solanium { get; } // 318873 - ItemPassive_Unique_Ring_677_x1
        ISnoPower SpauldersOfZakara { get; } // 318858 - ItemPassive_Unique_Ring_663_x1
        ISnoPower SpearOfJairo { get; } // 475254 - P6_ItemPassive_Unique_Ring_050
        ISnoPower SpinesOfSeethingHatred { get; } // 359606 - ItemPassive_Unique_Ring_750_x1
        ISnoPower SpiritGuards { get; } // 430289 - P2_ItemPassive_Unique_Ring_034
        ISnoPower SquirtsNecklace { get; } // 483552 - P66_ItemPassive_Unique_Ring_931
        ISnoPower StaffOfChiroptera { get; } // 478487 - P61_ItemPassive_Unique_Ring_014
        ISnoPower StainOfSin { get; } // 486209 - P72_ItemPassive_Soulshard_025
        ISnoPower StalgardsDecimator { get; } // 318412 - ItemPassive_Unique_Ring_527_x1
        ISnoPower Standoff { get; } // 446592 - P4_ItemPassive_Unique_Ring_035
        ISnoPower StArchewsGage { get; } // 434007 - ItemPassive_Unique_Ring_664_p2
        ISnoPower Starfire { get; } // 451242 - P42_ItemPassive_Unique_Ring_007
        ISnoPower StarmetalKukri { get; } // 318724 - ItemPassive_Unique_Ring_552_x1
        ISnoPower SteuartsGreaves { get; } // 475243 - P6_ItemPassive_Unique_Ring_039
        ISnoPower StoneGauntlets { get; } // 483519 - P66_ItemPassive_Unique_Ring_928
        ISnoPower StoneOfJordan { get; } // 484282 - P69_ItemPassive_Unique_Ring_001
        ISnoPower StormCrow { get; } // 364338 - itemPassive_Unique_WizardHat_004_x1
        ISnoPower StringOfEars { get; } // 446541 - P4_ItemPassive_Unique_Ring_032
        ISnoPower StrongarmBracers { get; } // 318772 - ItemPassive_Unique_Ring_590_x1
        ISnoPower SublimeConviction { get; } // 318890 - ItemPassive_Unique_Ring_694_x1
        ISnoPower SuWongDiviner { get; } // 442478 - P3_ItemPassive_Unique_Ring_041
        ISnoPower SwampLandWaders { get; } // 451161 - P41_ItemPassive_Unique_Ring_003
        ISnoPower Swiftmount { get; } // 359537 - ItemPassive_Unique_Ring_700_x1
        ISnoPower SwordOfIllWill { get; } // 446641 - P4_ItemPassive_Unique_Ring_040
        ISnoPower TalismanOfAranoch { get; } // 318715 - ItemPassive_Unique_Ring_544_x1
        ISnoPower TaskerandTheo { get; } // 318731 - ItemPassive_Unique_Ring_554_x1
        ISnoPower TheBarber { get; } // 454932 - P43_ItemPassive_Unique_Ring_005
        ISnoPower TheBurningAxeOfSankis { get; } // 246113 - ItemPassive_Unique_Axe_1H_007
        ISnoPower TheButchersSickle { get; } // 248484 - ItemPassive_Unique_Axe_1H_006
        ISnoPower TheCloakOfTheGarwulf { get; } // 318300 - ItemPassive_Unique_Ring_501_x1
        ISnoPower TheCrudestBoots { get; } // 485724 - P71_ItemPassive_Unique_Ring_002
        ISnoPower TheDaggerOfDarts { get; } // 483400 - P65_ItemPassive_Unique_Ring_911_x1
        ISnoPower TheDemonsDemise { get; } // 488008 - P75_ItemPassive_Unique_Ring_002
        ISnoPower TheEssOfJohan { get; } // 318759 - ItemPassive_Unique_Ring_577_x1
        ISnoPower TheExecutioner { get; } // 483516 - P66_ItemPassive_Unique_Ring_925
        ISnoPower TheFinalWitness { get; } // 318884 - ItemPassive_Unique_Ring_688_x1
        ISnoPower TheFistOfAzTurrasq { get; } // 318433 - ItemPassive_Unique_Ring_540_x1
        ISnoPower TheFlavorOfTime { get; } // 483515 - P66_ItemPassive_Unique_Ring_924
        ISnoPower TheFlowOfEternity { get; } // 451162 - P41_ItemPassive_Unique_Ring_004
        ISnoPower TheFurnace { get; } // 318753 - ItemPassive_Unique_Ring_571_x1
        ISnoPower TheGavelOfJudgment { get; } // 478490 - P61_ItemPassive_Unique_Ring_017
        ISnoPower TheGidbinn { get; } // 364316 - ItemPassive_Unique_CeremonialDagger_002_x1
        ISnoPower TheGrandVizier { get; } // 478553 - P61_ItemPassive_Unique_Ring_028
        ISnoPower TheGrinReaper { get; } // 251572 - ItemPassive_Unique_VoodooMask_002
        ISnoPower TheJohnstone { get; } // 476583 - P6_ItemPassive_Unique_Ring_062
        ISnoPower TheLawsOfSeph { get; } // 318428 - ItemPassive_Unique_Ring_536_x1
        ISnoPower TheMagistrate { get; } // 484116 - P68_ItemPassive_Unique_Ring_604
        ISnoPower TheMindsEye { get; } // 318824 - ItemPassive_Unique_Ring_642_x1
        ISnoPower TheMortalDrama { get; } // 484601 - P610_ItemPassive_Unique_Ring_007
        ISnoPower TheNinthCirriSatchel { get; } // 484295 - P69_ItemPassive_Unique_Ring_623
        ISnoPower TheOculus { get; } // 374308 - ItemPassive_Unique_Orb_001_x1
        ISnoPower ThePaddle { get; } // 247777 - ItemPassive_Unique_CombatStaff_2H_007
        ISnoPower TheRavensWing { get; } // 375037 - ItemPassive_Unique_Bow_008_x1
        ISnoPower TheShameOfDelsere { get; } // 445427 - P4_ItemPassive_Unique_Ring_009
        ISnoPower TheShortMansFinger { get; } // 478488 - P61_ItemPassive_Unique_Ring_015
        ISnoPower TheSmolderingCore { get; } // 487677 - P74_ItemPassive_Unique_Ring_005
        ISnoPower TheSpiderQueensGrasp { get; } // 486133 - P72_ItemPassive_Unique_Ring_003
        ISnoPower TheStarOfAzkaranth { get; } // 318716 - ItemPassive_Unique_Ring_545_x1
        ISnoPower TheSwami { get; } // 440336 - P3_ItemPassive_Unique_Ring_022
        ISnoPower TheTallMansFinger { get; } // 318806 - ItemPassive_Unique_Ring_624_x1
        ISnoPower TheThreeHundredthSpear { get; } // 487304 - P73_ItemPassive_Unique_Ring_004
        ISnoPower TheTormentor { get; } // 247572 - itemPassive_Unique_Staff_007
        ISnoPower TheTwistedSword { get; } // 484709 - P610_ItemPassive_Unique_Ring_027
        ISnoPower TheUndisputedChampion { get; } // 484245 - P68_ItemPassive_Unique_Ring_016
        ISnoPower ThingOfTheDeep { get; } // 446359 - P4_ItemPassive_Unique_Ring_029
        ISnoPower ThunderfuryBlessedBladeOfTheWindseeker { get; } // 318763 - ItemPassive_Unique_Ring_581_x1
        ISnoPower ThundergodsVigor { get; } // 364341 - ItemPassive_Unique_BarbBelt_003_x1
        ISnoPower TiklandianVisage { get; } // 318774 - ItemPassive_Unique_Ring_592_x1
        ISnoPower TragOulCoils { get; } // 488009 - P75_ItemPassive_Unique_Ring_003
        ISnoPower TragOulsCorrodedFang { get; } // 475250 - P6_ItemPassive_Unique_Ring_046
        ISnoPower Triumvirate { get; } // 434849 - P2_ItemPassive_Unique_Ring_052
        ISnoPower TzoKrinsGaze { get; } // 318811 - ItemPassive_Unique_Ring_629_x1
        ISnoPower UhkapianSerpent { get; } // 318721 - ItemPassive_Unique_Ring_550_x1
        ISnoPower Unity { get; } // 318769 - ItemPassive_Unique_Ring_587_x1
        ISnoPower UnrelentingPhalanx { get; } // 402444 - ItemPassive_Unique_Ring_909_x1
        ISnoPower UnstableScepter { get; } // 478479 - P61_ItemPassive_Unique_Ring_007
        ISnoPower UrsuasTroddenEffigy { get; } // 484655 - P610_ItemPassive_Unique_Ring_012
        ISnoPower VadimsSurge { get; } // 359604 - ItemPassive_Unique_Ring_748_x1
        ISnoPower VallasBequest { get; } // 436472 - P3_ItemPassive_Unique_Ring_006
        ISnoPower ValtheksRebuke { get; } // 484597 - P610_ItemPassive_Unique_Ring_003
        ISnoPower VambracesOfSescheron { get; } // 447839 - P4_ItemPassive_Unique_Ring_062
        ISnoPower VelvetCamaral { get; } // 318740 - ItemPassive_Unique_Ring_558_x1
        ISnoPower VengefulWind { get; } // 483791 - P67_ItemPassive_Unique_Ring_903
        ISnoPower Vigilance { get; } // 367008 - ItemPassive_Unique_Polearm_001_x1
        ISnoPower VigilanteBelt { get; } // 488555 - P76_ItemPassive_Unique_Ring_001
        ISnoPower VileHive { get; } // 445765 - P4_ItemPassive_Unique_Ring_013
        ISnoPower VileWard { get; } // 397783 - ItemPassive_Unique_Ring_754_x1
        ISnoPower VisageOfGiyua { get; } // 318385 - ItemPassive_Unique_Ring_523_x1
        ISnoPower VisageOfGunes { get; } // 446655 - P4_ItemPassive_Unique_Ring_041
        ISnoPower VoosJuicer { get; } // 446969 - P4_ItemPassive_Unique_Ring_045
        ISnoPower VoToyiasSpiker { get; } // 318886 - ItemPassive_Unique_Ring_690_x1
        ISnoPower WandOfWoh { get; } // 478480 - P61_ItemPassive_Unique_Ring_008
        ISnoPower WarhelmOfKassar { get; } // 449049 - P4_ItemPassive_Unique_Ring_073
        ISnoPower WarstaffOfGeneralQuang { get; } // 318430 - ItemPassive_Unique_Ring_537_x1
        ISnoPower WarzechianArmguards { get; } // 318771 - ItemPassive_Unique_Ring_589_x1
        ISnoPower WilkensReach { get; } // 447843 - P4_ItemPassive_Unique_Ring_063
        ISnoPower WinterFlurry { get; } // 484598 - P610_ItemPassive_Unique_Ring_004
        ISnoPower WisdomOfKalan { get; } // 476686 - P6_ItemPassive_Unique_Ring_071
        ISnoPower Wizardspike { get; } // 484600 - P610_ItemPassive_Unique_Ring_006
        ISnoPower WojahnniAssaulter { get; } // 483506 - P65_ItemPassive_Unique_Ring_007
        ISnoPower WonKhimLau { get; } // 484106 - P67_ItemPassive_Unique_Ring_969
        ISnoPower Wormwood { get; } // 423238 - P2_ItemPassive_Unique_Ring_014
        ISnoPower WrapsOfClarity { get; } // 441517 - P3_ItemPassive_Unique_Ring_038
        ISnoPower Wyrdward { get; } // 434036 - ItemPassive_Unique_Ring_670_p2
        ISnoPower XephirianAmulet { get; } // 318718 - ItemPassive_Unique_Ring_547_x1
        ISnoPower YangsRecurve { get; } // 478485 - P61_ItemPassive_Unique_Ring_012
        ISnoPower ZoeysSecret { get; } // 446639 - P4_ItemPassive_Unique_Ring_038

        // Generic powers
		ISnoPower Generic_1000MonsterFightMeteor { get; } // 199789
		ISnoPower Generic_a1dunLeorBigFireGrate { get; } // 108017
		ISnoPower Generic_a1dunLeorFireGutterfire { get; } // 175159
		ISnoPower Generic_a1dunLeorHallwayBladeTrap { get; } // 441108
		ISnoPower Generic_a1dunleoricfireTrench { get; } // 89418
		ISnoPower Generic_a1dunleoricfireTrench01 { get; } // 90428
		ISnoPower Generic_a1dunleoricfireTrench02 { get; } // 112259
		ISnoPower Generic_a2dunAqdActWoodPlatformDamage { get; } // 396386
		ISnoPower Generic_a2dunCaveGoatmenDroppingLogTrapattack { get; } // 175069
		ISnoPower Generic_a2dunCaveLarva { get; } // 206565
		ISnoPower Generic_a2dunCaveLarvaAOE { get; } // 189864
		ISnoPower Generic_a2dunCaveSlimeGeyserA { get; } // 114308
		ISnoPower Generic_a2dunZoltTeslaTowerColdspawnAttack { get; } // 223739
		ISnoPower Generic_a2dunZoltTeslaTowerFire { get; } // 29983
		ISnoPower Generic_a2dunZoltTeslaTowerFirespawnAttack { get; } // 223738
		ISnoPower Generic_a2dunZoltTeslaTowerIceNova { get; } // 29984
		ISnoPower Generic_a2dunZoltTeslaTowerLightningpewpew { get; } // 174642
		ISnoPower Generic_a2dunZoltTeslaTowerLightningspawnAttack { get; } // 223731
		ISnoPower Generic_a2dunZoltTeslaTowerPoisonspawnAttack { get; } // 223740
		ISnoPower Generic_A2EvacuationBelialBomb { get; } // 153000
		ISnoPower Generic_a3battlefielddemonicforge { get; } // 174905
		ISnoPower Generic_A3BattlefieldDemonMineAOE { get; } // 122327
		ISnoPower Generic_a3dunbastionKeepGuardFireAtNothing { get; } // 180931
		ISnoPower Generic_a3duncraterDemonClawBombA { get; } // 162328
		ISnoPower Generic_a3dunCraterDemonClawBombAtrigger { get; } // 206575
		ISnoPower Generic_a3duncraterDemonGroundTrapGasChamber { get; } // 123043
		ISnoPower Generic_a3duncraterDemonGroundTrapGasChamberFireOnly { get; } // 212330
		ISnoPower Generic_a3dunKeepBarrelStackShortDamage { get; } // 55014
		ISnoPower Generic_a3dunKeepExplodingBarrelStunpower { get; } // 186638
		ISnoPower Generic_a3dunkeepfireTrench01 { get; } // 200051
		ISnoPower Generic_a3dunkeepfireTrench02 { get; } // 200038
		ISnoPower Generic_A3IntroCatapultAttack { get; } // 244155
		ISnoPower Generic_a4dunGardenCorruptionMine { get; } // 188960
		ISnoPower Generic_a4dunHeavenHellRiftFallingRocksA { get; } // 223721
		ISnoPower Generic_a4dunHeavenHellRiftFallingRocksB { get; } // 223722
		ISnoPower Generic_a4DunHellFissure { get; } // 223286
		ISnoPower Generic_a4dunSpireCorruptionGeyser { get; } // 219695
		ISnoPower Generic_a4dunspirefirewall { get; } // 223284
		ISnoPower Generic_a4dunspireSpikeTrap { get; } // 220634
		ISnoPower Generic_ActorDisabledBuff { get; } // 93716
		ISnoPower Generic_ActorGhostedBuff { get; } // 224639
		ISnoPower Generic_ActorInTownBuff { get; } // 220304
		ISnoPower Generic_ActorInvulBuff { get; } // 439438
		ISnoPower Generic_ActorLoadingBuff { get; } // 212032
		ISnoPower Generic_Adriaevent47blast { get; } // 199222
		ISnoPower Generic_Adriaevent47projectile { get; } // 199198
		ISnoPower Generic_AIBackpedal { get; } // 313697
		ISnoPower Generic_AIBackpedalOneShotThroughActors { get; } // 327537
		ISnoPower Generic_AICircle { get; } // 29986
		ISnoPower Generic_AICircleLong { get; } // 29987
		ISnoPower Generic_AICircleStrafe { get; } // 29989
		ISnoPower Generic_AICircleStrafeShort { get; } // 29988
		ISnoPower Generic_AIClose { get; } // 29990
		ISnoPower Generic_AICloseFar { get; } // 466012
		ISnoPower Generic_AICloseFarther { get; } // 477010
		ISnoPower Generic_AICloseLong { get; } // 29991
		ISnoPower Generic_AIEscortFollow { get; } // 29992
		ISnoPower Generic_AIEvadeBuff { get; } // 99543
		ISnoPower Generic_AIFollow { get; } // 29993
		ISnoPower Generic_AIFollowClose { get; } // 29995
		ISnoPower Generic_AIFollowMeleeLead { get; } // 104514
		ISnoPower Generic_AIFollowMeleeLeadPet { get; } // 231004
		ISnoPower Generic_AIFollowMeleeLeadPetFar { get; } // 472153
		ISnoPower Generic_AIFollowPath { get; } // 29994
		ISnoPower Generic_AIFollowWithWalk { get; } // 1728
		ISnoPower Generic_AIFollowWithWalkFar { get; } // 467524
		ISnoPower Generic_AIFollowWithWalkNatural { get; } // 477018
		ISnoPower Generic_AIIdle { get; } // 29996
		ISnoPower Generic_AIIdleLong { get; } // 29997
		ISnoPower Generic_AIIdleShort { get; } // 29998
		ISnoPower Generic_AIOrbit { get; } // 55433
		ISnoPower Generic_AIReturnToGuardObject { get; } // 193411
		ISnoPower Generic_AIReturnToPath { get; } // 30000
		ISnoPower Generic_AIRunAway { get; } // 30001
		ISnoPower Generic_AIRunAwayLong { get; } // 30002
		ISnoPower Generic_AIRunAwayShort { get; } // 30003
		ISnoPower Generic_AIRunAwayShortV2 { get; } // 410363
		ISnoPower Generic_AIRunInFront { get; } // 30004
		ISnoPower Generic_AIRunInFrontGuaranteed { get; } // 163339
		ISnoPower Generic_AIRunNearby { get; } // 30005
		ISnoPower Generic_AIRunNearbyGloam { get; } // 30006
		ISnoPower Generic_AIRunNearbyLong { get; } // 30007
		ISnoPower Generic_AIRunNearbyShort { get; } // 30008
		ISnoPower Generic_AIRunTo { get; } // 30009
		ISnoPower Generic_AIRunToGuaranteed { get; } // 163338
		ISnoPower Generic_AIRunToGuaranteedSpider { get; } // 376110
		ISnoPower Generic_AISprintInFrontGuaranteed { get; } // 163336
		ISnoPower Generic_AISprintTo { get; } // 82805
		ISnoPower Generic_AISprintToGuaranteed { get; } // 163335
		ISnoPower Generic_AIStrafe { get; } // 30010
		ISnoPower Generic_AITownWalkToGuaranteed { get; } // 217618
		ISnoPower Generic_AIWalkInFront { get; } // 30012
		ISnoPower Generic_AIWalkInFrontGuaranteed { get; } // 163334
		ISnoPower Generic_AIWalkTo { get; } // 30013
		ISnoPower Generic_AIWalkToGuaranteed { get; } // 163333
		ISnoPower Generic_AIWander { get; } // 1729
		ISnoPower Generic_AIWanderLong { get; } // 30015
		ISnoPower Generic_AIWanderMinion { get; } // 476791
		ISnoPower Generic_AIWanderRun { get; } // 30014
		ISnoPower Generic_AIWandersuperLong { get; } // 30016
		ISnoPower Generic_AIWarnOthers { get; } // 114421
		ISnoPower Generic_AncientSpearKnockback { get; } // 106281
		ISnoPower Generic_AngelCorruptPiercingDash { get; } // 440446
		ISnoPower Generic_AnniversaryBuffEXPMF { get; } // 311167
		ISnoPower Generic_AxeBadData { get; } // 30020
		ISnoPower Generic_AxeOperateGizmo { get; } // 30021
		ISnoPower Generic_AxeOperateNPC { get; } // 30022
		ISnoPower Generic_AzmodanAODDamage { get; } // 123199
		ISnoPower Generic_AzmodanFallingCorpses { get; } // 122700
		ISnoPower Generic_AzmodanGlobeOfAnnihilation { get; } // 122699
		ISnoPower Generic_AzmodanLaserAttack { get; } // 129243
		ISnoPower Generic_AzmodanMelee { get; } // 133744
		ISnoPower Generic_AzmodanonDeath { get; } // 176046
		ISnoPower Generic_AzmodanPhase3Channel { get; } // 123466
		ISnoPower Generic_AzmodanTaunt { get; } // 211934
		ISnoPower Generic_AzmodanTurning { get; } // 211856
		ISnoPower Generic_BannerDrop { get; } // 185040
		ISnoPower Generic_BannerDropPVP { get; } // 234255
		ISnoPower Generic_BanterCooldown { get; } // 134334
		ISnoPower Generic_BarbarianCallOfTheAncientsBasicMelee { get; } // 187092
		ISnoPower Generic_BarbarianCallOfTheAncientsCleave { get; } // 168823
		ISnoPower Generic_BarbarianCallOfTheAncientsFuriousCharge { get; } // 168824
		ISnoPower Generic_BarbarianCallOfTheAncientsLeap { get; } // 168825
		ISnoPower Generic_BarbarianCallOfTheAncientsSeismicSlam { get; } // 168827
		ISnoPower Generic_BarbarianCallOfTheAncientsWeaponThrow { get; } // 168828
		ISnoPower Generic_BarbarianCallOfTheAncientsWhirlwind { get; } // 168830
		ISnoPower Generic_BarbarianGroundStompEffect { get; } // 30080
		ISnoPower Generic_BarbarianLeapOLD { get; } // 30097
		ISnoPower Generic_BarbarianOverpowerCowKing { get; } // 368239
		ISnoPower Generic_BarbarianRevengeBuff { get; } // 109344
		ISnoPower Generic_BarbarianWhirlwindDustDevilsPassability { get; } // 442221
		ISnoPower Generic_BareHandedPassive { get; } // 30145
		ISnoPower Generic_BarrelExplodeInstant { get; } // 1736
		ISnoPower Generic_BeastCharge { get; } // 30147
		ISnoPower Generic_BeastWeaponMeleeInstant { get; } // 109289
		ISnoPower Generic_BelialArmProxy { get; } // 259123
		ISnoPower Generic_BelialGroundPound { get; } // 67753
		ISnoPower Generic_BelialLightningBreath { get; } // 95856
		ISnoPower Generic_BelialLightningStrikeEnrage { get; } // 241757
		ISnoPower Generic_BelialLightningStrikev2 { get; } // 96212
		ISnoPower Generic_BelialMelee { get; } // 96712
		ISnoPower Generic_BelialMeleeReach { get; } // 156429
		ISnoPower Generic_BelialPhase3Buff { get; } // 95811
		ISnoPower Generic_BelialRangedAttack { get; } // 63079
		ISnoPower Generic_BelialSprint { get; } // 98565
		ISnoPower Generic_BelialSprintAway { get; } // 105312
		ISnoPower Generic_BigRedCharge { get; } // 149875
		ISnoPower Generic_BigRedFireBreath { get; } // 150552
		ISnoPower Generic_BlockChance10 { get; } // 355392
		ISnoPower Generic_BodyGuardTeleport { get; } // 131193
		ISnoPower Generic_BoneTurretMortarCast { get; } // 433233
		ISnoPower Generic_BountyGroundsBurrowOut { get; } // 446530
		ISnoPower Generic_BrickhouseArmShields { get; } // 72675
		ISnoPower Generic_BrickhouseDestructionSetup { get; } // 180875
		ISnoPower Generic_BrickhouseEnrage { get; } // 72713
		ISnoPower Generic_BrickhouseSlam { get; } // 72812
		ISnoPower Generic_BugWingsBuff { get; } // 255336
		ISnoPower Generic_BurrowIn { get; } // 30156
		ISnoPower Generic_BurrowInHidden { get; } // 194582
		ISnoPower Generic_BurrowInSetup { get; } // 69949
		ISnoPower Generic_BurrowInSetup2HSwing { get; } // 327086
		ISnoPower Generic_BurrowInSetupHidden { get; } // 346610
		ISnoPower Generic_BurrowInSetupStaff { get; } // 327088
		ISnoPower Generic_BurrowOut { get; } // 30157
		ISnoPower Generic_BurrowOutNoFacing { get; } // 75226
		ISnoPower Generic_BurrowOutSetup { get; } // 194596
		ISnoPower Generic_BurrowStartBuff { get; } // 30158
		ISnoPower Generic_ButcherDamagingFire { get; } // 86627
		ISnoPower Generic_ButcherFloorPanelFire { get; } // 96925
		ISnoPower Generic_ButcherFrenzy { get; } // 85001
		ISnoPower Generic_ButcherFrenzyCustomLRBoss { get; } // 364220
		ISnoPower Generic_ButcherGrapplingHook { get; } // 83008
		ISnoPower Generic_ButcherOnDeath { get; } // 209203
		ISnoPower Generic_ButcherSlam { get; } // 85152
		ISnoPower Generic_ButcherSmash { get; } // 30160
		ISnoPower Generic_ButcherSpears { get; } // 198671
		ISnoPower Generic_ButcherTargetRanged { get; } // 109153
		ISnoPower Generic_CainIntroSwing { get; } // 102449
		ISnoPower Generic_CaldeumPoisonLaser { get; } // 156211
		ISnoPower Generic_CalldownGrenade { get; } // 91155
		ISnoPower Generic_CalloutCooldown { get; } // 134225
		ISnoPower Generic_CameraFocusBuff { get; } // 151595
		ISnoPower Generic_CameraFocusPetBuff { get; } // 151604
		ISnoPower Generic_CannotDieDuringBuff { get; } // 225599
		ISnoPower Generic_caOutBoneYardsCollapsingBonesDamage { get; } // 396376
		ISnoPower Generic_caOutOasisAttackPlantattack { get; } // 102874
		ISnoPower Generic_CatapultAttack { get; } // 108036
		ISnoPower Generic_ChampionClone { get; } // 30166
		ISnoPower Generic_ChampionTeleport { get; } // 30167
		ISnoPower Generic_CleanupSummonsOnDeath { get; } // 442438
		ISnoPower Generic_CollectorsEditionBuff { get; } // 208706
		ISnoPower Generic_CommunityBuffDarkAlchemy { get; } // 488071
		ISnoPower Generic_CommunityBuffLegacyOfNightmares { get; } // 483485
		ISnoPower Generic_CommunityBuffNestingPortalSpawn { get; } // 488544
		ISnoPower Generic_CommunityBuffPandemonium { get; } // 483967
		ISnoPower Generic_CommunityBuffShadowClones { get; } // 484633
		ISnoPower Generic_CommunityBuffTriunesWill { get; } // 483606
		ISnoPower Generic_CommunityBuffWeather { get; } // 484426
		ISnoPower Generic_CommunityEventBuffEXPMF { get; } // 370781
		ISnoPower Generic_CompanionBuff { get; } // 275399
		ISnoPower Generic_ConsolePowerGlobe { get; } // 300082
		ISnoPower Generic_ConsumablePotionBuffs { get; } // 409455
		ISnoPower Generic_Cooldown { get; } // 30176
		ISnoPower Generic_CopiedVisualEffectsBuff { get; } // 91052
		ISnoPower Generic_CoreEliteDropPod { get; } // 134816
		ISnoPower Generic_CoreEliteDropPodBegin { get; } // 136455
		ISnoPower Generic_CoreElitePodSetUp { get; } // 134815
		ISnoPower Generic_CorpulentExplode { get; } // 30178
		ISnoPower Generic_CorruptAngelSpectralStrike { get; } // 122978
		ISnoPower Generic_CosmeticSpectralHoundBuff { get; } // 428398
		ISnoPower Generic_CreepMobCreeperAttack { get; } // 72366
		ISnoPower Generic_CreepMobKnockback { get; } // 71646
		ISnoPower Generic_CreepMobKnockbackLR { get; } // 376935
		ISnoPower Generic_CreepMobRangedArmAttack { get; } // 71688
		ISnoPower Generic_CritDebuffCold { get; } // 30180
		ISnoPower Generic_CryptChildEat { get; } // 1738
		ISnoPower Generic_CryptChildLeapOut { get; } // 30185
		ISnoPower Generic_CryptChildLeapOutBuff { get; } // 30186
		ISnoPower Generic_DamageAttribute { get; } // 86152
		ISnoPower Generic_DeathBroBoneCage { get; } // 451544
		ISnoPower Generic_DeathBroSummonSkeletons { get; } // 451528
		ISnoPower Generic_DeathBroTeleport { get; } // 451543
		ISnoPower Generic_DebuffBleed { get; } // 228423
		ISnoPower Generic_DebuffBlind { get; } // 103216
		ISnoPower Generic_DebuffCharmed { get; } // 311910
		ISnoPower Generic_DebuffChilled { get; } // 30195
		ISnoPower Generic_DebuffFeared { get; } // 101002
		ISnoPower Generic_DebuffFireDamageProc { get; } // 312061
		ISnoPower Generic_DebuffForceGripped { get; } // 312799
		ISnoPower Generic_DebuffPoisonDamageProc { get; } // 312062
		ISnoPower Generic_DebuffRooted { get; } // 101003
		ISnoPower Generic_DebuffSlowed { get; } // 100971
		ISnoPower Generic_DebuffStunned { get; } // 101000
		ISnoPower Generic_DeleteSelfAnim { get; } // 346635
		ISnoPower Generic_demonFlyerdropBomb { get; } // 132940
		ISnoPower Generic_DemonFlyerFireBreath { get; } // 155188
		ISnoPower Generic_DemonFlyerProjectile { get; } // 130798
		ISnoPower Generic_demonFlyersnatch { get; } // 121326
		ISnoPower Generic_DemonHunterBallistaV3 { get; } // 484727
		ISnoPower Generic_DemonHunterCompanion { get; } // 133695
		ISnoPower Generic_DemonHunterEvasiveFireFlip { get; } // 134280
		ISnoPower Generic_DemonHunterSentryTurretAttack { get; } // 129661
		ISnoPower Generic_DemonTrooperLeapOut { get; } // 143198
		ISnoPower Generic_DervishWhirlwind { get; } // 30207
		ISnoPower Generic_DervishWhirlwindMortarPrototype { get; } // 256026
		ISnoPower Generic_DespairMeleeCleave { get; } // 152865
		ISnoPower Generic_DespairMeleeCleaveEnrage { get; } // 241778
		ISnoPower Generic_DespairSummonMinion { get; } // 150486
		ISnoPower Generic_DespairTeleport { get; } // 149911
		ISnoPower Generic_DespairTeleportAway { get; } // 209700
		ISnoPower Generic_DespairVolley { get; } // 152866
		ISnoPower Generic_DespairVolleyLRBoss { get; } // 366277
		ISnoPower Generic_DestructableObjectAOE { get; } // 30208
		ISnoPower Generic_DestructableObjectChandelierAOE { get; } // 30209
		ISnoPower Generic_DestructableObjectChandelierAOEHoist { get; } // 358809
		ISnoPower Generic_DestructionStreakBuffRunSpeed { get; } // 368174
		ISnoPower Generic_DHCompanionChargeAttack { get; } // 133887
		ISnoPower Generic_DHCompanionMeleeAttack { get; } // 227240
		ISnoPower Generic_DHrainofArrowsshadowBeastbombDrop { get; } // 150075
		ISnoPower Generic_DiabloCharge { get; } // 195816
		ISnoPower Generic_DiabloClawRip { get; } // 136189
		ISnoPower Generic_DiabloClawRipUber { get; } // 375905
		ISnoPower Generic_DiabloCorruptionShield { get; } // 161174
		ISnoPower Generic_DiabloCurseOfAnguish { get; } // 136828
		ISnoPower Generic_DiabloCurseOfDestruction { get; } // 136831
		ISnoPower Generic_DiabloCurseOfHate { get; } // 136830
		ISnoPower Generic_DiabloCurseOfPain { get; } // 136829
		ISnoPower Generic_DiabloExpandingFireRing { get; } // 185997
		ISnoPower Generic_DiabloExpandingFireRingUber { get; } // 375908
		ISnoPower Generic_DiabloFireMeteor { get; } // 214831
		ISnoPower Generic_DiabloGetHit { get; } // 214668
		ISnoPower Generic_DiabloHellSpikes { get; } // 136226
		ISnoPower Generic_DiabloLightningBreath { get; } // 136219
		ISnoPower Generic_DiabloLightningBreathLRTerrorDemon { get; } // 428985
		ISnoPower Generic_DiabloLightningBreathLRTerrorDemonClone { get; } // 439719
		ISnoPower Generic_DiabloLightningBreathTurretMB313 { get; } // 478410
		ISnoPower Generic_DiabloLightningBreathUber { get; } // 375904
		ISnoPower Generic_DiabloLightningBreathv2 { get; } // 167560
		ISnoPower Generic_DiabloPhase1Buff { get; } // 141865
		ISnoPower Generic_DiabloPhase2Buff { get; } // 136850
		ISnoPower Generic_DiabloPhase3Buff { get; } // 136852
		ISnoPower Generic_DiabloRingOfFire { get; } // 136223
		ISnoPower Generic_DiabloRingOfFireUber { get; } // 375907
		ISnoPower Generic_DiabloShadowClones { get; } // 136281
		ISnoPower Generic_DiabloShadowVanish { get; } // 136237
		ISnoPower Generic_DiabloShadowVanishCharge { get; } // 142582
		ISnoPower Generic_DiabloShadowVanishGrab { get; } // 136849
		ISnoPower Generic_DiabloSmashPunyDestructible { get; } // 169212
		ISnoPower Generic_DiabloStompAndStun { get; } // 199476
		ISnoPower Generic_DiabloStompAndStunMB313 { get; } // 478072
		ISnoPower Generic_DiabloTeleport { get; } // 219598
		ISnoPower Generic_DisableGetHitBuffInfinite { get; } // 360319
		ISnoPower Generic_DisablePowerBuffInfinite { get; } // 340708
		ISnoPower Generic_DOTDebuff { get; } // 95701
		ISnoPower Generic_DrinkHealthPotion { get; } // 30211
		ISnoPower Generic_DualWieldBuff { get; } // 193438
		ISnoPower Generic_DualWieldScripted { get; } // 335158
		ISnoPower Generic_DualWieldScriptedRemove { get; } // 335253
		ISnoPower Generic_DuelBuff { get; } // 270058
		ISnoPower Generic_DuelDefeatBuff { get; } // 275135
		ISnoPower Generic_EasterEggWorldBuff { get; } // 434761
		ISnoPower Generic_EatCorpse { get; } // 30214
		ISnoPower Generic_ElectricEelElectricBurst { get; } // 57932
		ISnoPower Generic_ElectricEelLeapOut { get; } // 59836
		ISnoPower Generic_EmoteAttack { get; } // 188254
		ISnoPower Generic_EmoteBye { get; } // 185085
		ISnoPower Generic_EmoteDance { get; } // 384214
		ISnoPower Generic_EmoteDie { get; } // 185087
		ISnoPower Generic_EmoteFollow { get; } // 185042
		ISnoPower Generic_EmoteGive { get; } // 185081
		ISnoPower Generic_EmoteGo { get; } // 185629
		ISnoPower Generic_EmoteHelp { get; } // 185093
		ISnoPower Generic_EmoteHold { get; } // 188256
		ISnoPower Generic_EmoteLaugh { get; } // 188258
		ISnoPower Generic_EmoteNo { get; } // 188252
		ISnoPower Generic_EmoteRetreat { get; } // 188255
		ISnoPower Generic_EmoteRun { get; } // 185598
		ISnoPower Generic_EmoteSorry { get; } // 185083
		ISnoPower Generic_EmoteStay { get; } // 188253
		ISnoPower Generic_EmoteTakeObjective { get; } // 188257
		ISnoPower Generic_EmoteThanks { get; } // 185082
		ISnoPower Generic_EmoteWait { get; } // 185600
		ISnoPower Generic_EmoteYes { get; } // 188251
		ISnoPower Generic_EnchantressAmplifyElemental { get; } // 485108
		ISnoPower Generic_EnchantressArcaneOrb { get; } // 485321
		ISnoPower Generic_EnchantressCharm { get; } // 102057
		ISnoPower Generic_EnchantressCheatDeath { get; } // 484963
		ISnoPower Generic_EnchantressCheatDeathPassive { get; } // 485530
		ISnoPower Generic_EnchantressCombinedShield { get; } // 485107
		ISnoPower Generic_EnchantressCooldownReduction { get; } // 485099
		ISnoPower Generic_EnchantressCripple { get; } // 84469
		ISnoPower Generic_EnchantressDisorient { get; } // 101990
		ISnoPower Generic_EnchantressFocusedMind { get; } // 101425
		ISnoPower Generic_EnchantressMassCharm { get; } // 201524
		ISnoPower Generic_EnchantressMeleeInstant { get; } // 230238
		ISnoPower Generic_EnchantressRunAway { get; } // 186200
		ISnoPower Generic_EnchantressScorchedEarth { get; } // 220872
		ISnoPower Generic_EnterRecallPortal { get; } // 201538
		ISnoPower Generic_EnterStoneOfRecall { get; } // 200036
		ISnoPower Generic_EnvironmentKillBuffResourceRegen { get; } // 391680
		ISnoPower Generic_EquippedLegendaryPower { get; } // 434427
		ISnoPower Generic_EscortingBuff { get; } // 86241
		ISnoPower Generic_ExitRecallPortal { get; } // 201570
		ISnoPower Generic_ExitStoneOfRecall { get; } // 200039
		ISnoPower Generic_FallenChampionLeaderShout { get; } // 30222
		ISnoPower Generic_FallenChampionPowerHit { get; } // 1740
		ISnoPower Generic_FallenGruntShout { get; } // 30223
		ISnoPower Generic_FallenLunaticAggroA { get; } // 158955
		ISnoPower Generic_FallenLunaticAggroB { get; } // 330501
		ISnoPower Generic_FallenLunaticAggroC { get; } // 330800
		ISnoPower Generic_FallenLunaticAggroD { get; } // 330802
		ISnoPower Generic_FallenLunaticSuicide { get; } // 66547
		ISnoPower Generic_FallenLunaticSuicideRingSummon { get; } // 433469
		ISnoPower Generic_FallenShamanProjectile { get; } // 30225
		ISnoPower Generic_FallenShamanProjectileLR { get; } // 364817
		ISnoPower Generic_FallingSwordCheckPathPassability { get; } // 329401
		ISnoPower Generic_FastMummyDiseaseCloud { get; } // 30227
		ISnoPower Generic_FrenzyAffix { get; } // 123843
		ISnoPower Generic_GenericArrowProjectile { get; } // 30242
		ISnoPower Generic_GenericSetCannotBeAddedToAITargetList { get; } // 129386
		ISnoPower Generic_GenericSetDoesFakeDamage { get; } // 129395
		ISnoPower Generic_GenericSetInvisible { get; } // 76107
		ISnoPower Generic_GenericSetInvulnerable { get; } // 62731
		ISnoPower Generic_GenericSetObserver { get; } // 129393
		ISnoPower Generic_GenericSetTakesNoDamage { get; } // 129394
		ISnoPower Generic_GenericSetUntargetable { get; } // 62666
		ISnoPower Generic_GenericTaunt { get; } // 60777
		ISnoPower Generic_GhostAUniqueHouse1000UndeadSlow { get; } // 94972
		ISnoPower Generic_GhostMeleeDrain { get; } // 30243
		ISnoPower Generic_GhostSoulSiphon { get; } // 30244
		ISnoPower Generic_GhostWalkThroughWalls { get; } // 99094
		ISnoPower Generic_Gizmoa3dunrmptOilVatAAttack { get; } // 129689
		ISnoPower Generic_GizmoOperatePortalWithAnimation { get; } // 30249
		ISnoPower Generic_gkillElitePack { get; } // 230745
		ISnoPower Generic_glevelUp { get; } // 85954
		ISnoPower Generic_glevelUpAA { get; } // 252038
		ISnoPower Generic_GluttonyBreathAttack { get; } // 93838
		ISnoPower Generic_GluttonyGasCloud { get; } // 93676
		ISnoPower Generic_GluttonyGasCloudLRBoss { get; } // 369667
		ISnoPower Generic_GluttonyLoogiespawn { get; } // 211292
		ISnoPower Generic_GluttonyOnDeath { get; } // 98587
		ISnoPower Generic_GoatmanColdShield { get; } // 123158
		ISnoPower Generic_GoatmanDrumsBeating { get; } // 97497
		ISnoPower Generic_GoatmanIceball { get; } // 99077
		ISnoPower Generic_GoatmanLightningShield { get; } // 30251
		ISnoPower Generic_GoatmanMoonclanRangedProjectile { get; } // 30252
		ISnoPower Generic_GoatmanShamanEmpower { get; } // 168554
		ISnoPower Generic_GoatmanShamanLightningbolt { get; } // 77342
		ISnoPower Generic_GoatMutantEnrage { get; } // 131588
		ISnoPower Generic_GoatMutantGroundSmash { get; } // 131699
		ISnoPower Generic_GoatMutantRangedProjectile { get; } // 159004
		ISnoPower Generic_GoatMutantShamanBlast { get; } // 157947
		ISnoPower Generic_GoblinAffixTeleporter { get; } // 413313
		ISnoPower Generic_gparagonBuff { get; } // 286747
		ISnoPower Generic_GraveDiggerKnockbackAttack { get; } // 30255
		ISnoPower Generic_graveDiggerwardenrangedAttack { get; } // 113817
		ISnoPower Generic_GraveRobberDodgeLeft { get; } // 30256
		ISnoPower Generic_GraveRobberDodgeRight { get; } // 30257
		ISnoPower Generic_graveRobberProjectile { get; } // 30258
		ISnoPower Generic_GreedStompAndStun { get; } // 408505
		ISnoPower Generic_HealingWellHeal { get; } // 30264
		ISnoPower Generic_Hearth { get; } // 30265
		ISnoPower Generic_HearthFinish { get; } // 30266
		ISnoPower Generic_HellPortalSummoningMachineActivate { get; } // 118226
		ISnoPower Generic_HelperArcherProjectile { get; } // 73289
		ISnoPower Generic_HirelingCalloutBattleCry { get; } // 87093
		ISnoPower Generic_HirelingCalloutBattleFinished { get; } // 117323
		ISnoPower Generic_HirelingDismiss { get; } // 196142
		ISnoPower Generic_HirelingDismissBuff { get; } // 196103
		ISnoPower Generic_HirelingDismissBuffRemove { get; } // 196251
		ISnoPower Generic_HirelingMageMagicMissile { get; } // 30273
		ISnoPower Generic_HoodedNightmareBoneArmor { get; } // 135701
		ISnoPower Generic_HoodedNightmareCurses { get; } // 136071
		ISnoPower Generic_HoodedNightmareGatewayToHell { get; } // 136072
		ISnoPower Generic_HoodedNightmareLightningOfUnlife { get; } // 135412
		ISnoPower Generic_IdentifyAllWithCast { get; } // 293981
		ISnoPower Generic_IdentifyWithCast { get; } // 226757
		ISnoPower Generic_IdentifyWithCastLegendary { get; } // 259848
		ISnoPower Generic_IGRBuffEXP { get; } // 238686
		ISnoPower Generic_ImmuneToFearDuringBuff { get; } // 30283
		ISnoPower Generic_ImmuneToRootDuringBuff { get; } // 30284
		ISnoPower Generic_ImmuneToSnareDuringBuff { get; } // 30285
		ISnoPower Generic_ImmuneToStunDuringBuff { get; } // 30286
		ISnoPower Generic_InteractCrouching { get; } // 30287
		ISnoPower Generic_InteractNormal { get; } // 30288
		ISnoPower Generic_InvisibileDuringBuff { get; } // 30289
		ISnoPower Generic_InvulnerableDuringBuff { get; } // 30290
		ISnoPower Generic_ItemPassiveSetBonusChantodo { get; } // 371005
		ISnoPower Generic_itemPassiveUniqueAmulet001 { get; } // 246590
		ISnoPower Generic_itemPassiveUniqueAmulet003 { get; } // 246750
		ISnoPower Generic_itemPassiveUniqueAmulet011 { get; } // 248136
		ISnoPower Generic_ItemPassiveUniqueAmulet017x1 { get; } // 322978
		ISnoPower Generic_ItemPassiveUniqueAmulet105x1 { get; } // 334880
		ISnoPower Generic_ItemPassiveUniqueAxe1H003 { get; } // 245854
		ISnoPower Generic_ItemPassiveUniqueAxe1H005 { get; } // 246101
		ISnoPower Generic_ItemPassiveUniqueAxe1H005x1 { get; } // 364318
		ISnoPower Generic_ItemPassiveUniqueAxe2H010 { get; } // 248462
		ISnoPower Generic_ItemPassiveUniqueAxe2H012x1 { get; } // 322974
		ISnoPower Generic_ItemPassiveUniqueBarbBelt003 { get; } // 246363
		ISnoPower Generic_ItemPassiveUniqueBelt016p2 { get; } // 433996
		ISnoPower Generic_ItemPassiveUniqueBelt016x1 { get; } // 322980
		ISnoPower Generic_ItemPassiveUniqueBoots007 { get; } // 246442
		ISnoPower Generic_ItemPassiveUniqueBoots007x1 { get; } // 342515
		ISnoPower Generic_ItemPassiveUniqueBoots020x1 { get; } // 322976
		ISnoPower Generic_ItemPassiveUniqueBow008 { get; } // 246605
		ISnoPower Generic_ItemPassiveUniqueBow015 { get; } // 248817
		ISnoPower Generic_ItemPassiveUniqueBow015x1 { get; } // 344372
		ISnoPower Generic_ItemPassiveUniqueBracer105x1 { get; } // 334881
		ISnoPower Generic_ItemPassiveUniqueCeremonialDagger002 { get; } // 245835
		ISnoPower Generic_ItemPassiveUniqueCeremonialDagger008 { get; } // 247896
		ISnoPower Generic_ItemPassiveUniqueDagger006 { get; } // 247769
		ISnoPower Generic_ItemPassiveUniqueDagger010 { get; } // 245837
		ISnoPower Generic_ItemPassiveUniqueDagger010x1 { get; } // 364312
		ISnoPower Generic_ItemPassiveUniqueDagger011x1 { get; } // 334882
		ISnoPower Generic_ItemPassiveUniqueDagger103x1 { get; } // 322979
		ISnoPower Generic_ItemPassiveUniqueFist010 { get; } // 248928
		ISnoPower Generic_ItemPassiveUniqueFist010x1 { get; } // 360490
		ISnoPower Generic_ItemPassiveUniqueHandXBow012 { get; } // 246678
		ISnoPower Generic_itemPassiveUniqueHelm003 { get; } // 246814
		ISnoPower Generic_itemPassiveUniqueHelm003x1 { get; } // 338061
		ISnoPower Generic_ItemPassiveUniqueHelm017x1 { get; } // 322977
		ISnoPower Generic_itemPassiveUniqueMace1H002 { get; } // 246918
		ISnoPower Generic_itemPassiveUniqueMace1H009 { get; } // 247484
		ISnoPower Generic_ItemPassiveUniqueMace2H003 { get; } // 249958
		ISnoPower Generic_ItemPassiveUniqueMace2H006 { get; } // 248501
		ISnoPower Generic_ItemPassiveUniqueMace2H009 { get; } // 247913
		ISnoPower Generic_ItemPassiveUniqueMace2H009x1 { get; } // 364319
		ISnoPower Generic_ItemPassiveUniqueMighty1H006 { get; } // 246836
		ISnoPower Generic_ItemPassiveUniqueMighty1H006p3 { get; } // 441762
		ISnoPower Generic_ItemPassiveUniqueMighty1H006x1 { get; } // 364322
		ISnoPower Generic_ItemPassiveUniqueMighty1H011 { get; } // 248481
		ISnoPower Generic_ItemPassiveUniqueMighty1H011x1 { get; } // 360488
		ISnoPower Generic_ItemPassiveUniqueMojo010 { get; } // 248489
		ISnoPower Generic_ItemPassiveUniqueMojo010x1 { get; } // 360491
		ISnoPower Generic_ItemPassiveUniqueMojo010x1tooltipDummy1 { get; } // 440744
		ISnoPower Generic_itemPassiveUniquePants007 { get; } // 247009
		ISnoPower Generic_itemPassiveUniquePants007x1 { get; } // 364342
		ISnoPower Generic_ItemPassiveUniquePolearm001 { get; } // 247641
		ISnoPower Generic_ItemPassiveUniquePotion01x1 { get; } // 341335
		ISnoPower Generic_ItemPassiveUniquePotion02x1 { get; } // 341340
		ISnoPower Generic_ItemPassiveUniquePotion03x1 { get; } // 341341
		ISnoPower Generic_ItemPassiveUniqueRing001 { get; } // 248880
		ISnoPower Generic_ItemPassiveUniqueRing004 { get; } // 247797
		ISnoPower Generic_ItemPassiveUniqueRing015 { get; } // 248763
		ISnoPower Generic_ItemPassiveUniqueRing015x1 { get; } // 360492
		ISnoPower Generic_ItemPassiveUniqueRing020 { get; } // 248537
		ISnoPower Generic_ItemPassiveUniqueRing024 { get; } // 257586
		ISnoPower Generic_ItemPassiveUniqueRing025x1 { get; } // 322975
		ISnoPower Generic_ItemPassiveUniqueRing500p2 { get; } // 434037
		ISnoPower Generic_ItemPassiveUniqueRing502x1 { get; } // 318346
		ISnoPower Generic_ItemPassiveUniqueRing503x1 { get; } // 318347
		ISnoPower Generic_ItemPassiveUniqueRing505x1 { get; } // 318349
		ISnoPower Generic_ItemPassiveUniqueRing506x1 { get; } // 318351
		ISnoPower Generic_ItemPassiveUniqueRing508x1 { get; } // 318359
		ISnoPower Generic_ItemPassiveUniqueRing510x1 { get; } // 318371
		ISnoPower Generic_ItemPassiveUniqueRing511x1 { get; } // 318372
		ISnoPower Generic_ItemPassiveUniqueRing512x1 { get; } // 318374
		ISnoPower Generic_ItemPassiveUniqueRing513AIPickupx1 { get; } // 326968
		ISnoPower Generic_ItemPassiveUniqueRing518x1 { get; } // 318380
		ISnoPower Generic_ItemPassiveUniqueRing521x1 { get; } // 318383
		ISnoPower Generic_ItemPassiveUniqueRing522x1 { get; } // 318384
		ISnoPower Generic_ItemPassiveUniqueRing524x1 { get; } // 318386
		ISnoPower Generic_ItemPassiveUniqueRing528x1 { get; } // 318417
		ISnoPower Generic_ItemPassiveUniqueRing529x1 { get; } // 318418
		ISnoPower Generic_ItemPassiveUniqueRing535x1 { get; } // 318427
		ISnoPower Generic_ItemPassiveUniqueRing542x1 { get; } // 318435
		ISnoPower Generic_ItemPassiveUniqueRing543x1 { get; } // 318436
		ISnoPower Generic_ItemPassiveUniqueRing546x1 { get; } // 318717
		ISnoPower Generic_ItemPassiveUniqueRing551x1 { get; } // 318722
		ISnoPower Generic_ItemPassiveUniqueRing553x1 { get; } // 318730
		ISnoPower Generic_ItemPassiveUniqueRing555x1 { get; } // 318732
		ISnoPower Generic_ItemPassiveUniqueRing556x1 { get; } // 318733
		ISnoPower Generic_ItemPassiveUniqueRing557x1 { get; } // 318734
		ISnoPower Generic_ItemPassiveUniqueRing560x1 { get; } // 318742
		ISnoPower Generic_ItemPassiveUniqueRing561x1 { get; } // 318743
		ISnoPower Generic_ItemPassiveUniqueRing563x1 { get; } // 318745
		ISnoPower Generic_ItemPassiveUniqueRing564x1 { get; } // 318746
		ISnoPower Generic_ItemPassiveUniqueRing565x1 { get; } // 318747
		ISnoPower Generic_ItemPassiveUniqueRing566x1 { get; } // 318748
		ISnoPower Generic_ItemPassiveUniqueRing567x1 { get; } // 318749
		ISnoPower Generic_ItemPassiveUniqueRing568x1 { get; } // 318750
		ISnoPower Generic_ItemPassiveUniqueRing570x1 { get; } // 318752
		ISnoPower Generic_ItemPassiveUniqueRing572x1 { get; } // 318754
		ISnoPower Generic_ItemPassiveUniqueRing573x1 { get; } // 318755
		ISnoPower Generic_ItemPassiveUniqueRing574x1 { get; } // 318756
		ISnoPower Generic_ItemPassiveUniqueRing576x1 { get; } // 318758
		ISnoPower Generic_ItemPassiveUniqueRing578x1 { get; } // 318760
		ISnoPower Generic_ItemPassiveUniqueRing579x1 { get; } // 318761
		ISnoPower Generic_ItemPassiveUniqueRing580x1 { get; } // 318762
		ISnoPower Generic_ItemPassiveUniqueRing582x1 { get; } // 318764
		ISnoPower Generic_ItemPassiveUniqueRing583x1 { get; } // 318765
		ISnoPower Generic_ItemPassiveUniqueRing584x1 { get; } // 318766
		ISnoPower Generic_ItemPassiveUniqueRing585x1 { get; } // 318767
		ISnoPower Generic_ItemPassiveUniqueRing586x1 { get; } // 318768
		ISnoPower Generic_ItemPassiveUniqueRing594x1 { get; } // 318776
		ISnoPower Generic_ItemPassiveUniqueRing596x1 { get; } // 318778
		ISnoPower Generic_ItemPassiveUniqueRing597p2 { get; } // 434006
		ISnoPower Generic_ItemPassiveUniqueRing598x1 { get; } // 318780
		ISnoPower Generic_ItemPassiveUniqueRing599x1 { get; } // 318781
		ISnoPower Generic_ItemPassiveUniqueRing601x1 { get; } // 318783
		ISnoPower Generic_ItemPassiveUniqueRing602x1 { get; } // 318784
		ISnoPower Generic_ItemPassiveUniqueRing603x1 { get; } // 318785
		ISnoPower Generic_ItemPassiveUniqueRing604x1 { get; } // 318786
		ISnoPower Generic_ItemPassiveUniqueRing605x1 { get; } // 318787
		ISnoPower Generic_ItemPassiveUniqueRing607x1 { get; } // 318789
		ISnoPower Generic_ItemPassiveUniqueRing609x1 { get; } // 318791
		ISnoPower Generic_ItemPassiveUniqueRing610x1 { get; } // 318792
		ISnoPower Generic_ItemPassiveUniqueRing611x1 { get; } // 318793
		ISnoPower Generic_ItemPassiveUniqueRing612x1 { get; } // 318794
		ISnoPower Generic_ItemPassiveUniqueRing615x1 { get; } // 318797
		ISnoPower Generic_ItemPassiveUniqueRing620x1 { get; } // 318802
		ISnoPower Generic_ItemPassiveUniqueRing621x1 { get; } // 318803
		ISnoPower Generic_ItemPassiveUniqueRing622x1 { get; } // 318804
		ISnoPower Generic_ItemPassiveUniqueRing623x1 { get; } // 318805
		ISnoPower Generic_ItemPassiveUniqueRing625x1 { get; } // 318807
		ISnoPower Generic_ItemPassiveUniqueRing627x1 { get; } // 318809
		ISnoPower Generic_ItemPassiveUniqueRing632x1 { get; } // 318814
		ISnoPower Generic_ItemPassiveUniqueRing633x1 { get; } // 318815
		ISnoPower Generic_ItemPassiveUniqueRing636x1 { get; } // 318818
		ISnoPower Generic_ItemPassiveUniqueRing637x1 { get; } // 318819
		ISnoPower Generic_ItemPassiveUniqueRing640x1 { get; } // 318822
		ISnoPower Generic_ItemPassiveUniqueRing641x1 { get; } // 318823
		ISnoPower Generic_ItemPassiveUniqueRing643x1 { get; } // 318825
		ISnoPower Generic_ItemPassiveUniqueRing644x1 { get; } // 318826
		ISnoPower Generic_ItemPassiveUniqueRing645x1 { get; } // 318827
		ISnoPower Generic_ItemPassiveUniqueRing646x1 { get; } // 318828
		ISnoPower Generic_ItemPassiveUniqueRing647x1 { get; } // 318829
		ISnoPower Generic_ItemPassiveUniqueRing648p2 { get; } // 434022
		ISnoPower Generic_ItemPassiveUniqueRing648x1 { get; } // 318830
		ISnoPower Generic_ItemPassiveUniqueRing649x1 { get; } // 318831
		ISnoPower Generic_ItemPassiveUniqueRing650x1 { get; } // 318832
		ISnoPower Generic_ItemPassiveUniqueRing651x1 { get; } // 318833
		ISnoPower Generic_ItemPassiveUniqueRing652x1 { get; } // 318834
		ISnoPower Generic_ItemPassiveUniqueRing654x1 { get; } // 318849
		ISnoPower Generic_ItemPassiveUniqueRing655x1 { get; } // 318850
		ISnoPower Generic_ItemPassiveUniqueRing657x1 { get; } // 318852
		ISnoPower Generic_ItemPassiveUniqueRing659x1 { get; } // 318854
		ISnoPower Generic_ItemPassiveUniqueRing661x1 { get; } // 318856
		ISnoPower Generic_ItemPassiveUniqueRing664x1 { get; } // 318860
		ISnoPower Generic_ItemPassiveUniqueRing666x1 { get; } // 318862
		ISnoPower Generic_ItemPassiveUniqueRing667x1 { get; } // 318863
		ISnoPower Generic_ItemPassiveUniqueRing670x1 { get; } // 318866
		ISnoPower Generic_ItemPassiveUniqueRing676x1 { get; } // 318872
		ISnoPower Generic_ItemPassiveUniqueRing678x1 { get; } // 318874
		ISnoPower Generic_ItemPassiveUniqueRing680x1 { get; } // 318876
		ISnoPower Generic_ItemPassiveUniqueRing681p2 { get; } // 434012
		ISnoPower Generic_ItemPassiveUniqueRing682x1 { get; } // 318878
		ISnoPower Generic_ItemPassiveUniqueRing683x1 { get; } // 318879
		ISnoPower Generic_ItemPassiveUniqueRing684x1 { get; } // 318880
		ISnoPower Generic_ItemPassiveUniqueRing687x1 { get; } // 318883
		ISnoPower Generic_ItemPassiveUniqueRing689x1 { get; } // 318885
		ISnoPower Generic_ItemPassiveUniqueRing693x1 { get; } // 318889
		ISnoPower Generic_ItemPassiveUniqueRing697x1 { get; } // 318893
		ISnoPower Generic_ItemPassiveUniqueRing702x1 { get; } // 359539
		ISnoPower Generic_ItemPassiveUniqueRing703x1 { get; } // 359540
		ISnoPower Generic_ItemPassiveUniqueRing705x1 { get; } // 359546
		ISnoPower Generic_ItemPassiveUniqueRing707x1 { get; } // 359552
		ISnoPower Generic_ItemPassiveUniqueRing708x1 { get; } // 359553
		ISnoPower Generic_ItemPassiveUniqueRing710x1 { get; } // 359555
		ISnoPower Generic_ItemPassiveUniqueRing711x1 { get; } // 359556
		ISnoPower Generic_ItemPassiveUniqueRing713x1 { get; } // 359558
		ISnoPower Generic_ItemPassiveUniqueRing714x1 { get; } // 359559
		ISnoPower Generic_ItemPassiveUniqueRing715x1 { get; } // 359560
		ISnoPower Generic_ItemPassiveUniqueRing716x1 { get; } // 359561
		ISnoPower Generic_ItemPassiveUniqueRing717x1 { get; } // 359562
		ISnoPower Generic_ItemPassiveUniqueRing718x1 { get; } // 359563
		ISnoPower Generic_ItemPassiveUniqueRing719x1 { get; } // 359564
		ISnoPower Generic_ItemPassiveUniqueRing720x1 { get; } // 359565
		ISnoPower Generic_ItemPassiveUniqueRing721x1 { get; } // 359566
		ISnoPower Generic_ItemPassiveUniqueRing722x1 { get; } // 359567
		ISnoPower Generic_ItemPassiveUniqueRing723x1 { get; } // 359568
		ISnoPower Generic_ItemPassiveUniqueRing724SpawnDecoyx1 { get; } // 425390
		ISnoPower Generic_ItemPassiveUniqueRing724x1 { get; } // 359569
		ISnoPower Generic_ItemPassiveUniqueRing725x1 { get; } // 359570
		ISnoPower Generic_ItemPassiveUniqueRing726x1 { get; } // 359573
		ISnoPower Generic_ItemPassiveUniqueRing727x1 { get; } // 359574
		ISnoPower Generic_ItemPassiveUniqueRing728x1 { get; } // 359576
		ISnoPower Generic_ItemPassiveUniqueRing729x1 { get; } // 359577
		ISnoPower Generic_ItemPassiveUniqueRing730x1 { get; } // 359578
		ISnoPower Generic_ItemPassiveUniqueRing731x1 { get; } // 359579
		ISnoPower Generic_ItemPassiveUniqueRing732x1 { get; } // 359580
		ISnoPower Generic_ItemPassiveUniqueRing733x1 { get; } // 359581
		ISnoPower Generic_ItemPassiveUniqueRing734x1 { get; } // 359582
		ISnoPower Generic_ItemPassiveUniqueRing735x1 { get; } // 359583
		ISnoPower Generic_ItemPassiveUniqueRing736x1 { get; } // 359584
		ISnoPower Generic_ItemPassiveUniqueRing737x1 { get; } // 359585
		ISnoPower Generic_ItemPassiveUniqueRing738x1 { get; } // 359586
		ISnoPower Generic_ItemPassiveUniqueRing740x1 { get; } // 359589
		ISnoPower Generic_ItemPassiveUniqueRing742x1 { get; } // 359593
		ISnoPower Generic_ItemPassiveUniqueRing743x1 { get; } // 359594
		ISnoPower Generic_ItemPassiveUniqueRing746x1 { get; } // 359601
		ISnoPower Generic_ItemPassiveUniqueRing749x1 { get; } // 359605
		ISnoPower Generic_ItemPassiveUniqueRing751x1 { get; } // 397780
		ISnoPower Generic_ItemPassiveUniqueRing752x1 { get; } // 397781
		ISnoPower Generic_ItemPassiveUniqueRing753x1 { get; } // 397782
		ISnoPower Generic_ItemPassiveUniqueRing755x1 { get; } // 397784
		ISnoPower Generic_ItemPassiveUniqueRing756x1 { get; } // 397785
		ISnoPower Generic_ItemPassiveUniqueRing757x1 { get; } // 397786
		ISnoPower Generic_ItemPassiveUniqueRing758x1 { get; } // 397787
		ISnoPower Generic_ItemPassiveUniqueRing760x1 { get; } // 397789
		ISnoPower Generic_ItemPassiveUniqueRing761x1 { get; } // 397792
		ISnoPower Generic_ItemPassiveUniqueRing762x1 { get; } // 397802
		ISnoPower Generic_ItemPassiveUniqueRing763x1 { get; } // 397805
		ISnoPower Generic_ItemPassiveUniqueRing764x1 { get; } // 397806
		ISnoPower Generic_ItemPassiveUniqueRing765x1 { get; } // 397807
		ISnoPower Generic_ItemPassiveUniqueRing766x1 { get; } // 397808
		ISnoPower Generic_ItemPassiveUniqueRing767x1 { get; } // 397809
		ISnoPower Generic_ItemPassiveUniqueRing768x1 { get; } // 397811
		ISnoPower Generic_ItemPassiveUniqueRing769x1 { get; } // 397812
		ISnoPower Generic_ItemPassiveUniqueRing770x1 { get; } // 397813
		ISnoPower Generic_ItemPassiveUniqueRing771x1 { get; } // 397814
		ISnoPower Generic_ItemPassiveUniqueRing772x1 { get; } // 397815
		ISnoPower Generic_ItemPassiveUniqueRing773x1 { get; } // 397816
		ISnoPower Generic_ItemPassiveUniqueRing774x1 { get; } // 397817
		ISnoPower Generic_ItemPassiveUniqueRing775x1 { get; } // 397818
		ISnoPower Generic_ItemPassiveUniqueRing776x1 { get; } // 397819
		ISnoPower Generic_ItemPassiveUniqueRing777x1 { get; } // 397820
		ISnoPower Generic_ItemPassiveUniqueRing778x1 { get; } // 397822
		ISnoPower Generic_ItemPassiveUniqueRing779x1 { get; } // 397831
		ISnoPower Generic_ItemPassiveUniqueRing780x1 { get; } // 397832
		ISnoPower Generic_ItemPassiveUniqueRing781x1 { get; } // 397833
		ISnoPower Generic_ItemPassiveUniqueRing782x1 { get; } // 397834
		ISnoPower Generic_ItemPassiveUniqueRing783x1 { get; } // 397835
		ISnoPower Generic_ItemPassiveUniqueRing784x1 { get; } // 397836
		ISnoPower Generic_ItemPassiveUniqueRing785x1 { get; } // 397838
		ISnoPower Generic_ItemPassiveUniqueRing786x1 { get; } // 397839
		ISnoPower Generic_ItemPassiveUniqueRing787x1 { get; } // 397841
		ISnoPower Generic_ItemPassiveUniqueRing788x1 { get; } // 397842
		ISnoPower Generic_ItemPassiveUniqueRing789x1 { get; } // 397843
		ISnoPower Generic_ItemPassiveUniqueRing790x1 { get; } // 397844
		ISnoPower Generic_ItemPassiveUniqueRing791x1 { get; } // 397845
		ISnoPower Generic_ItemPassiveUniqueRing792x1 { get; } // 397846
		ISnoPower Generic_ItemPassiveUniqueRing793x1 { get; } // 397847
		ISnoPower Generic_ItemPassiveUniqueRing794x1 { get; } // 397848
		ISnoPower Generic_ItemPassiveUniqueRing795x1 { get; } // 397849
		ISnoPower Generic_ItemPassiveUniqueRing796x1 { get; } // 397850
		ISnoPower Generic_ItemPassiveUniqueRing797x1 { get; } // 397851
		ISnoPower Generic_ItemPassiveUniqueRing798x1 { get; } // 397852
		ISnoPower Generic_ItemPassiveUniqueRing799x1 { get; } // 397853
		ISnoPower Generic_ItemPassiveUniqueRing800x1 { get; } // 397854
		ISnoPower Generic_ItemPassiveUniqueRing801x1 { get; } // 401366
		ISnoPower Generic_ItemPassiveUniqueRing802x1 { get; } // 401367
		ISnoPower Generic_ItemPassiveUniqueRing803x1 { get; } // 401368
		ISnoPower Generic_ItemPassiveUniqueRing804x1 { get; } // 401369
		ISnoPower Generic_ItemPassiveUniqueRing805x1 { get; } // 401370
		ISnoPower Generic_ItemPassiveUniqueRing806x1 { get; } // 401371
		ISnoPower Generic_ItemPassiveUniqueRing807x1 { get; } // 401378
		ISnoPower Generic_ItemPassiveUniqueRing808x1 { get; } // 401379
		ISnoPower Generic_ItemPassiveUniqueRing809x1 { get; } // 401380
		ISnoPower Generic_ItemPassiveUniqueRing810x1 { get; } // 401381
		ISnoPower Generic_ItemPassiveUniqueRing811x1 { get; } // 401382
		ISnoPower Generic_ItemPassiveUniqueRing812x1 { get; } // 401383
		ISnoPower Generic_ItemPassiveUniqueRing813x1 { get; } // 401384
		ISnoPower Generic_ItemPassiveUniqueRing814x1 { get; } // 401385
		ISnoPower Generic_ItemPassiveUniqueRing815x1 { get; } // 401386
		ISnoPower Generic_ItemPassiveUniqueRing816x1 { get; } // 401387
		ISnoPower Generic_ItemPassiveUniqueRing817x1 { get; } // 401388
		ISnoPower Generic_ItemPassiveUniqueRing818x1 { get; } // 401389
		ISnoPower Generic_ItemPassiveUniqueRing819x1 { get; } // 401390
		ISnoPower Generic_ItemPassiveUniqueRing820x1 { get; } // 401391
		ISnoPower Generic_ItemPassiveUniqueRing821x1 { get; } // 401392
		ISnoPower Generic_ItemPassiveUniqueRing822x1 { get; } // 401393
		ISnoPower Generic_ItemPassiveUniqueRing823x1 { get; } // 401394
		ISnoPower Generic_ItemPassiveUniqueRing824x1 { get; } // 401395
		ISnoPower Generic_ItemPassiveUniqueRing825x1 { get; } // 401414
		ISnoPower Generic_ItemPassiveUniqueRing826x1 { get; } // 401415
		ISnoPower Generic_ItemPassiveUniqueRing827x1 { get; } // 401416
		ISnoPower Generic_ItemPassiveUniqueRing828x1 { get; } // 401417
		ISnoPower Generic_ItemPassiveUniqueRing829x1 { get; } // 401418
		ISnoPower Generic_ItemPassiveUniqueRing830x1 { get; } // 401419
		ISnoPower Generic_ItemPassiveUniqueRing831x1 { get; } // 401420
		ISnoPower Generic_ItemPassiveUniqueRing832x1 { get; } // 401421
		ISnoPower Generic_ItemPassiveUniqueRing833x1 { get; } // 401422
		ISnoPower Generic_ItemPassiveUniqueRing834x1 { get; } // 401423
		ISnoPower Generic_ItemPassiveUniqueRing835x1 { get; } // 401424
		ISnoPower Generic_ItemPassiveUniqueRing836x1 { get; } // 401425
		ISnoPower Generic_ItemPassiveUniqueRing837x1 { get; } // 401426
		ISnoPower Generic_ItemPassiveUniqueRing838x1 { get; } // 401427
		ISnoPower Generic_ItemPassiveUniqueRing839x1 { get; } // 401428
		ISnoPower Generic_ItemPassiveUniqueRing840x1 { get; } // 401429
		ISnoPower Generic_ItemPassiveUniqueRing841x1 { get; } // 401430
		ISnoPower Generic_ItemPassiveUniqueRing842x1 { get; } // 401458
		ISnoPower Generic_ItemPassiveUniqueRing843x1 { get; } // 401459
		ISnoPower Generic_ItemPassiveUniqueRing844x1 { get; } // 401460
		ISnoPower Generic_ItemPassiveUniqueRing845x1 { get; } // 401461
		ISnoPower Generic_ItemPassiveUniqueRing846x1 { get; } // 401462
		ISnoPower Generic_ItemPassiveUniqueRing847x1 { get; } // 401463
		ISnoPower Generic_ItemPassiveUniqueRing848x1 { get; } // 401464
		ISnoPower Generic_ItemPassiveUniqueRing849x1 { get; } // 401465
		ISnoPower Generic_ItemPassiveUniqueRing850x1 { get; } // 401466
		ISnoPower Generic_ItemPassiveUniqueRing851x1 { get; } // 401467
		ISnoPower Generic_ItemPassiveUniqueRing852x1 { get; } // 401468
		ISnoPower Generic_ItemPassiveUniqueRing853x1 { get; } // 401469
		ISnoPower Generic_ItemPassiveUniqueRing854x1 { get; } // 401470
		ISnoPower Generic_ItemPassiveUniqueRing855x1 { get; } // 401471
		ISnoPower Generic_ItemPassiveUniqueRing856x1 { get; } // 401472
		ISnoPower Generic_ItemPassiveUniqueRing857x1 { get; } // 401473
		ISnoPower Generic_ItemPassiveUniqueRing858x1 { get; } // 401474
		ISnoPower Generic_ItemPassiveUniqueRing859x1 { get; } // 401475
		ISnoPower Generic_ItemPassiveUniqueRing860x1 { get; } // 401476
		ISnoPower Generic_ItemPassiveUniqueRing861x1 { get; } // 401495
		ISnoPower Generic_ItemPassiveUniqueRing862x1 { get; } // 401496
		ISnoPower Generic_ItemPassiveUniqueRing863x1 { get; } // 401497
		ISnoPower Generic_ItemPassiveUniqueRing864x1 { get; } // 401498
		ISnoPower Generic_ItemPassiveUniqueRing865x1 { get; } // 401499
		ISnoPower Generic_ItemPassiveUniqueRing866x1 { get; } // 401500
		ISnoPower Generic_ItemPassiveUniqueRing867x1 { get; } // 401501
		ISnoPower Generic_ItemPassiveUniqueRing868x1 { get; } // 401502
		ISnoPower Generic_ItemPassiveUniqueRing869x1 { get; } // 401503
		ISnoPower Generic_ItemPassiveUniqueRing870x1 { get; } // 401504
		ISnoPower Generic_ItemPassiveUniqueRing871x1 { get; } // 401505
		ISnoPower Generic_ItemPassiveUniqueRing872x1 { get; } // 401506
		ISnoPower Generic_ItemPassiveUniqueRing873x1 { get; } // 401507
		ISnoPower Generic_ItemPassiveUniqueRing874x1 { get; } // 401508
		ISnoPower Generic_ItemPassiveUniqueRing875x1 { get; } // 401509
		ISnoPower Generic_ItemPassiveUniqueRing876x1 { get; } // 401510
		ISnoPower Generic_ItemPassiveUniqueRing877x1 { get; } // 401511
		ISnoPower Generic_ItemPassiveUniqueRing878x1 { get; } // 409335
		ISnoPower Generic_ItemPassiveUniqueRing879x1 { get; } // 439528
		ISnoPower Generic_ItemPassiveUniqueRing880x1 { get; } // 442744
		ISnoPower Generic_ItemPassiveUniqueRing899x1 { get; } // 409431
		ISnoPower Generic_ItemPassiveUniqueRing900x1 { get; } // 409428
		ISnoPower Generic_ItemPassiveUniqueRing901x1 { get; } // 402407
		ISnoPower Generic_ItemPassiveUniqueRing902x1 { get; } // 402408
		ISnoPower Generic_ItemPassiveUniqueRing903x1 { get; } // 402411
		ISnoPower Generic_ItemPassiveUniqueRing904x1 { get; } // 402406
		ISnoPower Generic_ItemPassiveUniqueRing905x1 { get; } // 402413
		ISnoPower Generic_ItemPassiveUniqueRing906x1 { get; } // 402414
		ISnoPower Generic_ItemPassiveUniqueRing910x1 { get; } // 402446
		ISnoPower Generic_ItemPassiveUniqueRing911x1 { get; } // 402447
		ISnoPower Generic_ItemPassiveUniqueRing912x1 { get; } // 402448
		ISnoPower Generic_ItemPassiveUniqueRing913x1 { get; } // 402449
		ISnoPower Generic_ItemPassiveUniqueRing914x1 { get; } // 402450
		ISnoPower Generic_ItemPassiveUniqueRing924x1 { get; } // 402463
		ISnoPower Generic_ItemPassiveUniqueRing925x1 { get; } // 402464
		ISnoPower Generic_ItemPassiveUniqueRing926x1 { get; } // 402465
		ISnoPower Generic_ItemPassiveUniqueRing927x1 { get; } // 402466
		ISnoPower Generic_ItemPassiveUniqueRing928x1 { get; } // 402467
		ISnoPower Generic_ItemPassiveUniqueRing929x1 { get; } // 402469
		ISnoPower Generic_ItemPassiveUniqueRing930x1 { get; } // 402470
		ISnoPower Generic_ItemPassiveUniqueRing931x1 { get; } // 402471
		ISnoPower Generic_ItemPassiveUniqueRing932x1 { get; } // 402472
		ISnoPower Generic_ItemPassiveUniqueRing933x1 { get; } // 402473
		ISnoPower Generic_ItemPassiveUniqueRing934x1 { get; } // 402474
		ISnoPower Generic_ItemPassiveUniqueRing935x1 { get; } // 402475
		ISnoPower Generic_ItemPassiveUniqueRing936x1 { get; } // 402476
		ISnoPower Generic_ItemPassiveUniqueRing937x1 { get; } // 402477
		ISnoPower Generic_ItemPassiveUniqueRing938x1 { get; } // 402478
		ISnoPower Generic_ItemPassiveUniqueRing939x1 { get; } // 402479
		ISnoPower Generic_ItemPassiveUniqueRing940x1 { get; } // 402480
		ISnoPower Generic_ItemPassiveUniqueRing941x1 { get; } // 440913
		ISnoPower Generic_ItemPassiveUniqueRing999 { get; } // 484606
		ISnoPower Generic_ItemPassiveUniqueRingHellfirex1 { get; } // 367462
		ISnoPower Generic_itemPassiveUniqueShield008 { get; } // 247053
		ISnoPower Generic_itemPassiveUniqueShield011 { get; } // 247585
		ISnoPower Generic_ItemPassiveUniqueShoulder002 { get; } // 247619
		ISnoPower Generic_ItemPassiveUniqueShoulder002x1 { get; } // 364339
		ISnoPower Generic_ItemPassiveUniqueShoulder009 { get; } // 247544
		ISnoPower Generic_ItemPassiveUniqueShoulder103x1 { get; } // 334883
		ISnoPower Generic_ItemPassiveUniqueSword1H004 { get; } // 247662
		ISnoPower Generic_ItemPassiveUniqueSword1H012 { get; } // 249592
		ISnoPower Generic_ItemPassiveUniqueSword1H012x1 { get; } // 374362
		ISnoPower Generic_ItemPassiveUniqueSword2H004 { get; } // 247537
		ISnoPower Generic_ItemPassiveUniqueSword2H010 { get; } // 249138
		ISnoPower Generic_itemPassiveUniqueWizardHat004 { get; } // 247090
		ISnoPower Generic_itemPassiveUniqueWizardHat004p2 { get; } // 434035
		ISnoPower Generic_ItemPassiveUniqueXBow001 { get; } // 247429
		ISnoPower Generic_ItemPassiveUniqueXBow011 { get; } // 248480
		ISnoPower Generic_ItemPassiveUniqueXBow012 { get; } // 247430
		ISnoPower Generic_ItemPassivex1Amuletnormunique25Barbarian { get; } // 374500
		ISnoPower Generic_ItemPassivex1Amuletnormunique25Crusader { get; } // 374502
		ISnoPower Generic_ItemPassivex1Amuletnormunique25DemonHunter { get; } // 374503
		ISnoPower Generic_ItemPassivex1Amuletnormunique25Monk { get; } // 374504
		ISnoPower Generic_ItemPassivex1Amuletnormunique25Necromancer { get; } // 475677
		ISnoPower Generic_ItemPassivex1Amuletnormunique25WitchDoctor { get; } // 374506
		ISnoPower Generic_ItemPassivex1Amuletnormunique25Wizard { get; } // 374505
		ISnoPower Generic_IzualCharge { get; } // 241651
		ISnoPower Generic_IzualFrostNova { get; } // 162329
		ISnoPower Generic_IzualFrozenCast { get; } // 241653
		ISnoPower Generic_KillActor { get; } // 445899
		ISnoPower Generic_Knockback { get; } // 70432
		ISnoPower Generic_KnockbackNoLandingAnim { get; } // 356848
		ISnoPower Generic_KnockbackOverObstacles { get; } // 85936
		ISnoPower Generic_KnockbackThroughOwnedByTeam { get; } // 329195
		ISnoPower Generic_Knockdown { get; } // 30296
		ISnoPower Generic_LacuniBurrowIn { get; } // 30297
		ISnoPower Generic_LacuniBurrowOut { get; } // 30298
		ISnoPower Generic_LacuniCombo { get; } // 1744
		ISnoPower Generic_LacuniLeap { get; } // 30300
		ISnoPower Generic_LacuniLob { get; } // 30301
		ISnoPower Generic_LacuniMaleDoubleSwing { get; } // 30299
		ISnoPower Generic_Laugh { get; } // 30307
		ISnoPower Generic_LaughSkeletonKing { get; } // 84699
		ISnoPower Generic_LeahHulkOut { get; } // 190230
		ISnoPower Generic_LeahVortex { get; } // 93831
		ISnoPower Generic_LeahVortexAgain { get; } // 208501
		ISnoPower Generic_LewisItemPassiveTest { get; } // 437919
		ISnoPower Generic_LostSoulsPrototypeV2 { get; } // 456719
		ISnoPower Generic_LRBossCollapseCeiling { get; } // 366477
		ISnoPower Generic_LRBossFast { get; } // 366481
		ISnoPower Generic_LRBossIzualCharge { get; } // 366830
		ISnoPower Generic_LRBossPathBlockedTeleport { get; } // 366204
		ISnoPower Generic_LRBossSprint { get; } // 366527
		ISnoPower Generic_LSp4SeaMonsterSpawnCrabs { get; } // 470419
		ISnoPower Generic_MaghdaMark { get; } // 131741
		ISnoPower Generic_MaghdaMothDust { get; } // 131745
		ISnoPower Generic_MaghdaPortalCreateCinematic { get; } // 184598
		ISnoPower Generic_MaghdaProjectile { get; } // 30568
		ISnoPower Generic_MaghdaPunish { get; } // 131746
		ISnoPower Generic_MaghdaPunishCinematic { get; } // 178279
		ISnoPower Generic_MaghdaSummonBeserker { get; } // 131744
		ISnoPower Generic_MaghdaTeleport { get; } // 131749
		ISnoPower Generic_MagicPaintingSummonSkeleton { get; } // 30313
		ISnoPower Generic_MalletDemonPowerHit { get; } // 123381
		ISnoPower Generic_ManualWalk { get; } // 229128
		ISnoPower Generic_MastaBlastaCombinedDismountRider { get; } // 145022
		ISnoPower Generic_MastaBlastaCombinedLobbedShot { get; } // 143940
		ISnoPower Generic_MastaBlastaRiderAlphaStrike { get; } // 140857
		ISnoPower Generic_MastaBlastaRiderCombine { get; } // 143991
		ISnoPower Generic_MastaBlastaRiderLeap { get; } // 140856
		ISnoPower Generic_MastaBlastaRiderLobbedShot { get; } // 139356
		ISnoPower Generic_MastaBlastaRiderLobbedShotLR { get; } // 445562
		ISnoPower Generic_MastaBlastaSteedCombine { get; } // 144289
		ISnoPower Generic_MastaBlastaSteedDrainAttack { get; } // 141333
		ISnoPower Generic_MastaBlastaSteedStomp { get; } // 140859
		ISnoPower Generic_MistressOfPainAscend { get; } // 212136
		ISnoPower Generic_MistressOfPainDescend { get; } // 212237
		ISnoPower Generic_MistressOfPainPainBolts { get; } // 136790
		ISnoPower Generic_MistressOfPainPainBoltsLR { get; } // 369693
		ISnoPower Generic_MistressOfPainSpiderlingExplode { get; } // 137143
		ISnoPower Generic_MistressOfPainSummonSpiders { get; } // 136958
		ISnoPower Generic_MistressOfPainSummonSpidersAirborne { get; } // 212239
		ISnoPower Generic_MistressOfPainTeleportToThrone { get; } // 137483
		ISnoPower Generic_MistressOfPainWebPatch { get; } // 136722
		ISnoPower Generic_MonkLashingTailKickHandOfYtarPassability { get; } // 366119
		ISnoPower Generic_MonkLethalDecoyTaunt { get; } // 110575
		ISnoPower Generic_MonkMysticAllyPetRuneAKick { get; } // 169155
		ISnoPower Generic_MonkMysticAllyPetRuneBWaveAttackFast { get; } // 363493
		ISnoPower Generic_MonkMysticAllyPetRuneCGroundPunch { get; } // 169715
		ISnoPower Generic_MonkMysticAllyPetRuneDAOEAttack { get; } // 169728
		ISnoPower Generic_MonkMysticAllyPetWeaponMeleeInstant { get; } // 169081
		ISnoPower Generic_MonkResistAura { get; } // 69489
		ISnoPower Generic_MonkResistAuraRuneCArcane { get; } // 144312
		ISnoPower Generic_MonkResistAuraRuneCCold { get; } // 144197
		ISnoPower Generic_MonkResistAuraRuneCFire { get; } // 143382
		ISnoPower Generic_MonkResistAuraRuneCHoly { get; } // 144322
		ISnoPower Generic_MonkResistAuraRuneCLightning { get; } // 144188
		ISnoPower Generic_MonkResistAuraRuneCPoison { get; } // 144202
		ISnoPower Generic_MonsterAffixArcaneEnchanted { get; } // 214594
		ISnoPower Generic_MonsterAffixArcaneEnchantedCast { get; } // 214791
		ISnoPower Generic_MonsterAffixArcaneEnchantedCastNoTarget { get; } // 450358
		ISnoPower Generic_MonsterAffixArcaneEnchantedChampion { get; } // 221130
		ISnoPower Generic_MonsterAffixArcaneEnchantedMinion { get; } // 221219
		ISnoPower Generic_MonsterAffixArcaneEnchantedNewPetBasic { get; } // 219671
		ISnoPower Generic_MonsterAffixAvengerArcaneEnchanted { get; } // 384426
		ISnoPower Generic_MonsterAffixAvengerArcaneEnchantedCast { get; } // 384436
		ISnoPower Generic_MonsterAffixAvengerArcaneEnchantedNewPetBasic { get; } // 392128
		ISnoPower Generic_MonsterAffixAvengerBuff { get; } // 226292
		ISnoPower Generic_MonsterAffixAvengerChampion { get; } // 226289
		ISnoPower Generic_MonsterAffixAvengerMortar { get; } // 384594
		ISnoPower Generic_MonsterAffixAvengerMortarCast { get; } // 384596
		ISnoPower Generic_MonsterAffixBallista { get; } // 91098
		ISnoPower Generic_MonsterAffixChampionBuff { get; } // 210333
		ISnoPower Generic_MonsterAffixDesecrator { get; } // 70874
		ISnoPower Generic_MonsterAffixDesecratorBuff { get; } // 156106
		ISnoPower Generic_MonsterAffixDesecratorBuffChampion { get; } // 221131
		ISnoPower Generic_MonsterAffixDesecratorCast { get; } // 156105
		ISnoPower Generic_MonsterAffixDieTogether { get; } // 91232
		ISnoPower Generic_MonsterAffixElectrified { get; } // 81420
		ISnoPower Generic_MonsterAffixElectrifiedLRBossCustom { get; } // 365083
		ISnoPower Generic_MonsterAffixElectrifiedMinion { get; } // 109899
		ISnoPower Generic_MonsterAffixExtraHealth { get; } // 70650
		ISnoPower Generic_MonsterAffixFast { get; } // 70849
		ISnoPower Generic_MonsterAffixFrozen { get; } // 90144
		ISnoPower Generic_MonsterAffixFrozenCast { get; } // 231149
		ISnoPower Generic_MonsterAffixFrozenRare { get; } // 231157
		ISnoPower Generic_MonsterAffixHealing { get; } // 276798
		ISnoPower Generic_MonsterAffixHealthlink { get; } // 71239
		ISnoPower Generic_MonsterAffixIllusionist { get; } // 71108
		ISnoPower Generic_MonsterAffixIllusionistCast { get; } // 264185
		ISnoPower Generic_MonsterAffixJailer { get; } // 222743
		ISnoPower Generic_MonsterAffixJailerCast { get; } // 222744
		ISnoPower Generic_MonsterAffixJailerChampion { get; } // 222745
		ISnoPower Generic_MonsterAffixJuggernaut { get; } // 455436
		ISnoPower Generic_MonsterAffixKnockback { get; } // 70655
		ISnoPower Generic_MonsterAffixLethargy { get; } // 488912
		ISnoPower Generic_MonsterAffixLinked { get; } // 226497
		ISnoPower Generic_MonsterAffixMissileDampening { get; } // 91028
		ISnoPower Generic_MonsterAffixMissileDampeningCast { get; } // 376860
		ISnoPower Generic_MonsterAffixMolten { get; } // 90314
		ISnoPower Generic_MonsterAffixMoltenMinion { get; } // 109898
		ISnoPower Generic_MonsterAffixMortar { get; } // 215756
		ISnoPower Generic_MonsterAffixMortarCast { get; } // 215757
		ISnoPower Generic_MonsterAffixNecrotic { get; } // 488914
		ISnoPower Generic_MonsterAffixNecroticQAtest { get; } // 489153
		ISnoPower Generic_MonsterAffixNightmarish { get; } // 247258
		ISnoPower Generic_MonsterAffixPheonix { get; } // 120655
		ISnoPower Generic_MonsterAffixPlagued { get; } // 90566
		ISnoPower Generic_MonsterAffixPlaguedCast { get; } // 231115
		ISnoPower Generic_MonsterAffixPuppetmaster { get; } // 71023
		ISnoPower Generic_MonsterAffixPuppetmasterMinion { get; } // 71024
		ISnoPower Generic_MonsterAffixReflectsDamage { get; } // 230877
		ISnoPower Generic_MonsterAffixReflectsDamageCast { get; } // 285770
		ISnoPower Generic_MonsterAffixResourceSteal { get; } // 488913
		ISnoPower Generic_MonsterAffixShielding { get; } // 226437
		ISnoPower Generic_MonsterAffixShieldingCast { get; } // 226438
		ISnoPower Generic_MonsterAffixTeleporterBuff { get; } // 155958
		ISnoPower Generic_MonsterAffixTeleporterCast { get; } // 155959
		ISnoPower Generic_MonsterAffixThunderstormBuff { get; } // 336177
		ISnoPower Generic_MonsterAffixThunderstormBuffChampion { get; } // 336178
		ISnoPower Generic_MonsterAffixThunderstormCast { get; } // 336179
		ISnoPower Generic_MonsterAffixVampiric { get; } // 70309
		ISnoPower Generic_MonsterAffixVortexBuff { get; } // 120306
		ISnoPower Generic_MonsterAffixVortexBuffChampion { get; } // 221132
		ISnoPower Generic_MonsterAffixVortexCast { get; } // 120305
		ISnoPower Generic_MonsterAffixWaller { get; } // 226293
		ISnoPower Generic_MonsterAffixWallerCast { get; } // 226294
		ISnoPower Generic_MonsterAffixWallerRare { get; } // 231117
		ISnoPower Generic_MonsterAffixWallerRareCast { get; } // 231118
		ISnoPower Generic_MonsterPoisonMeleeAttack { get; } // 30333
		ISnoPower Generic_MonsterRangedProjectile { get; } // 30334
		ISnoPower Generic_MonsterSpellProjectile { get; } // 30338
		ISnoPower Generic_MorluSpellcasterBreathOfFire { get; } // 158970
		ISnoPower Generic_MorluSpellcasterBreathOfFrost { get; } // 263415
		ISnoPower Generic_MorluSpellcasterMeteor { get; } // 158969
		ISnoPower Generic_MorluSpellcasterMeteorGraspOfTheDeadPrototype { get; } // 256045
		ISnoPower Generic_MorluSpellcasterShift { get; } // 158968
		ISnoPower Generic_MorluSpellcasterShiftNoCooldownCold { get; } // 428806
		ISnoPower Generic_MultiplayerBuff { get; } // 258199
		ISnoPower Generic_NPCLookAt { get; } // 30342
		ISnoPower Generic_OasisRockslideADamage { get; } // 395342
		ISnoPower Generic_OnDeathArcane { get; } // 30343
		ISnoPower Generic_OnDeathCold { get; } // 30344
		ISnoPower Generic_OnDeathFire { get; } // 30345
		ISnoPower Generic_OnDeathLightning { get; } // 30346
		ISnoPower Generic_OnDeathPoison { get; } // 30347
		ISnoPower Generic_OperateHelperAttach { get; } // 30348
		ISnoPower Generic_p1GreedCharge { get; } // 380460
		ISnoPower Generic_p1GreedChargeLong { get; } // 391073
		ISnoPower Generic_p1GreedChargeNoLOS { get; } // 398253
		ISnoPower Generic_p1GreedGoblinKnockback { get; } // 394194
		ISnoPower Generic_p1GreedGoldenMeteorShower { get; } // 385810
		ISnoPower Generic_p1GreedGoldSpawner { get; } // 385737
		ISnoPower Generic_p1GreedMinionPassiveLifetimeBuff { get; } // 382195
		ISnoPower Generic_p1GreedPassiveGoblinSpawnertest { get; } // 391176
		ISnoPower Generic_p1GreedPassiveLifetimeBuff { get; } // 381205
		ISnoPower Generic_p1GreedShockwave { get; } // 380646
		ISnoPower Generic_p1GreedSpawnMinion { get; } // 382342
		ISnoPower Generic_p1GreedUltimateMeteorShower { get; } // 391193
		ISnoPower Generic_p1ItemPassiveUniqueRing942 { get; } // 408974
		ISnoPower Generic_p1ItemPassiveUniqueRing943 { get; } // 409811
		ISnoPower Generic_p1ItemPassiveUniqueRing945 { get; } // 440923
		ISnoPower Generic_p1TieredRiftSpawnNPC { get; } // 409173
		ISnoPower Generic_p1TreasureGoblinOnDeathAnniversaryPortal { get; } // 434819
		ISnoPower Generic_p1TreasureGoblinOnDeathGreedPortal { get; } // 382738
		ISnoPower Generic_p1TreasureGoblinOnDeathWhimsyshirePortal { get; } // 405592
		ISnoPower Generic_p2FallenLunaticAggroring { get; } // 434026
		ISnoPower Generic_P2ItemPassiveUniqueRing001 { get; } // 423205
		ISnoPower Generic_P2ItemPassiveUniqueRing002 { get; } // 423206
		ISnoPower Generic_P2ItemPassiveUniqueRing003 { get; } // 423226
		ISnoPower Generic_P2ItemPassiveUniqueRing004 { get; } // 423227
		ISnoPower Generic_P2ItemPassiveUniqueRing005 { get; } // 423228
		ISnoPower Generic_P2ItemPassiveUniqueRing007 { get; } // 423230
		ISnoPower Generic_P2ItemPassiveUniqueRing009 { get; } // 423233
		ISnoPower Generic_P2ItemPassiveUniqueRing010 { get; } // 423234
		ISnoPower Generic_P2ItemPassiveUniqueRing011 { get; } // 423235
		ISnoPower Generic_P2ItemPassiveUniqueRing012 { get; } // 423236
		ISnoPower Generic_P2ItemPassiveUniqueRing013 { get; } // 423237
		ISnoPower Generic_P2ItemPassiveUniqueRing015 { get; } // 423239
		ISnoPower Generic_P2ItemPassiveUniqueRing016 { get; } // 423240
		ISnoPower Generic_P2ItemPassiveUniqueRing017 { get; } // 423241
		ISnoPower Generic_P2ItemPassiveUniqueRing018 { get; } // 423242
		ISnoPower Generic_P2ItemPassiveUniqueRing019 { get; } // 423243
		ISnoPower Generic_P2ItemPassiveUniqueRing020 { get; } // 423244
		ISnoPower Generic_P2ItemPassiveUniqueRing021 { get; } // 427798
		ISnoPower Generic_P2ItemPassiveUniqueRing022 { get; } // 427799
		ISnoPower Generic_P2ItemPassiveUniqueRing023 { get; } // 428220
		ISnoPower Generic_P2ItemPassiveUniqueRing025 { get; } // 429665
		ISnoPower Generic_P2ItemPassiveUniqueRing026 { get; } // 429673
		ISnoPower Generic_P2ItemPassiveUniqueRing027 { get; } // 429851
		ISnoPower Generic_P2ItemPassiveUniqueRing028 { get; } // 429855
		ISnoPower Generic_P2ItemPassiveUniqueRing029 { get; } // 429856
		ISnoPower Generic_P2ItemPassiveUniqueRing030 { get; } // 429857
		ISnoPower Generic_P2ItemPassiveUniqueRing031 { get; } // 429885
		ISnoPower Generic_P2ItemPassiveUniqueRing033 { get; } // 430228
		ISnoPower Generic_P2ItemPassiveUniqueRing036 { get; } // 430672
		ISnoPower Generic_P2ItemPassiveUniqueRing037 { get; } // 430673
		ISnoPower Generic_P2ItemPassiveUniqueRing039 { get; } // 430675
		ISnoPower Generic_P2ItemPassiveUniqueRing040 { get; } // 430676
		ISnoPower Generic_P2ItemPassiveUniqueRing041 { get; } // 430677
		ISnoPower Generic_P2ItemPassiveUniqueRing044 { get; } // 430680
		ISnoPower Generic_P2ItemPassiveUniqueRing048 { get; } // 430684
		ISnoPower Generic_P2ItemPassiveUniqueRing049 { get; } // 430685
		ISnoPower Generic_P2ItemPassiveUniqueRing050 { get; } // 430686
		ISnoPower Generic_P2ItemPassiveUniqueRing051 { get; } // 434377
		ISnoPower Generic_P2ItemPassiveUniqueRing053 { get; } // 434964
		ISnoPower Generic_P2ItemPassiveUniqueRing055 { get; } // 434967
		ISnoPower Generic_P2ItemPassiveUniqueRing056 { get; } // 434969
		ISnoPower Generic_P2ItemPassiveUniqueRing057 { get; } // 434980
		ISnoPower Generic_P2ItemPassiveUniqueRing059 { get; } // 435040
		ISnoPower Generic_P2SpecialGoblinRiftSpawn { get; } // 429651
		ISnoPower Generic_P3ItemPassiveUniqueRing001 { get; } // 436426
		ISnoPower Generic_P3ItemPassiveUniqueRing002 { get; } // 436427
		ISnoPower Generic_P3ItemPassiveUniqueRing003 { get; } // 436428
		ISnoPower Generic_P3ItemPassiveUniqueRing005 { get; } // 436468
		ISnoPower Generic_P3ItemPassiveUniqueRing009 { get; } // 437710
		ISnoPower Generic_P3ItemPassiveUniqueRing010 { get; } // 437711
		ISnoPower Generic_P3ItemPassiveUniqueRing011 { get; } // 437840
		ISnoPower Generic_P3ItemPassiveUniqueRing012 { get; } // 437843
		ISnoPower Generic_P3ItemPassiveUniqueRing013 { get; } // 437844
		ISnoPower Generic_P3ItemPassiveUniqueRing015 { get; } // 439303
		ISnoPower Generic_P3ItemPassiveUniqueRing016 { get; } // 439308
		ISnoPower Generic_P3ItemPassiveUniqueRing017 { get; } // 439309
		ISnoPower Generic_P3ItemPassiveUniqueRing018 { get; } // 439310
		ISnoPower Generic_P3ItemPassiveUniqueRing019 { get; } // 439311
		ISnoPower Generic_P3ItemPassiveUniqueRing020 { get; } // 439312
		ISnoPower Generic_P3ItemPassiveUniqueRing021 { get; } // 440235
		ISnoPower Generic_P3ItemPassiveUniqueRing025 { get; } // 440568
		ISnoPower Generic_P3ItemPassiveUniqueRing026 { get; } // 440569
		ISnoPower Generic_P3ItemPassiveUniqueRing030 { get; } // 441113
		ISnoPower Generic_P3ItemPassiveUniqueRing033 { get; } // 441280
		ISnoPower Generic_P3ItemPassiveUniqueRing035 { get; } // 441305
		ISnoPower Generic_P3ItemPassiveUniqueRing036 { get; } // 441318
		ISnoPower Generic_P3ItemPassiveUniqueRing037 { get; } // 441349
		ISnoPower Generic_P3ItemPassiveUniqueRing039 { get; } // 442353
		ISnoPower Generic_P3ItemPassiveUniqueRing040 { get; } // 442477
		ISnoPower Generic_P41ItemPassiveUniqueRing001 { get; } // 451158
		ISnoPower Generic_P41ItemPassiveUniqueRing007 { get; } // 451165
		ISnoPower Generic_P41ItemPassiveUniqueRing013 { get; } // 451171
		ISnoPower Generic_P41ItemPassiveUniqueRing014 { get; } // 451172
		ISnoPower Generic_P41ItemPassiveUniqueRing015 { get; } // 451173
		ISnoPower Generic_P41ItemPassiveUniqueRing016 { get; } // 451174
		ISnoPower Generic_P41ItemPassiveUniqueRing017 { get; } // 451175
		ISnoPower Generic_P41ItemPassiveUniqueRing018 { get; } // 451176
		ISnoPower Generic_P41ItemPassiveUniqueRing019 { get; } // 451177
		ISnoPower Generic_P41ItemPassiveUniqueRing020 { get; } // 451178
		ISnoPower Generic_P41ItemPassiveUniqueRing021 { get; } // 451186
		ISnoPower Generic_P42ItemPassiveUniqueRing001 { get; } // 451236
		ISnoPower Generic_P42ItemPassiveUniqueRing004 { get; } // 451239
		ISnoPower Generic_P42ItemPassiveUniqueRing005 { get; } // 451240
		ISnoPower Generic_P42ItemPassiveUniqueRing006 { get; } // 451241
		ISnoPower Generic_P42ItemPassiveUniqueRing008 { get; } // 451243
		ISnoPower Generic_P42ItemPassiveUniqueRing009 { get; } // 451244
		ISnoPower Generic_P42ItemPassiveUniqueRing010 { get; } // 451245
		ISnoPower Generic_P42ItemPassiveUniqueRing011 { get; } // 451246
		ISnoPower Generic_P42ItemPassiveUniqueRing012 { get; } // 451247
		ISnoPower Generic_P42ItemPassiveUniqueRing013 { get; } // 451248
		ISnoPower Generic_P42ItemPassiveUniqueRing014 { get; } // 451249
		ISnoPower Generic_P42ItemPassiveUniqueRing015 { get; } // 451250
		ISnoPower Generic_P42ItemPassiveUniqueRing016 { get; } // 451251
		ISnoPower Generic_P42ItemPassiveUniqueRing017 { get; } // 451252
		ISnoPower Generic_P42ItemPassiveUniqueRing018 { get; } // 451253
		ISnoPower Generic_P42ItemPassiveUniqueRing019 { get; } // 451254
		ISnoPower Generic_P42ItemPassiveUniqueRing020 { get; } // 451255
		ISnoPower Generic_P42ItemPassiveUniqueRing697x1 { get; } // 451313
		ISnoPower Generic_p42ItemPassiveUniqueRing945 { get; } // 451333
		ISnoPower Generic_p43ADBarrelExplode { get; } // 455182
		ISnoPower Generic_p43ADEventAnvilOfFury { get; } // 455050
		ISnoPower Generic_p43ADTrapArrow { get; } // 455198
		ISnoPower Generic_p43d1ButcherMeleeBasic { get; } // 455501
		ISnoPower Generic_p43d1DiabloClawRip { get; } // 453765
		ISnoPower Generic_p43d1fastMummyMelee { get; } // 453803
		ISnoPower Generic_p43d1fastMummyStealth { get; } // 453802
		ISnoPower Generic_p43d1FleshPitFlyerBlink { get; } // 453994
		ISnoPower Generic_p43d1GorehoundAcidSpit { get; } // 454139
		ISnoPower Generic_p43d1MageFlash { get; } // 454586
		ISnoPower Generic_p43d1MageTeleport { get; } // 454584
		ISnoPower Generic_p43d1TerrorDemonLightningBreath { get; } // 454163
		ISnoPower Generic_p43d1ZoltunKulleFieryBoulder { get; } // 453734
		ISnoPower Generic_p43d1ZoltunKulleTeleport { get; } // 453738
		ISnoPower Generic_p43d1ZombieSkinnyMelee { get; } // 454045
		ISnoPower Generic_P43ItemPassiveUniqueRing003 { get; } // 454929
		ISnoPower Generic_P43ItemPassiveUniqueRing007 { get; } // 454935
		ISnoPower Generic_P43ItemPassiveUniqueRing008 { get; } // 454936
		ISnoPower Generic_P43ItemPassiveUniqueRing009 { get; } // 454937
		ISnoPower Generic_P43ItemPassiveUniqueRing010 { get; } // 454938
		ISnoPower Generic_P43ItemPassiveUniqueRing011 { get; } // 454939
		ISnoPower Generic_P43ItemPassiveUniqueRing012 { get; } // 454940
		ISnoPower Generic_P4CrabMotherEnrage { get; } // 442660
		ISnoPower Generic_P4DemonFlyerFireBreath { get; } // 439325
		ISnoPower Generic_p4demonTrooperSpecialMelee { get; } // 435046
		ISnoPower Generic_P4ForestMysteriousHermitArcaneFireball { get; } // 445642
		ISnoPower Generic_P4ForestMysteriousHermitArcaneFireball_ { get; } // 445864
		ISnoPower Generic_P4ForestMysteriousHermitArcaneFlameWall_ { get; } // 445865
		ISnoPower Generic_p4ForestMysteriousHermitBoomerangBlade { get; } // 445808
		ISnoPower Generic_p4ForestMysteriousHermitProjectile { get; } // 437112
		ISnoPower Generic_p4ForestMysteriousHermitTeleportIllusion { get; } // 445850
		ISnoPower Generic_P4ForestMysteriousManSpiritForm { get; } // 437524
		ISnoPower Generic_P4ForestMysteriousManSpiritSetup { get; } // 437546
		ISnoPower Generic_p4GoatmanFireball { get; } // 433729
		ISnoPower Generic_p4IceGoatmanRangedChargedShot { get; } // 437534
		ISnoPower Generic_p4IcePorcupineBackpedalShot { get; } // 434171
		ISnoPower Generic_p4IcePorcupineJumpBack { get; } // 434174
		ISnoPower Generic_p4IcePorcupineNova { get; } // 430206
		ISnoPower Generic_p4IcePorcupineShot { get; } // 434209
		ISnoPower Generic_P4ItemPassiveUniqueRing001 { get; } // 444521
		ISnoPower Generic_P4ItemPassiveUniqueRing002 { get; } // 444522
		ISnoPower Generic_P4ItemPassiveUniqueRing003 { get; } // 444929
		ISnoPower Generic_P4ItemPassiveUniqueRing004 { get; } // 444969
		ISnoPower Generic_P4ItemPassiveUniqueRing005 { get; } // 445008
		ISnoPower Generic_P4ItemPassiveUniqueRing008 { get; } // 445279
		ISnoPower Generic_P4ItemPassiveUniqueRing010 { get; } // 445639
		ISnoPower Generic_P4ItemPassiveUniqueRing011 { get; } // 445692
		ISnoPower Generic_P4ItemPassiveUniqueRing014 { get; } // 445798
		ISnoPower Generic_P4ItemPassiveUniqueRing015 { get; } // 445814
		ISnoPower Generic_P4ItemPassiveUniqueRing016 { get; } // 445829
		ISnoPower Generic_P4ItemPassiveUniqueRing017 { get; } // 445920
		ISnoPower Generic_P4ItemPassiveUniqueRing018 { get; } // 445942
		ISnoPower Generic_P4ItemPassiveUniqueRing021 { get; } // 446063
		ISnoPower Generic_p4ItemPassiveUniqueRing024KKG { get; } // 436797
		ISnoPower Generic_P4ItemPassiveUniqueRing027 { get; } // 446195
		ISnoPower Generic_P4ItemPassiveUniqueRing028 { get; } // 446318
		ISnoPower Generic_P4ItemPassiveUniqueRing031 { get; } // 446511
		ISnoPower Generic_P4ItemPassiveUniqueRing033 { get; } // 446562
		ISnoPower Generic_P4ItemPassiveUniqueRing037 { get; } // 446638
		ISnoPower Generic_P4ItemPassiveUniqueRing042 { get; } // 446734
		ISnoPower Generic_P4ItemPassiveUniqueRing043 { get; } // 446761
		ISnoPower Generic_P4ItemPassiveUniqueRing043SpawnDecoy { get; } // 446963
		ISnoPower Generic_P4ItemPassiveUniqueRing044 { get; } // 446762
		ISnoPower Generic_P4ItemPassiveUniqueRing051 { get; } // 447290
		ISnoPower Generic_P4ItemPassiveUniqueRing052 { get; } // 447291
		ISnoPower Generic_P4ItemPassiveUniqueRing057 { get; } // 447541
		ISnoPower Generic_P4ItemPassiveUniqueRing058 { get; } // 447553
		ISnoPower Generic_P4ItemPassiveUniqueRing059 { get; } // 447581
		ISnoPower Generic_P4ItemPassiveUniqueRing064 { get; } // 447905
		ISnoPower Generic_P4ItemPassiveUniqueRing066 { get; } // 449001
		ISnoPower Generic_P4ItemPassiveUniqueRing067 { get; } // 449021
		ISnoPower Generic_P4ItemPassiveUniqueRing069 { get; } // 449037
		ISnoPower Generic_P4ItemPassiveUniqueRing071 { get; } // 449046
		ISnoPower Generic_P4ItemPassiveUniqueRing076 { get; } // 449114
		ISnoPower Generic_P4ItemPassiveUniqueRing077 { get; } // 449222
		ISnoPower Generic_P4ItemPassiveUniqueRing079 { get; } // 449237
		ISnoPower Generic_P4ItemPassiveUniqueRing080 { get; } // 449252
		ISnoPower Generic_P4ItemPassiveUniqueRing081 { get; } // 449264
		ISnoPower Generic_P4ItemPassiveUniqueRing082 { get; } // 449671
		ISnoPower Generic_P4ItemPassiveUniqueRing083 { get; } // 449703
		ISnoPower Generic_P4ItemPassiveUniqueRing084 { get; } // 450294
		ISnoPower Generic_P4ItemPassiveUniqueRing085 { get; } // 450472
		ISnoPower Generic_p4LRBossFedExCharge { get; } // 433232
		ISnoPower Generic_p4LRBossSpawnBoneTurrets { get; } // 433225
		ISnoPower Generic_p4LRTerrorDemonWall { get; } // 429019
		ISnoPower Generic_p4MaggotSuicideProgressiveFreeze { get; } // 435737
		ISnoPower Generic_P4MermaidHydra { get; } // 442662
		ISnoPower Generic_p4MoleRatCharge { get; } // 423014
		ISnoPower Generic_p4rathostteleport { get; } // 423072
		ISnoPower Generic_p4RatKingDoubleSwing { get; } // 436574
		ISnoPower Generic_p4RatKingLifetimeBuffPlagued { get; } // 440700
		ISnoPower Generic_p4RatKingRatBallMonsterSetup { get; } // 427175
		ISnoPower Generic_p4RatKingSummonRatBallMonster { get; } // 427176
		ISnoPower Generic_p4RatKingSummonRatVolcano { get; } // 427244
		ISnoPower Generic_p4RatKingThunderdome { get; } // 427211
		ISnoPower Generic_p4RatKingWaspRain { get; } // 432984
		ISnoPower Generic_P4RuinsCannibalBarbarianBurrowOut { get; } // 437397
		ISnoPower Generic_P4RuinsCannibalBarbarianCombatRoll { get; } // 436379
		ISnoPower Generic_P4RuinsCannibalBarbarianFuriousCharge { get; } // 437858
		ISnoPower Generic_P4RuinsCannibalBarbarianGroundstomp { get; } // 436370
		ISnoPower Generic_P4RuinsCannibalBarbarianHammerOfTheAncients { get; } // 439318
		ISnoPower Generic_P4RuinsCannibalBarbarianIntroFear { get; } // 435911
		ISnoPower Generic_P4RuinsCannibalBarbarianLeapQuake { get; } // 436375
		ISnoPower Generic_P4RuinsCannibalBarbarianShout { get; } // 435875
		ISnoPower Generic_P4RuinsCannibalBarbarianSummon { get; } // 437262
		ISnoPower Generic_P4RuinsCannibalBarbarianWeaponThrow { get; } // 437865
		ISnoPower Generic_P4RuinsCannibalBarbarianWhirlwind { get; } // 435885
		ISnoPower Generic_p4ruinsfrostEventTheZiggurat { get; } // 433486
		ISnoPower Generic_P4RuinsFrostTrapSwingingBlade { get; } // 406180
		ISnoPower Generic_P4SacrificeMonsterBreakableNova { get; } // 450213
		ISnoPower Generic_P4SacrificeMonsterEnrage { get; } // 447376
		ISnoPower Generic_P4SandWaspProjectile { get; } // 410520
		ISnoPower Generic_p4SasquatchGorillaPound { get; } // 430556
		ISnoPower Generic_p4SasquatchRockPunchKnockback { get; } // 415079
		ISnoPower Generic_p4SasquatchSpikeLine { get; } // 430582
		ISnoPower Generic_p4SasquatchTriplePunch { get; } // 430448
		ISnoPower Generic_p4ScavengerSpawnerADeath { get; } // 435467
		ISnoPower Generic_p4ScorpionBugHoverProjectile { get; } // 426866
		ISnoPower Generic_p4SeaMonsterSpawnCrabs { get; } // 431678
		ISnoPower Generic_p4SetDungBarbKingsEnmy { get; } // 444770
		ISnoPower Generic_p4SetDungBarbKingsPly { get; } // 444771
		ISnoPower Generic_p4SetDungBarbMightEnmy { get; } // 444922
		ISnoPower Generic_p4SetDungBarbMightPly { get; } // 444923
		ISnoPower Generic_p4SetDungBarbRaekorEnmy { get; } // 444875
		ISnoPower Generic_p4SetDungBarbRaekorPly { get; } // 444876
		ISnoPower Generic_p4SetDungBarbWastesEnmy { get; } // 444832
		ISnoPower Generic_p4SetDungBarbWastesPly { get; } // 444834
		ISnoPower Generic_p4SetDungCruAkkhanEnmy { get; } // 444632
		ISnoPower Generic_p4SetDungCruAkkhanPly { get; } // 444633
		ISnoPower Generic_p4SetDungCruRolandEnmy { get; } // 444712
		ISnoPower Generic_p4SetDungCruRolandPly { get; } // 444713
		ISnoPower Generic_p4SetDungCruSeekerEnmy { get; } // 445277
		ISnoPower Generic_p4SetDungCruSeekerPly { get; } // 445278
		ISnoPower Generic_p4SetDungCruThornsEnmy { get; } // 445257
		ISnoPower Generic_p4SetDungCruThornsPly { get; } // 445258
		ISnoPower Generic_p4SetDungDeathBarbKings { get; } // 444769
		ISnoPower Generic_p4SetDungDeathBarbMight { get; } // 444915
		ISnoPower Generic_p4SetDungDeathBarbRaekor { get; } // 444874
		ISnoPower Generic_p4SetDungDeathBarbWastes { get; } // 444826
		ISnoPower Generic_p4SetDungDeathCruAkkhan { get; } // 444631
		ISnoPower Generic_p4SetDungDeathCruRoland { get; } // 444710
		ISnoPower Generic_p4SetDungDeathCruSeeker { get; } // 445276
		ISnoPower Generic_p4SetDungDeathCruThorns { get; } // 445251
		ISnoPower Generic_p4SetDungDeathDHEss { get; } // 445035
		ISnoPower Generic_p4SetDungDeathDHMar { get; } // 444996
		ISnoPower Generic_p4SetDungDeathDHNat { get; } // 445007
		ISnoPower Generic_p4SetDungDeathDHShadow { get; } // 445062
		ISnoPower Generic_p4SetDungDeathMonkInnas { get; } // 445173
		ISnoPower Generic_p4SetDungDeathMonkStorms { get; } // 445225
		ISnoPower Generic_p4SetDungDeathMonkSunwuko { get; } // 445191
		ISnoPower Generic_p4SetDungDeathMonkUliana { get; } // 445208
		ISnoPower Generic_p4SetDungDeathWDHaunt { get; } // 445098
		ISnoPower Generic_p4SetDungDeathWDJade { get; } // 445155
		ISnoPower Generic_p4SetDungDeathWDSpider { get; } // 445132
		ISnoPower Generic_p4SetDungDeathWDTooth { get; } // 445081
		ISnoPower Generic_p4SetDungDeathWizFirebird { get; } // 444577
		ISnoPower Generic_p4SetDungDeathWizOpus { get; } // 443832
		ISnoPower Generic_p4SetDungDeathWizRasha { get; } // 444516
		ISnoPower Generic_p4SetDungDeathWizVyr { get; } // 444972
		ISnoPower Generic_p4SetDungDHEssEnmy { get; } // 445036
		ISnoPower Generic_p4SetDungDHEssPly { get; } // 445037
		ISnoPower Generic_p4SetDungDHMarEnmy { get; } // 444997
		ISnoPower Generic_p4SetDungDHMarPly { get; } // 444998
		ISnoPower Generic_p4SetDungDHNatEnmy { get; } // 445009
		ISnoPower Generic_p4SetDungDHNatPly { get; } // 445010
		ISnoPower Generic_p4SetDungDHShadowEnmy { get; } // 445063
		ISnoPower Generic_p4SetDungDHShadowPly { get; } // 445064
		ISnoPower Generic_p4SetDungGenericsEnmy { get; } // 443795
		ISnoPower Generic_p4SetDungGenericsPly { get; } // 443833
		ISnoPower Generic_p4SetDungGenericsPlyBalance { get; } // 450351
		ISnoPower Generic_p4SetDungGenericsPortal { get; } // 450469
		ISnoPower Generic_p4SetDungMonkInnasEnmy { get; } // 445174
		ISnoPower Generic_p4SetDungMonkInnasPly { get; } // 445175
		ISnoPower Generic_p4SetDungMonkStormsEnmy { get; } // 445233
		ISnoPower Generic_p4SetDungMonkStormsPly { get; } // 445234
		ISnoPower Generic_p4SetDungMonkSunwukoEnmy { get; } // 445192
		ISnoPower Generic_p4SetDungMonkSunwukoPly { get; } // 445193
		ISnoPower Generic_p4SetDungMonkUlianaEnmy { get; } // 445209
		ISnoPower Generic_p4SetDungMonkUlianaPly { get; } // 445210
		ISnoPower Generic_p4SetDungMonsterAffixMortarCast { get; } // 447584
		ISnoPower Generic_p4SetDungPedestalBarbKings { get; } // 447950
		ISnoPower Generic_p4SetDungPedestalBarbMight { get; } // 447975
		ISnoPower Generic_p4SetDungPedestalBarbRaekor { get; } // 447976
		ISnoPower Generic_p4SetDungPedestalBarbWastes { get; } // 447977
		ISnoPower Generic_p4SetDungPedestalCruAkkhan { get; } // 447978
		ISnoPower Generic_p4SetDungPedestalCruRoland { get; } // 447979
		ISnoPower Generic_p4SetDungPedestalCruSeeker { get; } // 447980
		ISnoPower Generic_p4SetDungPedestalCruThorns { get; } // 447981
		ISnoPower Generic_p4SetDungPedestalDHEss { get; } // 447982
		ISnoPower Generic_p4SetDungPedestalDHMar { get; } // 447984
		ISnoPower Generic_p4SetDungPedestalDHNat { get; } // 447983
		ISnoPower Generic_p4SetDungPedestalDHShadow { get; } // 447985
		ISnoPower Generic_p4SetDungPedestalMonkInnas { get; } // 447986
		ISnoPower Generic_p4SetDungPedestalMonkStorms { get; } // 447987
		ISnoPower Generic_p4SetDungPedestalMonkSunwuko { get; } // 447988
		ISnoPower Generic_p4SetDungPedestalMonkUliana { get; } // 447989
		ISnoPower Generic_p4SetDungPedestalWDHaunt { get; } // 447990
		ISnoPower Generic_p4SetDungPedestalWDJade { get; } // 447991
		ISnoPower Generic_p4SetDungPedestalWDSpider { get; } // 447992
		ISnoPower Generic_p4SetDungPedestalWDTooth { get; } // 447993
		ISnoPower Generic_p4SetDungPedestalWizFirebird { get; } // 447995
		ISnoPower Generic_p4SetDungPedestalWizOpus { get; } // 447996
		ISnoPower Generic_p4SetDungPedestalWizRasha { get; } // 447997
		ISnoPower Generic_p4SetDungPedestalWizVyr { get; } // 447998
		ISnoPower Generic_p4SetDungPortalChecks { get; } // 447038
		ISnoPower Generic_p4SetDungWDHauntEnmy { get; } // 445099
		ISnoPower Generic_p4SetDungWDHauntPly { get; } // 445100
		ISnoPower Generic_p4SetDungWDJadeEnmy { get; } // 445156
		ISnoPower Generic_p4SetDungWDJadePly { get; } // 445157
		ISnoPower Generic_p4SetDungWDSpiderEnmy { get; } // 445133
		ISnoPower Generic_p4SetDungWDSpiderPly { get; } // 445134
		ISnoPower Generic_p4SetDungWDToothEnmy { get; } // 445082
		ISnoPower Generic_p4SetDungWDToothPly { get; } // 445083
		ISnoPower Generic_p4SetDungWestmarchBruteCharge { get; } // 451207
		ISnoPower Generic_p4SetDungWizFirebirdEnmy { get; } // 445771
		ISnoPower Generic_p4SetDungWizFirebirdPly { get; } // 445772
		ISnoPower Generic_p4SetDungWizOpusEnmy { get; } // 444008
		ISnoPower Generic_p4SetDungWizOpusPly { get; } // 443898
		ISnoPower Generic_p4SetDungWizRashaEnmy { get; } // 444519
		ISnoPower Generic_p4SetDungWizRashaPly { get; } // 444520
		ISnoPower Generic_p4SetDungWizVyrEnmy { get; } // 444975
		ISnoPower Generic_p4SetDungWizVyrPly { get; } // 444976
		ISnoPower Generic_P4ShrineDebuffDamage { get; } // 445778
		ISnoPower Generic_P4ShrineDebuffSpawner { get; } // 445788
		ISnoPower Generic_p4SkeletonZombieSpawnerADeath { get; } // 433150
		ISnoPower Generic_P4SpiderBombAODDamage { get; } // 274506
		ISnoPower Generic_P4SpiderBombBurrowIn { get; } // 275328
		ISnoPower Generic_p4WaspNestDeath { get; } // 410598
		ISnoPower Generic_p4WickermanSpawnerADeath { get; } // 435834
		ISnoPower Generic_P4WoodWraithSummonSporesCeremonyEvent { get; } // 435833
		ISnoPower Generic_p4WoodWraithVineTrap { get; } // 430133
		ISnoPower Generic_p4YetiIceBreath { get; } // 411373
		ISnoPower Generic_p4YetiIceSpikes { get; } // 413296
		ISnoPower Generic_p4YetiMeleeBasic { get; } // 437834
		ISnoPower Generic_p4YetiOverheadSmash { get; } // 440693
		ISnoPower Generic_p4YetiSnowBoulderRoll { get; } // 429905
		ISnoPower Generic_P5ItemPassiveUniqueRing001 { get; } // 451256
		ISnoPower Generic_P5ItemPassiveUniqueRing002 { get; } // 451257
		ISnoPower Generic_P5ItemPassiveUniqueRing003 { get; } // 451258
		ISnoPower Generic_P5ItemPassiveUniqueRing004 { get; } // 451259
		ISnoPower Generic_P5ItemPassiveUniqueRing005 { get; } // 451260
		ISnoPower Generic_P5ItemPassiveUniqueRing006 { get; } // 451261
		ISnoPower Generic_P5ItemPassiveUniqueRing007 { get; } // 451262
		ISnoPower Generic_P5ItemPassiveUniqueRing008 { get; } // 451263
		ISnoPower Generic_P5ItemPassiveUniqueRing009 { get; } // 451264
		ISnoPower Generic_P5ItemPassiveUniqueRing010 { get; } // 451265
		ISnoPower Generic_P5ItemPassiveUniqueRing011 { get; } // 451266
		ISnoPower Generic_P5ItemPassiveUniqueRing012 { get; } // 451267
		ISnoPower Generic_P5ItemPassiveUniqueRing013 { get; } // 451268
		ISnoPower Generic_P5ItemPassiveUniqueRing014 { get; } // 451269
		ISnoPower Generic_P5ItemPassiveUniqueRing015 { get; } // 451270
		ISnoPower Generic_P5ItemPassiveUniqueRing016 { get; } // 451271
		ISnoPower Generic_P5ItemPassiveUniqueRing017 { get; } // 451272
		ISnoPower Generic_P5ItemPassiveUniqueRing018 { get; } // 451273
		ISnoPower Generic_P5ItemPassiveUniqueRing019 { get; } // 451274
		ISnoPower Generic_P5ItemPassiveUniqueRing020 { get; } // 451275
		ISnoPower Generic_P610ItemPassiveUniqueMojo010x1tooltipDummy2 { get; } // 484658
		ISnoPower Generic_P61ItemPassiveUniqueRing021 { get; } // 478511
		ISnoPower Generic_P61ItemPassiveUniqueRing027 { get; } // 478539
		ISnoPower Generic_P66ItemPassiveUniqueRing930 { get; } // 483537
		ISnoPower Generic_P66ItemPassiveUniqueRing932 { get; } // 483571
		ISnoPower Generic_P66ItemPassiveUniqueRing933 { get; } // 483572
		ISnoPower Generic_P66ItemPassiveUniqueRing934 { get; } // 483573
		ISnoPower Generic_P66ItemPassiveUniqueRing935 { get; } // 483574
		ISnoPower Generic_P66ItemPassiveUniqueRing941 { get; } // 483548
		ISnoPower Generic_P66ItemPassiveUniqueRing946 { get; } // 483570
		ISnoPower Generic_P67ItemPassiveUniqueRing947 { get; } // 483639
		ISnoPower Generic_P67ItemPassiveUniqueRing948 { get; } // 483643
		ISnoPower Generic_P67ItemPassiveUniqueRing949 { get; } // 483655
		ISnoPower Generic_P67ItemPassiveUniqueRing950 { get; } // 483662
		ISnoPower Generic_P67ItemPassiveUniqueRing951 { get; } // 483663
		ISnoPower Generic_P67ItemPassiveUniqueRing952 { get; } // 483664
		ISnoPower Generic_P67ItemPassiveUniqueRing953 { get; } // 483670
		ISnoPower Generic_P67ItemPassiveUniqueRing956 { get; } // 483852
		ISnoPower Generic_P67ItemPassiveUniqueRing957 { get; } // 483853
		ISnoPower Generic_P67ItemPassiveUniqueRing958 { get; } // 483854
		ISnoPower Generic_P67ItemPassiveUniqueRing959 { get; } // 483859
		ISnoPower Generic_P67ItemPassiveUniqueRing960 { get; } // 483861
		ISnoPower Generic_P67ItemPassiveUniqueRing961 { get; } // 483863
		ISnoPower Generic_P67ItemPassiveUniqueRing962 { get; } // 483865
		ISnoPower Generic_P67ItemPassiveUniqueRing963 { get; } // 483866
		ISnoPower Generic_P67ItemPassiveUniqueRing964 { get; } // 483884
		ISnoPower Generic_P67ItemPassiveUniqueRing965 { get; } // 483889
		ISnoPower Generic_P67ItemPassiveUniqueRing966 { get; } // 483901
		ISnoPower Generic_P67ItemPassiveUniqueRing968 { get; } // 484057
		ISnoPower Generic_P68ItemPassiveUniqueRing001 { get; } // 484060
		ISnoPower Generic_P68ItemPassiveUniqueRing002 { get; } // 484061
		ISnoPower Generic_P68ItemPassiveUniqueRing003 { get; } // 484062
		ISnoPower Generic_P68ItemPassiveUniqueRing006 { get; } // 484121
		ISnoPower Generic_P68ItemPassiveUniqueRing007 { get; } // 484122
		ISnoPower Generic_P68ItemPassiveUniqueRing008 { get; } // 484128
		ISnoPower Generic_P68ItemPassiveUniqueRing009 { get; } // 484129
		ISnoPower Generic_P68ItemPassiveUniqueRing010 { get; } // 484130
		ISnoPower Generic_P68ItemPassiveUniqueRing011 { get; } // 484131
		ISnoPower Generic_P68ItemPassiveUniqueRing012 { get; } // 484144
		ISnoPower Generic_P68ItemPassiveUniqueRing013 { get; } // 484145
		ISnoPower Generic_P68ItemPassiveUniqueRing014 { get; } // 484146
		ISnoPower Generic_P68ItemPassiveUniqueRing018 { get; } // 484279
		ISnoPower Generic_P68ItemPassiveUniqueRing970 { get; } // 484118
		ISnoPower Generic_P69ItemPassiveUniqueRing003 { get; } // 484320
		ISnoPower Generic_P69ItemPassiveUniqueRing004 { get; } // 484497
		ISnoPower Generic_P69ItemPassiveUniqueRing010 { get; } // 484289
		ISnoPower Generic_P69ItemPassiveUniqueRing011 { get; } // 484290
		ISnoPower Generic_P69ItemPassiveUniqueRing012 { get; } // 484291
		ISnoPower Generic_P69ItemPassiveUniqueRing013 { get; } // 484301
		ISnoPower Generic_P69ItemPassiveUniqueRing014 { get; } // 484302
		ISnoPower Generic_P69ItemPassiveUniqueRing015 { get; } // 484303
		ISnoPower Generic_P69ItemPassiveUniqueRing100 { get; } // 484342
		ISnoPower Generic_P69ItemPassiveUniqueRing101 { get; } // 484343
		ISnoPower Generic_P69ItemPassiveUniqueRing102 { get; } // 484356
		ISnoPower Generic_P69ItemPassiveUniqueRing103 { get; } // 484418
		ISnoPower Generic_P69ItemPassiveUniqueRing104 { get; } // 484425
		ISnoPower Generic_p6CrowHoundProjectile { get; } // 470770
		ISnoPower Generic_P6EnvyBossLookSwitch { get; } // 470267
		ISnoPower Generic_P6EnvyBossMirrorPortBuff { get; } // 470530
		ISnoPower Generic_P6EnvyBossMirrorPortBuffRemove { get; } // 470543
		ISnoPower Generic_P6EnvyBossRangedPortBuff { get; } // 470531
		ISnoPower Generic_P6EnvyDMGReduction { get; } // 474684
		ISnoPower Generic_P6ItemPassiveUniqueRing001 { get; } // 467463
		ISnoPower Generic_P6ItemPassiveUniqueRing002 { get; } // 467464
		ISnoPower Generic_P6ItemPassiveUniqueRing003 { get; } // 467465
		ISnoPower Generic_P6ItemPassiveUniqueRing004 { get; } // 472266
		ISnoPower Generic_P6ItemPassiveUniqueRing005 { get; } // 472267
		ISnoPower Generic_P6ItemPassiveUniqueRing006 { get; } // 472268
		ISnoPower Generic_P6ItemPassiveUniqueRing007 { get; } // 472269
		ISnoPower Generic_P6ItemPassiveUniqueRing008 { get; } // 472270
		ISnoPower Generic_P6ItemPassiveUniqueRing009 { get; } // 472271
		ISnoPower Generic_P6ItemPassiveUniqueRing010 { get; } // 472272
		ISnoPower Generic_P6ItemPassiveUniqueRing011 { get; } // 472273
		ISnoPower Generic_P6ItemPassiveUniqueRing012 { get; } // 472274
		ISnoPower Generic_P6ItemPassiveUniqueRing013 { get; } // 472668
		ISnoPower Generic_P6ItemPassiveUniqueRing014 { get; } // 472669
		ISnoPower Generic_P6ItemPassiveUniqueRing015 { get; } // 472670
		ISnoPower Generic_P6ItemPassiveUniqueRing016 { get; } // 472671
		ISnoPower Generic_P6ItemPassiveUniqueRing017 { get; } // 472672
		ISnoPower Generic_P6ItemPassiveUniqueRing018 { get; } // 472673
		ISnoPower Generic_P6ItemPassiveUniqueRing019 { get; } // 472674
		ISnoPower Generic_P6ItemPassiveUniqueRing020 { get; } // 472675
		ISnoPower Generic_P6ItemPassiveUniqueRing021 { get; } // 472676
		ISnoPower Generic_P6ItemPassiveUniqueRing022 { get; } // 472677
		ISnoPower Generic_P6ItemPassiveUniqueRing023 { get; } // 472678
		ISnoPower Generic_P6ItemPassiveUniqueRing024 { get; } // 472679
		ISnoPower Generic_P6ItemPassiveUniqueRing025 { get; } // 472693
		ISnoPower Generic_P6ItemPassiveUniqueRing026 { get; } // 472694
		ISnoPower Generic_P6ItemPassiveUniqueRing027 { get; } // 472695
		ISnoPower Generic_P6ItemPassiveUniqueRing028 { get; } // 472697
		ISnoPower Generic_P6ItemPassiveUniqueRing029 { get; } // 472698
		ISnoPower Generic_P6ItemPassiveUniqueRing030 { get; } // 472699
		ISnoPower Generic_P6ItemPassiveUniqueRing031 { get; } // 472700
		ISnoPower Generic_P6ItemPassiveUniqueRing032 { get; } // 472701
		ISnoPower Generic_P6ItemPassiveUniqueRing033 { get; } // 472702
		ISnoPower Generic_P6ItemPassiveUniqueRing034 { get; } // 472703
		ISnoPower Generic_P6ItemPassiveUniqueRing035 { get; } // 472704
		ISnoPower Generic_P6ItemPassiveUniqueRing036 { get; } // 472705
		ISnoPower Generic_P6ItemPassiveUniqueRing038 { get; } // 475242
		ISnoPower Generic_P6ItemPassiveUniqueRing044 { get; } // 475248
		ISnoPower Generic_P6ItemPassiveUniqueRing045 { get; } // 475249
		ISnoPower Generic_P6ItemPassiveUniqueRing051 { get; } // 476047
		ISnoPower Generic_P6ItemPassiveUniqueRing052 { get; } // 476048
		ISnoPower Generic_P6ItemPassiveUniqueRing053 { get; } // 476049
		ISnoPower Generic_P6ItemPassiveUniqueRing054 { get; } // 476050
		ISnoPower Generic_P6ItemPassiveUniqueRing055 { get; } // 476051
		ISnoPower Generic_P6ItemPassiveUniqueRing056 { get; } // 476052
		ISnoPower Generic_P6ItemPassiveUniqueRing057 { get; } // 476578
		ISnoPower Generic_P6ItemPassiveUniqueRing061 { get; } // 476582
		ISnoPower Generic_P6ItemPassiveUniqueRing067 { get; } // 476588
		ISnoPower Generic_P6ItemPassiveUniqueRing069 { get; } // 476590
		ISnoPower Generic_P6ItemPassiveUniqueRing072 { get; } // 476689
		ISnoPower Generic_P6ItemPassiveUniqueRing073 { get; } // 476695
		ISnoPower Generic_P6NecroBoneSpikesInversePassability { get; } // 472587
		ISnoPower Generic_P6NecroBoneSpiritPassive { get; } // 464999
		ISnoPower Generic_P6NecroDevourAura { get; } // 474325
		ISnoPower Generic_P6NecroFrailtyAura { get; } // 473992
		ISnoPower Generic_P6NecroGenericCorpseTargeting { get; } // 454137
		ISnoPower Generic_P6NecroGolemMelee { get; } // 451561
		ISnoPower Generic_P6NecroRaiseDeadDDecayAura { get; } // 471359
		ISnoPower Generic_P6NecroRaiseDeadDDecayAuraSpawn { get; } // 474371
		ISnoPower Generic_P6NecroRaiseDeadEArcherAttack { get; } // 471374
		ISnoPower Generic_P6NecroRaiseDeadEArcherSpawnAttack { get; } // 472995
		ISnoPower Generic_P6NecroRaiseDeadMageSpawnAttack { get; } // 457769
		ISnoPower Generic_P6NecroRaiseDeadMageSpawnAttackNoTarget { get; } // 464530
		ISnoPower Generic_p6NecroRaiseGolemBloodGolemVeinAoE { get; } // 463797
		ISnoPower Generic_P6NecroRaiseGolemBoneGolemTornado { get; } // 465257
		ISnoPower Generic_P6NecroRaiseGolemConsumeGolemEatCorpses { get; } // 471615
		ISnoPower Generic_p6NecroRaiseGolemDestroyBreakables { get; } // 478216
		ISnoPower Generic_P6NecroRaiseGolemFleshGolemDropCorpses { get; } // 466862
		ISnoPower Generic_P6NecroRaiseGolemIceGolemFreeze { get; } // 471655
		ISnoPower Generic_P6NecroRaiseSkeletonsChargeAttack { get; } // 456302
		ISnoPower Generic_p6NecroReviveAngelCorruptPiercingDash { get; } // 469983
		ISnoPower Generic_p6NecroRevivearmorScavengerbuff { get; } // 476778
		ISnoPower Generic_p6NecroReviveBeastCharge { get; } // 470882
		ISnoPower Generic_p6NecroReviveBigRedCharge { get; } // 467631
		ISnoPower Generic_p6NecroReviveBogFamilyRangedRapidShot { get; } // 477233
		ISnoPower Generic_p6NecroReviveBrickhouseSlam { get; } // 470952
		ISnoPower Generic_p6NecroReviveCorpulentExplode { get; } // 470990
		ISnoPower Generic_p6NecroReviveCrowHoundProjectile { get; } // 476425
		ISnoPower Generic_p6NecroReviveDarkAngelSoulRush { get; } // 476335
		ISnoPower Generic_p6NecroRevivedeathMaidenSpinAttack { get; } // 476485
		ISnoPower Generic_p6NecroReviveDemonFlyerProjectile { get; } // 471091
		ISnoPower Generic_p6NecroReviveDervishWhirlwind { get; } // 471147
		ISnoPower Generic_p6NecroReviveFallenShamanProjectile { get; } // 463173
		ISnoPower Generic_p6NecroReviveFastMummyDiseaseCloud { get; } // 471173
		ISnoPower Generic_p6NecroReviveFloaterAngelProjectile { get; } // 477406
		ISnoPower Generic_p6NecroReviveGoatmanRangedProjectile { get; } // 471863
		ISnoPower Generic_p6NecroReviveGoatmanShamanLightningbolt { get; } // 471809
		ISnoPower Generic_P6NecroReviveGoatMutantRangedProjectile { get; } // 471972
		ISnoPower Generic_P6NecroReviveGoatMutantShamanBlast { get; } // 471982
		ISnoPower Generic_p6NecroReviveHoodedNightmareProjectile { get; } // 467625
		ISnoPower Generic_P6NecroReviveIcePorcupineShot { get; } // 474749
		ISnoPower Generic_p6NecroReviveLacuniLeap { get; } // 472055
		ISnoPower Generic_p6NecroReviveLacuniMaleDoubleSwing { get; } // 472112
		ISnoPower Generic_p6NecroReviveLeaperAngelLeap { get; } // 474096
		ISnoPower Generic_P6NecroReviveMelee { get; } // 474930
		ISnoPower Generic_p6NecroReviveMermaidRangedProjectile { get; } // 475304
		ISnoPower Generic_p6NecroReviveMoleMutantRangedProjectile { get; } // 475462
		ISnoPower Generic_p6NecroReviveMoleMutantShamanProjectile { get; } // 475495
		ISnoPower Generic_p6NecroReviveMorluSpellcasterBreathOfFire { get; } // 462969
		ISnoPower Generic_p6NecroReviveNightScreamerProjectile { get; } // 477454
		ISnoPower Generic_p6NecroRevivepandExtRanged { get; } // 476314
		ISnoPower Generic_p6NecroRevivePortalGuardianMinionprojectile { get; } // 477336
		ISnoPower Generic_p6NecroReviveQuillDemonProjectile { get; } // 476524
		ISnoPower Generic_p6NecroReviverockwormprojectile { get; } // 477004
		ISnoPower Generic_p6NecroReviveSandWaspProjectile { get; } // 475916
		ISnoPower Generic_p6NecroReviveScorpionBugHoverProjectile { get; } // 476109
		ISnoPower Generic_p6NecroReviveShepherdProjectile { get; } // 476699
		ISnoPower Generic_p6NecroReviveSkeletonArcherProjectile { get; } // 466508
		ISnoPower Generic_p6NecroReviveskeletonMageProjectile { get; } // 466879
		ISnoPower Generic_p6NecroReviveSkeletonSummonerProjectile { get; } // 466524
		ISnoPower Generic_p6NecroReviveSniperAngelcloseRangedAttack { get; } // 477433
		ISnoPower Generic_p6NecroReviveSuccubusBloodStar { get; } // 476353
		ISnoPower Generic_p6NecroReviveTempleCultistCasterProjectile { get; } // 476710
		ISnoPower Generic_p6NecroReviveTempleCultistSuicide { get; } // 476715
		ISnoPower Generic_p6NecroReviveThousandPounderKnockback { get; } // 470477
		ISnoPower Generic_p6NecroReviveTriuneSummonerProjectile { get; } // 467271
		ISnoPower Generic_p6NecroReviveUnburiedKnockback { get; } // 474825
		ISnoPower Generic_p6NecroReviveWerewolfMelee { get; } // 476685
		ISnoPower Generic_p6NecroReviveWestmarchBruteBDecapitateSlide { get; } // 470970
		ISnoPower Generic_p6NecroReviveWestmarchBruteCharge { get; } // 477779
		ISnoPower Generic_p6NecroReviveWestmarchHoundTaunt { get; } // 477578
		ISnoPower Generic_p6NecroReviveWestmarchHoundTauntSearch { get; } // 477579
		ISnoPower Generic_p6NecroRevivewestmarchRangedProjectile { get; } // 476848
		ISnoPower Generic_P6NecroReviveWraithMelee { get; } // 476925
		ISnoPower Generic_p6NecroReviveZombieFemaleProjectile { get; } // 466256
		ISnoPower Generic_P6NecroSimulacrumWeaponMeleeInstant { get; } // 475334
		ISnoPower Generic_P6NecroSkeletalWarriorMelee { get; } // 455151
		ISnoPower Generic_P6NecroSkeletalWarriorUberMelee { get; } // 457832
		ISnoPower Generic_P6NecroSkeletonMageFireProjectile { get; } // 451557
		ISnoPower Generic_P6NecroTraitGolemSpawner { get; } // 460062
		ISnoPower Generic_P6NecroTraitSkeletonSpawner { get; } // 453793
		ISnoPower Generic_p6RavenFlyerJumpBackAttack { get; } // 467137
		ISnoPower Generic_p6RavenFlyerPathingBuff { get; } // 469618
		ISnoPower Generic_p6SetDungDeathNecroBlood { get; } // 468592
		ISnoPower Generic_p6SetDungDeathNecroBone { get; } // 468593
		ISnoPower Generic_p6SetDungDeathNecroPlague { get; } // 468594
		ISnoPower Generic_p6SetDungDeathNecroSaint { get; } // 468595
		ISnoPower Generic_p6SetDungNecroBloodEnmy { get; } // 468596
		ISnoPower Generic_p6SetDungNecroBloodPly { get; } // 468597
		ISnoPower Generic_p6SetDungNecroBoneEnmy { get; } // 468598
		ISnoPower Generic_p6SetDungNecroBonePly { get; } // 468599
		ISnoPower Generic_p6SetDungNecroPlagueEnmy { get; } // 468600
		ISnoPower Generic_p6SetDungNecroPlaguePly { get; } // 468601
		ISnoPower Generic_p6SetDungNecroSaintEnmy { get; } // 468602
		ISnoPower Generic_p6SetDungNecroSaintPly { get; } // 468603
		ISnoPower Generic_p6SetDungPedestalNecroBlood { get; } // 468604
		ISnoPower Generic_p6SetDungPedestalNecroBone { get; } // 468605
		ISnoPower Generic_p6SetDungPedestalNecroPlague { get; } // 468606
		ISnoPower Generic_p6SetDungPedestalNecroSaint { get; } // 468607
		ISnoPower Generic_P6ShepherdBossTeleportOutro { get; } // 469966
		ISnoPower Generic_p6ShepherdRangedAttack { get; } // 461453
		ISnoPower Generic_p6ShepherdRangedAttackBoss { get; } // 472850
		ISnoPower Generic_p6ShepherdRangedAttackBossTransformed { get; } // 476611
		ISnoPower Generic_p6ShepherdRangedAttackNodmg { get; } // 469818
		ISnoPower Generic_P6ShepherdSpawnBossOutro { get; } // 477974
		ISnoPower Generic_P6ShepherdSpawnIntro { get; } // 476218
		ISnoPower Generic_P6ShepherdSpawnOutro { get; } // 476233
		ISnoPower Generic_P6ShepherdTeleportIntro { get; } // 462770
		ISnoPower Generic_P6ShepherdTeleportIntroMirror { get; } // 473826
		ISnoPower Generic_P6ShepherdTeleportOutro { get; } // 462771
		ISnoPower Generic_p6TempleCultistLobbedShot { get; } // 465139
		ISnoPower Generic_p6TempleCultistSuicide { get; } // 465143
		ISnoPower Generic_p6TempleMonstrosityGrenadeVolley { get; } // 471378
		ISnoPower Generic_p6TempleMonstrosityMeleeLance { get; } // 471326
		ISnoPower Generic_P6WerewolfClawRush { get; } // 464675
		ISnoPower Generic_P6WerewolfHowl { get; } // 464614
		ISnoPower Generic_P6WerewolfJumpBack { get; } // 464670
		ISnoPower Generic_P6WerewolfLeap { get; } // 464027
		ISnoPower Generic_P6WerewolfLeapFire { get; } // 470440
		ISnoPower Generic_P6WerewolfMelee { get; } // 464583
		ISnoPower Generic_P6WerewolfMeleeFire { get; } // 465394
		ISnoPower Generic_P71ItemPassiveEthereal001 { get; } // 485635
		ISnoPower Generic_P71ItemPassiveEthereal002 { get; } // 485653
		ISnoPower Generic_P71ItemPassiveEthereal003 { get; } // 485637
		ISnoPower Generic_P71ItemPassiveEthereal004 { get; } // 485646
		ISnoPower Generic_P71ItemPassiveEthereal005 { get; } // 485649
		ISnoPower Generic_P71ItemPassiveEthereal006 { get; } // 485654
		ISnoPower Generic_P71ItemPassiveEthereal007 { get; } // 485655
		ISnoPower Generic_P71ItemPassiveEthereal008 { get; } // 485656
		ISnoPower Generic_P71ItemPassiveEthereal009 { get; } // 485702
		ISnoPower Generic_P71ItemPassiveEthereal010 { get; } // 485706
		ISnoPower Generic_P71ItemPassiveEthereal011 { get; } // 485707
		ISnoPower Generic_P71ItemPassiveEthereal012 { get; } // 485708
		ISnoPower Generic_P71ItemPassiveEthereal013 { get; } // 485712
		ISnoPower Generic_P71ItemPassiveEthereal014 { get; } // 485713
		ISnoPower Generic_P71ItemPassiveEthereal015 { get; } // 485714
		ISnoPower Generic_P71ItemPassiveEthereal016 { get; } // 485715
		ISnoPower Generic_P71ItemPassiveEthereal017 { get; } // 485716
		ISnoPower Generic_P71ItemPassiveEthereal018 { get; } // 485717
		ISnoPower Generic_P71ItemPassiveEthereal019 { get; } // 485718
		ISnoPower Generic_P71ItemPassiveEthereal020 { get; } // 486067
		ISnoPower Generic_P71ItemPassiveEthereal021 { get; } // 486068
		ISnoPower Generic_P71ItemPassiveEthereal022 { get; } // 486069
		ISnoPower Generic_P71ItemPassiveEthereal023 { get; } // 486070
		ISnoPower Generic_P71ItemPassiveEthereal024 { get; } // 486071
		ISnoPower Generic_P71ItemPassiveEthereal025 { get; } // 486072
		ISnoPower Generic_P71ItemPassiveUniqueRing001 { get; } // 485711
		ISnoPower Generic_P72ItemPassiveSoulshard002 { get; } // 486127
		ISnoPower Generic_P72ItemPassiveSoulshard003 { get; } // 486128
		ISnoPower Generic_P72ItemPassiveSoulshard004 { get; } // 486130
		ISnoPower Generic_P72ItemPassiveSoulshard006 { get; } // 486174
		ISnoPower Generic_P72ItemPassiveSoulshard007 { get; } // 486175
		ISnoPower Generic_P72ItemPassiveSoulshard008 { get; } // 486219
		ISnoPower Generic_P72ItemPassiveSoulshard010 { get; } // 486179
		ISnoPower Generic_P72ItemPassiveSoulshard011 { get; } // 486180
		ISnoPower Generic_P72ItemPassiveSoulshard012 { get; } // 486181
		ISnoPower Generic_P72ItemPassiveSoulshard014 { get; } // 486185
		ISnoPower Generic_P72ItemPassiveSoulshard015 { get; } // 486186
		ISnoPower Generic_P72ItemPassiveSoulshard016 { get; } // 486187
		ISnoPower Generic_P72ItemPassiveSoulshard018 { get; } // 486199
		ISnoPower Generic_P72ItemPassiveSoulshard019 { get; } // 486200
		ISnoPower Generic_P72ItemPassiveSoulshard020 { get; } // 486201
		ISnoPower Generic_P72ItemPassiveSoulshard022 { get; } // 486214
		ISnoPower Generic_P72ItemPassiveSoulshard023 { get; } // 486215
		ISnoPower Generic_P72ItemPassiveSoulshard024 { get; } // 486216
		ISnoPower Generic_P72ItemPassiveSoulshard026 { get; } // 486210
		ISnoPower Generic_P72ItemPassiveSoulshard027 { get; } // 486211
		ISnoPower Generic_P72ItemPassiveSoulshard028 { get; } // 486212
		ISnoPower Generic_P72ItemPassiveSoulshard029 { get; } // 486252
		ISnoPower Generic_P72ItemPassiveUniqueRing005 { get; } // 486176
		ISnoPower Generic_P72ItemPassiveUniqueRing006 { get; } // 486177
		ISnoPower Generic_P73ExplodingLunaticSuicide { get; } // 487504
		ISnoPower Generic_P73ItemPassiveUniqueRing003 { get; } // 486961
		ISnoPower Generic_P73PagesBuffDamageSwarmRift { get; } // 486865
		ISnoPower Generic_P73PagesBuffElectrifiedCastSwarmRift { get; } // 486863
		ISnoPower Generic_P73PagesBuffRunSpeed { get; } // 487614
		ISnoPower Generic_P73PagesBuffRunSpeedKnockbackCast { get; } // 487615
		ISnoPower Generic_P73PagesBuffRunSpeedWallerCast { get; } // 487617
		ISnoPower Generic_P73PagesBuffRunSpeedWallerCastUpgrade { get; } // 487616
		ISnoPower Generic_P73ShrineDesecratedtreasureGoblin { get; } // 487311
		ISnoPower Generic_P73SwarmRiftCloneDeathExplosionAffix { get; } // 486918
		ISnoPower Generic_P73SwarmRiftGreenMeteors { get; } // 487303
		ISnoPower Generic_P73SwarmRiftLunaticMolten { get; } // 487503
		ISnoPower Generic_P73SwarmRiftPagesBuffElectrifiedTieredRift { get; } // 486873
		ISnoPower Generic_P73SwarmRiftPagesBuffInfiniteCasting { get; } // 486868
		ISnoPower Generic_p73SwarmRiftSummon { get; } // 487273
		ISnoPower Generic_P74GargantuanWormwoodSeasonTheme { get; } // 487795
		ISnoPower Generic_P74ItemPassiveSeasonTheme001 { get; } // 487688
		ISnoPower Generic_P74ItemPassiveSeasonTheme002 { get; } // 487689
		ISnoPower Generic_P74ItemPassiveSeasonTheme003 { get; } // 487690
		ISnoPower Generic_P74ItemPassiveSeasonTheme004 { get; } // 487691
		ISnoPower Generic_P74ItemPassiveSeasonTheme005 { get; } // 487692
		ISnoPower Generic_P74ItemPassiveSeasonTheme006 { get; } // 487693
		ISnoPower Generic_P74ItemPassiveSeasonTheme007 { get; } // 487694
		ISnoPower Generic_P74ItemPassiveSeasonTheme008 { get; } // 487695
		ISnoPower Generic_P74ItemPassiveSeasonTheme009 { get; } // 487696
		ISnoPower Generic_P74ItemPassiveSeasonTheme010 { get; } // 487708
		ISnoPower Generic_P74ItemPassiveSeasonTheme011 { get; } // 487710
		ISnoPower Generic_P74ItemPassiveSeasonTheme012 { get; } // 487712
		ISnoPower Generic_P74ItemPassiveSeasonTheme013 { get; } // 487725
		ISnoPower Generic_P74ItemPassiveSeasonTheme014 { get; } // 487781
		ISnoPower Generic_P74ItemPassiveSeasonTheme015 { get; } // 487787
		ISnoPower Generic_P74ItemPassiveSeasonTheme016 { get; } // 487789
		ISnoPower Generic_P74ItemPassiveSeasonTheme017 { get; } // 487790
		ISnoPower Generic_P74ItemPassiveSeasonTheme018 { get; } // 487794
		ISnoPower Generic_P74ItemPassiveSeasonTheme019 { get; } // 487800
		ISnoPower Generic_P74ItemPassiveSeasonTheme020 { get; } // 487820
		ISnoPower Generic_P74ItemPassiveSeasonTheme021 { get; } // 487821
		ISnoPower Generic_P74ItemPassiveUniqueRing004 { get; } // 487654
		ISnoPower Generic_P74ItemPassiveUniqueRing006 { get; } // 487687
		ISnoPower Generic_P74ItemPassiveUniqueRing007 { get; } // 487706
		ISnoPower Generic_P74ItemPassiveUniqueRing009 { get; } // 487788
		ISnoPower Generic_P74ItemPassiveUniqueRing012 { get; } // 487799
		ISnoPower Generic_P74ItemPassiveUniqueRing014 { get; } // 487929
		ISnoPower Generic_P74ItemPassiveUniqueRing016 { get; } // 488102
		ISnoPower Generic_P74NecroGolemDevourAura { get; } // 487646
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor001 { get; } // 488004
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor002 { get; } // 488036
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor003 { get; } // 488037
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor004 { get; } // 488038
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor001 { get; } // 488006
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor002 { get; } // 488011
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor003 { get; } // 488012
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor004 { get; } // 488013
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor005 { get; } // 488014
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor006 { get; } // 488015
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor007 { get; } // 488016
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor008 { get; } // 488017
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor009 { get; } // 488018
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor010 { get; } // 488019
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor011 { get; } // 488020
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor012 { get; } // 488021
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor013 { get; } // 488022
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor014 { get; } // 488023
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor015 { get; } // 488024
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor016 { get; } // 488025
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor017 { get; } // 488026
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor018 { get; } // 488027
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor018AIPetPickup { get; } // 488085
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor019 { get; } // 488028
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor020 { get; } // 488029
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor021 { get; } // 488030
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor021AIPetPickup { get; } // 488086
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor022 { get; } // 488031
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor023 { get; } // 488032
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor024 { get; } // 488033
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor025 { get; } // 488034
		ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor026 { get; } // 488035
		ISnoPower Generic_P75ItemPassiveDarkAlchemySeal001 { get; } // 488136
		ISnoPower Generic_P75ItemPassiveUniqueRing001 { get; } // 488007
		ISnoPower Generic_P75ItemPassiveUniqueRing006 { get; } // 488040
		ISnoPower Generic_P75PagesBuffDamageDarkAlchemy { get; } // 488072
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Alcarnus { get; } // 488780
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76BloodPit { get; } // 488694
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Bog { get; } // 488881
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Boneyard { get; } // 488737
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Church { get; } // 488779
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76ForestTower { get; } // 488803
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76GideonsCourt { get; } // 488883
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76GravyardAct1 { get; } // 488682
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Hell { get; } // 488882
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76MoorsSacrifice { get; } // 488723
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76NewTristram { get; } // 488542
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76OldTristram { get; } // 488543
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76PandBatteringRam { get; } // 488886
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Sescheron { get; } // 488804
		ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Spire { get; } // 488884
		ISnoPower Generic_P76ItemPassiveSpawnChest001 { get; } // 488557
		ISnoPower Generic_P7ItemPassiveUniqueRing001 { get; } // 485318
		ISnoPower Generic_P7ItemPassiveUniqueRing002 { get; } // 485549
		ISnoPower Generic_P7ItemPassiveUniqueRing003 { get; } // 485333
		ISnoPower Generic_PagesBuffDamage { get; } // 262935
		ISnoPower Generic_PagesBuffElectrified { get; } // 263029
		ISnoPower Generic_PagesBuffElectrifiedCast { get; } // 340227
		ISnoPower Generic_PagesBuffElectrifiedCastTieredRift { get; } // 398655
		ISnoPower Generic_PagesBuffElectrifiedTieredRift { get; } // 403404
		ISnoPower Generic_PagesBuffInfiniteCasting { get; } // 266258
		ISnoPower Generic_PagesBuffInvulnerable { get; } // 266254
		ISnoPower Generic_PagesBuffInvulnerableCastv2 { get; } // 428595
		ISnoPower Generic_PagesBuffRunSpeed { get; } // 266271
		ISnoPower Generic_PagesBuffRunSpeedKnockbackCast { get; } // 428605
		ISnoPower Generic_PagesBuffRunSpeedWallerCast { get; } // 428607
		ISnoPower Generic_PagesBuffRunSpeedWallerCastUpgrade { get; } // 483646
		ISnoPower Generic_PandemoniumPortal { get; } // 257036
		ISnoPower Generic_PandemoniumPortalDiablo { get; } // 366954
		ISnoPower Generic_PandemoniumPortalghom { get; } // 366951
		ISnoPower Generic_PandemoniumPortalSiegeBreaker { get; } // 366953
		ISnoPower Generic_PandemoniumPortalSkeletonKing { get; } // 366950
		ISnoPower Generic_PassiveChallengeRift { get; } // 460197
		ISnoPower Generic_PassiveSetDungeon { get; } // 474206
		ISnoPower Generic_PickupNearby { get; } // 131976
		ISnoPower Generic_PlagueOfToadsKnockback { get; } // 147876
		ISnoPower Generic_PlayerUpscaledBuff { get; } // 375617
		ISnoPower Generic_ProxyDelayedPower { get; } // 30385
		ISnoPower Generic_Punch { get; } // 30391
		ISnoPower Generic_PVPBuff { get; } // 97359
		ISnoPower Generic_PVPcontrolpoint { get; } // 265723
		ISnoPower Generic_PvPDamageBuff { get; } // 202701
		ISnoPower Generic_PvPDeathstreakBuff { get; } // 203535
		ISnoPower Generic_PvPHealingMacguffin { get; } // 222243
		ISnoPower Generic_PVPhill { get; } // 267462
		ISnoPower Generic_PvPHunterBuff { get; } // 404985
		ISnoPower Generic_PvPLevelEqualizerBuff { get; } // 234527
		ISnoPower Generic_PVPPeanutNeutralObjective { get; } // 276837
		ISnoPower Generic_PvPRangedProjectile { get; } // 1749
		ISnoPower Generic_PVPRoundEndBuff { get; } // 170408
		ISnoPower Generic_PVPShrineMurderball { get; } // 275730
		ISnoPower Generic_PVPSkirmishBuff { get; } // 96719
		ISnoPower Generic_PVPspawnersetup { get; } // 268588
		ISnoPower Generic_PVPspawnerTowerDefenders { get; } // 272501
		ISnoPower Generic_PVPStationaryattack { get; } // 274304
		ISnoPower Generic_PVPThreeControlSpawnDefenders { get; } // 276805
		ISnoPower Generic_pxBoneyardsCampSnakemanSpawner { get; } // 432968
		ISnoPower Generic_pxbountytestchaosportalssummonChampion { get; } // 430626
		ISnoPower Generic_pxBridgeCampDemonSpawner { get; } // 433224
		ISnoPower Generic_pxCampPortalSpawner { get; } // 434337
		ISnoPower Generic_pxCraterCampDemonSpawner { get; } // 433300
		ISnoPower Generic_pxFesteringWoodsCampGhoulSpawner { get; } // 432385
		ISnoPower Generic_pxGardensOfHopeCampDemonSpawner { get; } // 433137
		ISnoPower Generic_pxGraveyardCampReaperSpawner { get; } // 433338
		ISnoPower Generic_pxHighlandsCampCultistSpawner { get; } // 432262
		ISnoPower Generic_pxLeoricsDungeonCampDemonSpawner { get; } // 434382
		ISnoPower Generic_pxOasisCampSnakemanSpawner { get; } // 432336
		ISnoPower Generic_pxQuestFollowerDamageSetup { get; } // 432327
		ISnoPower Generic_pxRampartsCampDemonSpawner { get; } // 433391
		ISnoPower Generic_pxRuinsFrostKingKanaiWhirlwind { get; } // 436329
		ISnoPower Generic_pxRuinsFrostThreeGuardiansGoatmanLeap { get; } // 434813
		ISnoPower Generic_pxSpiderCavesCampCocoonHumanVictim { get; } // 432781
		ISnoPower Generic_pxSpiderCavesCampSpiderSpawner { get; } // 432782
		ISnoPower Generic_pxSpireCampDemonSpawner { get; } // 433421
		ISnoPower Generic_pxStingingWindsCampCultistSpawner { get; } // 433057
		ISnoPower Generic_pxWestmarchCampReaperSpawner { get; } // 433254
		ISnoPower Generic_pxWildernessCampTemplarSpawner { get; } // 430766
		ISnoPower Generic_QuestCanyonBridgeEnchantressRevealFootsteps { get; } // 103338
		ISnoPower Generic_QuestCanyonBridgePlayerRevealFootsteps { get; } // 103337
		ISnoPower Generic_QuillDemonProjectile { get; } // 107729
		ISnoPower Generic_QuillDemonProjectileFastAttack { get; } // 364571
		ISnoPower Generic_RandomMovespeedScripted { get; } // 367779
		ISnoPower Generic_RangedEscortProjectile { get; } // 30394
		ISnoPower Generic_RatKingLifetimeBuff { get; } // 440699
		ISnoPower Generic_RedWingsBuff { get; } // 317139
		ISnoPower Generic_RemoveBurrowEffect { get; } // 30420
		ISnoPower Generic_ResurrectFallen { get; } // 30422
		ISnoPower Generic_ResurrectionBuff { get; } // 30424
		ISnoPower Generic_RockwormAttack { get; } // 30426
		ISnoPower Generic_RockwormBurrowAndTeleport { get; } // 330606
		ISnoPower Generic_RockwormBurstOut { get; } // 30427
		ISnoPower Generic_RockwormGrab { get; } // 219076
		ISnoPower Generic_RockwormGrabBurstOut { get; } // 230406
		ISnoPower Generic_RockwormHideIdle { get; } // 30428
		ISnoPower Generic_RockwormPreBurst { get; } // 30429
		ISnoPower Generic_RockwormRetreat { get; } // 30430
		ISnoPower Generic_RockwormWeb { get; } // 30431
		ISnoPower Generic_RootTryGrab { get; } // 30433
		ISnoPower Generic_SandMonsterBurrowOut { get; } // 213730
		ISnoPower Generic_SandMonsterBurrowOutLong { get; } // 59308
		ISnoPower Generic_SandMonsterSandWall { get; } // 30438
		ISnoPower Generic_SandmonsterWeaponMeleeInstant { get; } // 223914
		ISnoPower Generic_SandsharkBurrowIn { get; } // 30440
		ISnoPower Generic_SandsharkBurrowOut { get; } // 30441
		ISnoPower Generic_SandTornadoOnSpawn { get; } // 30448
		ISnoPower Generic_SandWaspProjectile { get; } // 30449
		ISnoPower Generic_ScavengerBurrowIn { get; } // 30450
		ISnoPower Generic_ScavengerBurrowOut { get; } // 30451
		ISnoPower Generic_ScavengerLeap { get; } // 1752
		ISnoPower Generic_ScoundrelAnatomy { get; } // 30454
		ISnoPower Generic_ScoundrelBandage { get; } // 30455
		ISnoPower Generic_ScoundrelCheatDeathPassive { get; } // 485531
		ISnoPower Generic_ScoundrelCripplingShot { get; } // 95675
		ISnoPower Generic_ScoundrelDebuffCloud { get; } // 484974
		ISnoPower Generic_ScoundrelHysteria { get; } // 200169
		ISnoPower Generic_ScoundrelPiercingShot { get; } // 485334
		ISnoPower Generic_ScoundrelPowerShot { get; } // 95690
		ISnoPower Generic_ScoundrelRangedProjectile { get; } // 99902
		ISnoPower Generic_ScoundrelRunAway { get; } // 99904
		ISnoPower Generic_ScoundrelVanishV2 { get; } // 485336
		ISnoPower Generic_ScrollBuff { get; } // 30469
		ISnoPower Generic_SeasonThemeBarbarianWhirlwind { get; } // 484654
		ISnoPower Generic_SelectingSkill { get; } // 217340
		ISnoPower Generic_SetItemBonusBuff { get; } // 123014
		ISnoPower Generic_SetModeEscortFollow { get; } // 30471
		ISnoPower Generic_ShieldSkeletonShield { get; } // 30473
		ISnoPower Generic_ShrineCallMonster { get; } // 213187
		ISnoPower Generic_ShrineDesecratedBlessed { get; } // 30476
		ISnoPower Generic_ShrineDesecratedEnlightened { get; } // 30477
		ISnoPower Generic_ShrineDesecratedFortune { get; } // 30478
		ISnoPower Generic_ShrineDesecratedFrenzied { get; } // 30479
		ISnoPower Generic_ShrineDesecratedHoarder { get; } // 260348
		ISnoPower Generic_ShrineDesecratedReloaded { get; } // 260349
		ISnoPower Generic_ShrineDesecratedtreasureGoblin { get; } // 269350
		ISnoPower Generic_ShrinePowerBlessed { get; } // 278268
		ISnoPower Generic_ShrinePowerEnlightened { get; } // 278269
		ISnoPower Generic_ShrinePowerFortune { get; } // 278270
		ISnoPower Generic_ShrinePowerFrenzied { get; } // 278271
		ISnoPower Generic_SidekickStatsBoostBuff { get; } // 377314
		ISnoPower Generic_SidekickWeaponDamageBoostBuff { get; } // 377413
		ISnoPower Generic_SiegebreakerDemonBite { get; } // 30482
		ISnoPower Generic_SiegebreakerDemonCharge { get; } // 30484
		ISnoPower Generic_SiegebreakerDemonChargeNew { get; } // 182586
		ISnoPower Generic_SiegebreakerDemonGrab { get; } // 30487
		ISnoPower Generic_SiegebreakerDemonGrabToBite { get; } // 30488
		ISnoPower Generic_SiegebreakerDemonLookAround { get; } // 1754
		ISnoPower Generic_SiegebreakerDemonMiniCharge { get; } // 30490
		ISnoPower Generic_SiegebreakerDemonPound { get; } // 30491
		ISnoPower Generic_SiegebreakerDemonRoar { get; } // 228688
		ISnoPower Generic_SiegebreakerDemonStomp { get; } // 30492
		ISnoPower Generic_SiegebreakerEnrage { get; } // 240529
		ISnoPower Generic_SiegeBreakerReflectsDamageCast { get; } // 376912
		ISnoPower Generic_SkeletonArcherProjectile { get; } // 30495
		ISnoPower Generic_SkeletonKingCleave { get; } // 30504
		ISnoPower Generic_SkeletonKingSummonSkeleton { get; } // 30496
		ISnoPower Generic_SkeletonKingTeleport { get; } // 79334
		ISnoPower Generic_SkeletonKingTeleportAway { get; } // 81504
		ISnoPower Generic_SkeletonKingWhirlwind { get; } // 73824
		ISnoPower Generic_skeletonMageColdprojectile { get; } // 30497
		ISnoPower Generic_skeletonMageFireAOE { get; } // 30498
		ISnoPower Generic_skeletonMageFireprojectile { get; } // 30499
		ISnoPower Generic_skeletonMageLightningpierce { get; } // 30500
		ISnoPower Generic_skeletonMagepoisondeath { get; } // 30501
		ISnoPower Generic_skeletonMagePoisonpierce { get; } // 30502
		ISnoPower Generic_SkeletonSummonerProjectile { get; } // 30503
		ISnoPower Generic_SkillOverrideStartedOrEnded { get; } // 221275
		ISnoPower Generic_SnakemanCasterElectricBurst { get; } // 30509
		ISnoPower Generic_SnakemanMeleeStealth { get; } // 30512
		ISnoPower Generic_SnakemanMeleeUnstealth { get; } // 30513
		ISnoPower Generic_SoaringAscend { get; } // 69743
		ISnoPower Generic_SoaringDescend { get; } // 54196
		ISnoPower Generic_SoulRipperDespairTongueLash { get; } // 226572
		ISnoPower Generic_SoulRipperTongueLash { get; } // 145822
		ISnoPower Generic_SpiderQueenVomitSpidersCharge { get; } // 151219
		ISnoPower Generic_SpiderQueenVomitSpidersVomit { get; } // 151516
		ISnoPower Generic_SpiderQueenWebSpit { get; } // 151218
		ISnoPower Generic_SpiderSprintThroughObjectsTo { get; } // 137642
		ISnoPower Generic_SpiderWebImmobolize { get; } // 30518
		ISnoPower Generic_SpiderWebSlow { get; } // 76961
		ISnoPower Generic_SpiderWebSlowSpit { get; } // 76951
		ISnoPower Generic_SplashDamageProc { get; } // 376298
		ISnoPower Generic_SporeCloud { get; } // 30525
		ISnoPower Generic_StealthBuff { get; } // 30527
		ISnoPower Generic_StitchExplode { get; } // 30529
		ISnoPower Generic_StitchMeleeAlternate { get; } // 30530
		ISnoPower Generic_StitchPush { get; } // 30531
		ISnoPower Generic_SuccubusBloodStar { get; } // 120874
		ISnoPower Generic_SuccubusBloodStarLR { get; } // 366103
		ISnoPower Generic_SuccubusFly { get; } // 136508
		ISnoPower Generic_SuccubusLeap { get; } // 120875
		ISnoPower Generic_SuicideProc { get; } // 30538
		ISnoPower Generic_SuicideScripted { get; } // 369834
		ISnoPower Generic_Summoned { get; } // 30540
		ISnoPower Generic_SummonFallenAUnique01 { get; } // 166154
		ISnoPower Generic_SummonFallenOnSpawn { get; } // 30541
		ISnoPower Generic_SummoningMachineSummon { get; } // 117580
		ISnoPower Generic_SummonSkeleton { get; } // 30543
		ISnoPower Generic_SummonSkeletonJondar { get; } // 168212
		ISnoPower Generic_SummonSkeletonOnSpawn { get; } // 30545
		ISnoPower Generic_SummonSkeletonOrb { get; } // 30546
		ISnoPower Generic_SummonSkeletonPillar { get; } // 1757
		ISnoPower Generic_SummonTriuneDemon { get; } // 30547
		ISnoPower Generic_SummonZombieCrawler { get; } // 30550
		ISnoPower Generic_SummonZombieVomit { get; } // 94734
		ISnoPower Generic_Swarmdeath { get; } // 128729
		ISnoPower Generic_TarPitSlowOff { get; } // 67110
		ISnoPower Generic_TarPitSlowOn { get; } // 67106
		ISnoPower Generic_TauntedMonsterRangedProjectile { get; } // 212952
		ISnoPower Generic_TauntedWeaponMeleeInstant { get; } // 212953
		ISnoPower Generic_TeleportCheckPathPassability { get; } // 290885
		ISnoPower Generic_TeleportToPlayer { get; } // 318242
		ISnoPower Generic_TeleportToPlayerCast { get; } // 371139
		ISnoPower Generic_TeleportToWaypoint { get; } // 349060
		ISnoPower Generic_TeleportToWaypointCast { get; } // 371141
		ISnoPower Generic_TemplarCheatDeathPassive { get; } // 485532
		ISnoPower Generic_TemplarGuardianV2 { get; } // 485511
		ISnoPower Generic_TemplarHeal110 { get; } // 257640
		ISnoPower Generic_TemplarInspire { get; } // 30356
		ISnoPower Generic_TemplarIntervene { get; } // 93938
		ISnoPower Generic_TemplarInterveneProc { get; } // 94008
		ISnoPower Generic_TemplarIntimidate { get; } // 93901
		ISnoPower Generic_TemplarLoyalty { get; } // 30357
		ISnoPower Generic_TemplarMeleeInstant { get; } // 230239
		ISnoPower Generic_TemplarOnslaught { get; } // 93888
		ISnoPower Generic_TemplarOnslaughtV2 { get; } // 485345
		ISnoPower Generic_TemplarShieldCharge { get; } // 30360
		ISnoPower Generic_TentacleHorseAUnique01Charge { get; } // 209509
		ISnoPower Generic_TerrorDemonMeleeStrike { get; } // 123907
		ISnoPower Generic_TerrorDemonShadowPhase { get; } // 123935
		ISnoPower Generic_TerrorDemonShadowPhaseEnd { get; } // 123964
		ISnoPower Generic_TestSpikeTrapRuins { get; } // 409416
		ISnoPower Generic_Thorns { get; } // 30554
		ISnoPower Generic_ThousandPounderKnockback { get; } // 30557
		ISnoPower Generic_ThousandPounderMelee { get; } // 439350
		ISnoPower Generic_tongueprototype { get; } // 86990
		ISnoPower Generic_TraitBarbarianFury { get; } // 30078
		ISnoPower Generic_TraitMonkSpirit { get; } // 52753
		ISnoPower Generic_TransformToActivatedTriune { get; } // 30563
		ISnoPower Generic_trDunCathWallCollapseDamage { get; } // 186216
		ISnoPower Generic_trDunCathWallCollapseDamageoffset { get; } // 227949
		ISnoPower Generic_TreasureGoblinAnniversaryEscape { get; } // 434749
		ISnoPower Generic_TreasureGoblinAnniversaryThrowPortal { get; } // 434776
		ISnoPower Generic_TreasureGoblinEscape { get; } // 105371
		ISnoPower Generic_TreasureGoblinPause { get; } // 54055
		ISnoPower Generic_TreasureGoblinPlayAlertSound { get; } // 260595
		ISnoPower Generic_TreasureGoblinPortalIn { get; } // 408659
		ISnoPower Generic_TreasureGoblinThrowPortal { get; } // 54836
		ISnoPower Generic_TreasureGoblinThrowPortalBackup { get; } // 432643
		ISnoPower Generic_TreasureGoblinThrowPortalFast { get; } // 105665
		ISnoPower Generic_TreasureGoblinUsePortal { get; } // 54866
		ISnoPower Generic_TriuneBerserkerPowerHit { get; } // 30567
		ISnoPower Generic_TriuneSummonerProjectile { get; } // 30570
		ISnoPower Generic_TriuneSummonerShield { get; } // 30571
		ISnoPower Generic_TriuneSummonerSplitSummonCast { get; } // 30572
		ISnoPower Generic_TriuneVesselCharge { get; } // 30573
		ISnoPower Generic_TriuneVesselOverpower { get; } // 30574
		ISnoPower Generic_trOutLogStackShortDamage { get; } // 186138
		ISnoPower Generic_trOutLogStackTrap { get; } // 100287
		ISnoPower Generic_trouttristramfieldspunjitrapaoe { get; } // 91261
		ISnoPower Generic_trouttristramfieldspunjitrapmirroraoe { get; } // 95387
		ISnoPower Generic_UberDespairMeleeCleave { get; } // 260844
		ISnoPower Generic_UberDespairSummonMinion { get; } // 257950
		ISnoPower Generic_UberDespairSummonMinionDiablo { get; } // 375537
		ISnoPower Generic_UberDespairTeleport { get; } // 260845
		ISnoPower Generic_UberDespairTeleportEnrageDiablo { get; } // 376039
		ISnoPower Generic_UberDespairVolley { get; } // 260847
		ISnoPower Generic_UberDespairVolleyDiablo { get; } // 376056
		ISnoPower Generic_UberDiabloMirrorImage { get; } // 375929
		ISnoPower Generic_UberDiabloStompAndStun { get; } // 365978
		ISnoPower Generic_UberGluttonyBreathAttack { get; } // 260848
		ISnoPower Generic_UberGluttonyGasCloud { get; } // 260849
		ISnoPower Generic_UberGluttonyGasCloudDiablo { get; } // 376396
		ISnoPower Generic_UberGluttonyLoogiespawn { get; } // 257951
		ISnoPower Generic_UberMaghdaMothDust { get; } // 278341
		ISnoPower Generic_UberMaghdaPunish { get; } // 260976
		ISnoPower Generic_UberMaghdaPunishShielded { get; } // 260977
		ISnoPower Generic_UberMaghdaSummonBeserker { get; } // 257952
		ISnoPower Generic_UberMaghdaSummonBeserkerDiablo { get; } // 375493
		ISnoPower Generic_UberSiegebreakerDemonPound { get; } // 259946
		ISnoPower Generic_UberSiegebreakerDemonStomp { get; } // 258635
		ISnoPower Generic_UberSkeletonKingCleave { get; } // 258636
		ISnoPower Generic_UberSkeletonKingSummonSkeleton { get; } // 256110
		ISnoPower Generic_UberSkeletonKingSummonSkeletonDiablo { get; } // 375473
		ISnoPower Generic_UberSkeletonKingWhirlwind { get; } // 258637
		ISnoPower Generic_UberZoltunKulleCollapseCeiling { get; } // 260851
		ISnoPower Generic_UberZoltunKulleEnergyTwister { get; } // 260852
		ISnoPower Generic_UberZoltunKulleFieryBoulder { get; } // 260853
		ISnoPower Generic_UberZoltunKulleSlowTime { get; } // 259947
		ISnoPower Generic_UberZoltunKulleSlowTimeDiablo { get; } // 376043
		ISnoPower Generic_UberZoltunKulleTeleport { get; } // 258638
		ISnoPower Generic_UnburiedBossCleave { get; } // 93715
		ISnoPower Generic_UnburiedKnockback { get; } // 30580
		ISnoPower Generic_UnburiedMeleeAttack { get; } // 30581
		ISnoPower Generic_UnburiedWreckableAttack { get; } // 202344
		ISnoPower Generic_UnholyShield { get; } // 122977
		ISnoPower Generic_UninterruptibleDuringBuff { get; } // 79486
		ISnoPower Generic_UniqueMonsterEarthquakePrototype { get; } // 256059
		ISnoPower Generic_UniqueMonsterGenericAOENova { get; } // 270004
		ISnoPower Generic_UniqueMonsterGenericAOERandomAroundOwner { get; } // 363519
		ISnoPower Generic_UniqueMonsterGenericAOETargeted { get; } // 270040
		ISnoPower Generic_UniqueMonsterGenericProjectile { get; } // 152540
		ISnoPower Generic_UniqueMonsterGenericProjectile2 { get; } // 359684
		ISnoPower Generic_UniqueMonsterGenericProjectileAllPlayers { get; } // 346247
		ISnoPower Generic_UniqueMonsterGenericSummon { get; } // 270043
		ISnoPower Generic_UniqueMonsterGenericSummon2 { get; } // 359685
		ISnoPower Generic_UniqueMonsterIceTrailPassivePrototype { get; } // 260815
		ISnoPower Generic_UniqueMonsterTempestRushPrototype { get; } // 256060
		ISnoPower Generic_UntargetableDuringBuff { get; } // 30582
		ISnoPower Generic_UrzaelStompAndStun { get; } // 361300
		ISnoPower Generic_UseArcaneGlyph { get; } // 165553
		ISnoPower Generic_UseDungeonStone { get; } // 220318
		ISnoPower Generic_UseHealthGlyph { get; } // 30584
		ISnoPower Generic_UseItem { get; } // 1759
		ISnoPower Generic_UseLootRunPortal { get; } // 389049
		ISnoPower Generic_UseLootRunProgressGlyph { get; } // 404128
		ISnoPower Generic_UseManaGlyph { get; } // 30585
		ISnoPower Generic_UseStoneOfRecall { get; } // 191590
		ISnoPower Generic_Walk { get; } // 30588
		ISnoPower Generic_WallMonsterSpawn { get; } // 143063
		ISnoPower Generic_WallMonsterSpawnSiegeBreaker { get; } // 316261
		ISnoPower Generic_Warp { get; } // 30589
		ISnoPower Generic_WarpInMagical { get; } // 132910
		ISnoPower Generic_waterloggedCorpseEelSpawn { get; } // 57931
		ISnoPower Generic_waterloggedCorpsePoisonCloud { get; } // 57028
		ISnoPower Generic_waterTowerAOasiscaOutBreakableDamage { get; } // 396375
		ISnoPower Generic_WeaponMeleeInstant { get; } // 30592
		ISnoPower Generic_WeaponMeleeInstantBothHand { get; } // 30593
		ISnoPower Generic_WeaponMeleeInstantCowKing { get; } // 368212
		ISnoPower Generic_WeaponMeleeInstantFreezeFacing { get; } // 106087
		ISnoPower Generic_WeaponMeleeInstantOffHand { get; } // 30594
		ISnoPower Generic_WeaponMeleeInstantShortEscape { get; } // 263041
		ISnoPower Generic_WeaponMeleeInstantWreckables { get; } // 202345
		ISnoPower Generic_WeaponMeleeNoClose { get; } // 70218
		ISnoPower Generic_WeaponMeleeObstruction { get; } // 30595
		ISnoPower Generic_WeaponMeleeReachInstant { get; } // 30596
		ISnoPower Generic_WeaponMeleeReachInstantFreezeFacing { get; } // 115624
		ISnoPower Generic_WeaponRangedInstant { get; } // 30598
		ISnoPower Generic_WeaponRangedProjectile { get; } // 30599
		ISnoPower Generic_WeaponRangedWand { get; } // 30601
		ISnoPower Generic_WitchdoctorCorpseSpiderLeap { get; } // 107103
		ISnoPower Generic_WitchdoctorFetishArmyHunter { get; } // 119166
		ISnoPower Generic_WitchdoctorFetishArmyMelee { get; } // 226690
		ISnoPower Generic_WitchdoctorFetishArmyPoisonDart { get; } // 429477
		ISnoPower Generic_WitchdoctorFetishArmyShaman { get; } // 118442
		ISnoPower Generic_WitchdoctorFetishSycophantsMelee { get; } // 435275
		ISnoPower Generic_WitchdoctorGargantuanCleave { get; } // 121942
		ISnoPower Generic_WitchdoctorGargantuanPoisonCloud { get; } // 308827
		ISnoPower Generic_WitchdoctorGargantuanSlam { get; } // 121943
		ISnoPower Generic_WitchdoctorGargantuanSmash { get; } // 186851
		ISnoPower Generic_WitchdoctorHexChickenWalk { get; } // 196974
		ISnoPower Generic_WitchdoctorHexExplode { get; } // 188442
		ISnoPower Generic_WitchdoctorHexFetish { get; } // 107301
		ISnoPower Generic_WitchdoctorHexFetishHeal { get; } // 107742
		ISnoPower Generic_WitchdoctorPlagueOfToadsBigToadAttack { get; } // 106592
		ISnoPower Generic_WitchdoctorPlagueOfToadsBigToadTongueSlap { get; } // 220908
		ISnoPower Generic_WitchdoctorSpiritBarrageRuneCAOE { get; } // 186471
		ISnoPower Generic_WitchdoctorZombieDogFireAoE { get; } // 309100
		ISnoPower Generic_WitchdoctorZombieDogMelee { get; } // 226692
		ISnoPower Generic_WitchdoctorZombieDogPoisonDoT { get; } // 310071
		ISnoPower Generic_WizardArcaneTorrentRuneCMine { get; } // 165598
		ISnoPower Generic_WizardEnergyShield { get; } // 30708
		ISnoPower Generic_WizardHydraDefaultFirePrototype { get; } // 77068
		ISnoPower Generic_WizardHydraRuneAcidPrototype { get; } // 77066
		ISnoPower Generic_WizardHydraRuneArcanePrototype { get; } // 77067
		ISnoPower Generic_WizardHydraRuneBigPrototype { get; } // 84030
		ISnoPower Generic_WizardHydraRuneFirePrototype { get; } // 77063
		ISnoPower Generic_WizardHydraRuneFrostPrototype { get; } // 83040
		ISnoPower Generic_WizardHydraRuneLightningPrototype { get; } // 77065
		ISnoPower Generic_WizardMagicMissileCount { get; } // 30745
		ISnoPower Generic_WizardMagicMissileDamage { get; } // 30746
		ISnoPower Generic_WizardMagicMissileSpeed { get; } // 30748
		ISnoPower Generic_WoDFlagBuff { get; } // 375412
		ISnoPower Generic_WoodWraithSummonSpores { get; } // 30800
		ISnoPower Generic_WorldCreatingBuff { get; } // 223604
		ISnoPower Generic_x1abattoirfurnace01 { get; } // 324819
		ISnoPower Generic_x1AbattoirfurnaceSpinner { get; } // 354796
		ISnoPower Generic_x1AbattoirfurnaceSpinnerEvent { get; } // 359960
		ISnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase1 { get; } // 375458
		ISnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase2 { get; } // 375462
		ISnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase3 { get; } // 375499
		ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwise { get; } // 354856
		ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEvent { get; } // 355457
		ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase1 { get; } // 377631
		ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase2 { get; } // 377636
		ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase3 { get; } // 377641
		ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwise { get; } // 354884
		ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwiseEvent { get; } // 355458
		ISnoPower Generic_x1AbattoirfurnaceWall { get; } // 355369
		ISnoPower Generic_x1AdriaArenaFloorPanelFire { get; } // 290708
		ISnoPower Generic_x1AdriaArenaFloorPanelStart { get; } // 298181
		ISnoPower Generic_X1AdriaBossArenaGasOff0 { get; } // 340805
		ISnoPower Generic_X1AdriaBossArenaGasOff1 { get; } // 340806
		ISnoPower Generic_X1AdriaBossArenaGasOn0 { get; } // 340804
		ISnoPower Generic_X1AdriaBossArenaGasOn1 { get; } // 340807
		ISnoPower Generic_x1AdriaCauldronSpawnerActivate { get; } // 330791
		ISnoPower Generic_x1AdriaCauldronSpawnerInitialPoolsBuff { get; } // 358590
		ISnoPower Generic_x1AdriaCauldronSpawnerLifetimeBuff { get; } // 330783
		ISnoPower Generic_x1AdriaCauldronSpawnerRoomPools { get; } // 355825
		ISnoPower Generic_x1AdriaCauldronSpawnerRoomPoolsInner { get; } // 355826
		ISnoPower Generic_x1AdriaCauldronSpawnerRoomPoolsOuter { get; } // 355827
		ISnoPower Generic_x1AdriaDelayedTeleportAttack { get; } // 293152
		ISnoPower Generic_x1AdriaDelayedTeleportCauldronActivate { get; } // 362989
		ISnoPower Generic_x1AdriaDelayedTeleportStart { get; } // 293151
		ISnoPower Generic_x1AdriaJumpBack { get; } // 284247
		ISnoPower Generic_x1AdriaPhaseOneAIState { get; } // 360204
		ISnoPower Generic_x1AdriaPhaseTwoAIState { get; } // 360205
		ISnoPower Generic_x1AdriaScriptedSequence180Turn { get; } // 365720
		ISnoPower Generic_x1AdriaSpitAtPlayer { get; } // 359746
		ISnoPower Generic_x1AdriaWingSweepLeft { get; } // 354328
		ISnoPower Generic_x1AdriaWingSweepRight { get; } // 354340
		ISnoPower Generic_X1armorScavengerAsteroidRain { get; } // 341833
		ISnoPower Generic_x1armorScavengerbuff { get; } // 271621
		ISnoPower Generic_x1armorScavengerBurrowIn { get; } // 273462
		ISnoPower Generic_x1armorScavengerBurrowOut { get; } // 271740
		ISnoPower Generic_x1armorScavengerPreBurrow { get; } // 322380
		ISnoPower Generic_X1AsteroidBasic { get; } // 330593
		ISnoPower Generic_X1AsteroidBasicSmall { get; } // 442208
		ISnoPower Generic_X1AsteroidPool { get; } // 330129
		ISnoPower Generic_X1AsteroidSpawn { get; } // 292865
		ISnoPower Generic_X1BarbarianAvalanchev2Passive { get; } // 353458
		ISnoPower Generic_X1BloodhawkEventBallistaBossFuriousCharge { get; } // 364196
		ISnoPower Generic_x1bogbearTrap { get; } // 237495
		ISnoPower Generic_x1BogBearTrapTrigger { get; } // 376509
		ISnoPower Generic_x1BogBlightBurrowIn { get; } // 276820
		ISnoPower Generic_x1BogBlightBurrowOut { get; } // 276843
		ISnoPower Generic_x1BogBlightPustuleDeath { get; } // 341714
		ISnoPower Generic_x1BogBlightPustuleSpawn { get; } // 234556
		ISnoPower Generic_x1BogBlightPustuleSpawnCon { get; } // 399284
		ISnoPower Generic_x1BogBogWater { get; } // 335458
		ISnoPower Generic_x1BogBogWaterlarge { get; } // 335795
		ISnoPower Generic_x1BogBogWatermedium { get; } // 335789
		ISnoPower Generic_x1BogFamilyBruteCharge { get; } // 238930
		ISnoPower Generic_x1BogFamilyBruteShout { get; } // 239018
		ISnoPower Generic_x1BogFamilyBruteSummonMeleeAction { get; } // 247961
		ISnoPower Generic_x1BogFamilyBruteSummonMeleeActionUnique { get; } // 355511
		ISnoPower Generic_x1BogFamilyBruteThrowDude { get; } // 238965
		ISnoPower Generic_X1BogFamilyGuardTowerSetup { get; } // 339982
		ISnoPower Generic_x1BogFamilyMeleeTransform { get; } // 338049
		ISnoPower Generic_x1BogFamilyRangedBearTrap { get; } // 239743
		ISnoPower Generic_x1BogFamilyRangedBearTrapFromTower { get; } // 340026
		ISnoPower Generic_x1BogFamilyRangedBearTrapFromTowerReturnToFacing { get; } // 340041
		ISnoPower Generic_x1BogFamilyRangedRapidShot { get; } // 336527
		ISnoPower Generic_x1BogFamilyRangedRapidShotFromTower { get; } // 339985
		ISnoPower Generic_x1BogFamilyRangedRapidShotFromTowerReturnToFacing { get; } // 339986
		ISnoPower Generic_X1BogKingOfTheHillLeap { get; } // 288754
		ISnoPower Generic_x1BogPlantexplodeKnockback { get; } // 234539
		ISnoPower Generic_x1CatacombsDoorAonDeath { get; } // 263272
		ISnoPower Generic_x1CatacombsFloorRunesAonDeath { get; } // 267289
		ISnoPower Generic_x1CatacombsSpiritTotemactivate { get; } // 345943
		ISnoPower Generic_x1CesspoolSlimePosionAttack { get; } // 301930
		ISnoPower Generic_x1ChallengeBuffImmuneStun { get; } // 299410
		ISnoPower Generic_X1ChallengeLureSupersizeLure { get; } // 346299
		ISnoPower Generic_x1CrazedAngelArcherFireArrow { get; } // 366438
		ISnoPower Generic_X1CrusaderLawsOfFate { get; } // 290960
		ISnoPower Generic_X1CrusaderLawsOfFatePassive { get; } // 323371
		ISnoPower Generic_X1CrusaderLawsOfHope { get; } // 290912
		ISnoPower Generic_X1CrusaderLawsOfHopePassive { get; } // 323370
		ISnoPower Generic_X1CrusaderLawsOfHopePassive2 { get; } // 342299
		ISnoPower Generic_X1CrusaderLawsOfJustice { get; } // 266722
		ISnoPower Generic_X1CrusaderLawsOfJusticePassive { get; } // 323386
		ISnoPower Generic_X1CrusaderLawsOfJusticePassive2 { get; } // 342286
		ISnoPower Generic_X1CrusaderLawsOfValor { get; } // 290946
		ISnoPower Generic_X1CrusaderLawsOfValorPassive { get; } // 323387
		ISnoPower Generic_X1CrusaderLawsOfValorPassive2 { get; } // 342284
		ISnoPower Generic_x1CrusaderPhalanxArcherRangedProjectile { get; } // 369807
		ISnoPower Generic_X1CrusaderPhalanxBasicMelee { get; } // 375866
		ISnoPower Generic_x1DarkAngelDeath { get; } // 363569
		ISnoPower Generic_x1DarkAngelSoulRush { get; } // 335991
		ISnoPower Generic_x1DarkAngelSummon { get; } // 342349
		ISnoPower Generic_x1deathMaidenPowerSlamLRBoss { get; } // 366275
		ISnoPower Generic_x1deathMaidenPowerSlamPrototype { get; } // 254440
		ISnoPower Generic_x1deathMaidenSpinAttackMortarLRBoss { get; } // 366276
		ISnoPower Generic_x1deathMaidenSpinAttackPrototype { get; } // 253326
		ISnoPower Generic_x1deathMaidenSummonprototype { get; } // 253328
		ISnoPower Generic_x1deathMaidenSummonprototypeextraskeletons { get; } // 369862
		ISnoPower Generic_x1DeathMaidenUniqueFireAbattoirFurnaceFireWreath { get; } // 376562
		ISnoPower Generic_x1DetonateDOTBuffs { get; } // 363984
		ISnoPower Generic_X1DHCompanionBoarIntervene { get; } // 368154
		ISnoPower Generic_x1FloaterAngelLightningBeam { get; } // 340186
		ISnoPower Generic_x1FloaterAngelLightningBeamMalthael { get; } // 359519
		ISnoPower Generic_x1FloaterAngelTeleport { get; } // 340168
		ISnoPower Generic_x1FloaterAngelTransform { get; } // 340083
		ISnoPower Generic_x1FloaterAngelTransformMalthael { get; } // 357811
		ISnoPower Generic_X1FortressBVisuals { get; } // 343407
		ISnoPower Generic_X1FortressJudgeEventSpawnKnockback { get; } // 334740
		ISnoPower Generic_x1FortressPortalSwitch { get; } // 360496
		ISnoPower Generic_X1FortressPortalSwitchCheckMonsters { get; } // 361425
		ISnoPower Generic_X1FortressPortalSwitchTeleportMonster { get; } // 361488
		ISnoPower Generic_x1FortressRotatingDoor { get; } // 330641
		ISnoPower Generic_X1GenericBreakWallsBuff { get; } // 377827
		ISnoPower Generic_x1GhostDarkSoulSiphon { get; } // 346580
		ISnoPower Generic_x1GhostSoulSiphon { get; } // 298686
		ISnoPower Generic_x1GhostSoulSiphonFire { get; } // 346561
		ISnoPower Generic_x1GhostWalkThroughWalls { get; } // 299066
		ISnoPower Generic_x1GreedDeath { get; } // 392702
		ISnoPower Generic_x1GreedDeathAncient { get; } // 483116
		ISnoPower Generic_x1ImperiusCleave { get; } // 293555
		ISnoPower Generic_X1ImperiusEnemyOrNothing { get; } // 345327
		ISnoPower Generic_x1ImperiusLeapSmash { get; } // 293355
		ISnoPower Generic_x1ImperiusWingsBuff { get; } // 378346
		ISnoPower Generic_X1Kylacheer { get; } // 315456
		ISnoPower Generic_X1Kylafalldownanimation { get; } // 315448
		ISnoPower Generic_X1Kylashieldup { get; } // 315450
		ISnoPower Generic_X1LegendaryAIRunToGuaranteedSpider { get; } // 439849
		ISnoPower Generic_X1LegendaryGenericPotionPowerup { get; } // 342078
		ISnoPower Generic_X1LegendaryPotion07 { get; } // 405166
		ISnoPower Generic_X1LifetimeBuffAbsorbNonPlayerDamage { get; } // 327306
		ISnoPower Generic_X1LRBossBigRedIzualFrostNova { get; } // 354164
		ISnoPower Generic_x1LRBossButcherSpears { get; } // 416435
		ISnoPower Generic_x1LRBossDarkAngelSoulRush { get; } // 366520
		ISnoPower Generic_x1LRBossDarkAngelSummon { get; } // 366525
		ISnoPower Generic_x1LRBossDarkAngelWave { get; } // 369463
		ISnoPower Generic_X1LRBossdemonFlyerMegaFireBreath { get; } // 354687
		ISnoPower Generic_X1LRBossExpandingFireRing { get; } // 374236
		ISnoPower Generic_X1LRBossFireNova { get; } // 367112
		ISnoPower Generic_X1LRBossGenericTaunt { get; } // 374471
		ISnoPower Generic_X1LRBossMorluSpellcasterMeteor { get; } // 374569
		ISnoPower Generic_x1LRBossmorluSpellcasterWeaponMeleeInstant { get; } // 428903
		ISnoPower Generic_X1LRBossRatKingBurrowSetup { get; } // 427151
		ISnoPower Generic_X1LRBossRatKingDeadPlayerTaunt { get; } // 428491
		ISnoPower Generic_X1LRBossRatKingDeadPlayerTauntSearch { get; } // 428492
		ISnoPower Generic_X1LRBossRatKingOnDeath { get; } // 427689
		ISnoPower Generic_x1LRBossSandmonsterOnDeath { get; } // 439911
		ISnoPower Generic_x1LRBossSharedCooldown { get; } // 367289
		ISnoPower Generic_X1LRBossSkeletonKingSummonSkeleton { get; } // 373204
		ISnoPower Generic_X1LRBossSkeletonKingWhirlwind { get; } // 375515
		ISnoPower Generic_X1LRBossSkeletonSummonerProjectile { get; } // 359186
		ISnoPower Generic_X1LRBossSkeletonSummonerProjectileB { get; } // 369518
		ISnoPower Generic_X1LRBossSkeletonSummonerProjectileC { get; } // 369519
		ISnoPower Generic_x1LRBossSkeletonSummonerSummoning { get; } // 365266
		ISnoPower Generic_X1LRBossSuccubusFirestorm { get; } // 374493
		ISnoPower Generic_X1LRBossSummonCoreElites { get; } // 445693
		ISnoPower Generic_X1LRCreepMobHerdingAttack { get; } // 429291
		ISnoPower Generic_X1LRCreepMobMultipleArmAttack { get; } // 309921
		ISnoPower Generic_X1LRCreepMobRangedArmLineAttack { get; } // 429077
		ISnoPower Generic_x1MalthaelBaalAIState { get; } // 328714
		ISnoPower Generic_x1MalthaelBaalFesteringAppendageMelee { get; } // 330055
		ISnoPower Generic_x1MalthaelBaalHoarfrost { get; } // 324846
		ISnoPower Generic_x1MalthaelBaalRift { get; } // 330084
		ISnoPower Generic_x1MalthaelBaalSummonFesteringAppendages { get; } // 330063
		ISnoPower Generic_x1MalthaelDeathFogMonsterSetup { get; } // 325140
		ISnoPower Generic_x1MalthaelDiabloAIState { get; } // 328715
		ISnoPower Generic_x1MalthaelDiabloTeleportFireNovaLightning { get; } // 334760
		ISnoPower Generic_X1MalthaelDrainSoul { get; } // 327766
		ISnoPower Generic_x1MalthaelHealthGlobeDropper { get; } // 340819
		ISnoPower Generic_x1MalthaelMephistoAIState { get; } // 328712
		ISnoPower Generic_x1MalthaelMephistoPoisonCloud { get; } // 330366
		ISnoPower Generic_x1MalthaelMephistoSkullMissile { get; } // 323604
		ISnoPower Generic_x1MalthaelMephistoSpawnInvisLightningProxies { get; } // 354617
		ISnoPower Generic_x1MalthaelMephistoSpiralLightningInward { get; } // 358059
		ISnoPower Generic_x1MalthaelMephistoSummonRotatingLightning { get; } // 348226
		ISnoPower Generic_x1MalthaelMephistoTeleportExplodeOrbs { get; } // 347681
		ISnoPower Generic_x1MalthaelOnDeath { get; } // 371010
		ISnoPower Generic_x1MalthaelPhaseOneAIState { get; } // 330358
		ISnoPower Generic_x1MalthaelPhaseThreeAIState { get; } // 367300
		ISnoPower Generic_x1MalthaelPhaseTwoAIState { get; } // 330360
		ISnoPower Generic_X1MalthaelSickleThrowTeleport { get; } // 327847
		ISnoPower Generic_x1MalthaelSpiritDeath { get; } // 360885
		ISnoPower Generic_x1MalthaelSpiritFog { get; } // 362756
		ISnoPower Generic_X1MalthaelSummonDeathFogMonster { get; } // 325184
		ISnoPower Generic_X1MalthaelSummonFloaterAngel { get; } // 354045
		ISnoPower Generic_x1MalthaelSwordShieldStart { get; } // 325648
		ISnoPower Generic_x1MalthaelSwordShieldStop { get; } // 325649
		ISnoPower Generic_x1MoleMutantEnragedCombo { get; } // 350022
		ISnoPower Generic_x1MoleMutantRangedJumpBackShot { get; } // 354881
		ISnoPower Generic_x1MoleMutantRangedProjectile { get; } // 349044
		ISnoPower Generic_x1MoleMutantShamanBlast { get; } // 349528
		ISnoPower Generic_x1MoleMutantShamanResurrect { get; } // 350639
		ISnoPower Generic_X1MonkMysticAllyRuneAExplode { get; } // 363878
		ISnoPower Generic_X1MonkMysticAllyRuneATagForExplosion { get; } // 363876
		ISnoPower Generic_X1MonkMysticAllyv2Passive { get; } // 362118
		ISnoPower Generic_X1MonkMysticAllyv3Passive { get; } // 485709
		ISnoPower Generic_X1MonsterAffixAvengerCorpseBomberRare { get; } // 384623
		ISnoPower Generic_X1MonsterAffixAvengerCorpseBomberRareCast { get; } // 384624
		ISnoPower Generic_X1MonsterAffixAvengerLightningStorm { get; } // 384628
		ISnoPower Generic_X1MonsterAffixAvengerLightningStormCast { get; } // 384630
		ISnoPower Generic_X1MonsterAffixAvengerOrbiter { get; } // 384570
		ISnoPower Generic_X1MonsterAffixAvengerOrbiterCast { get; } // 384571
		ISnoPower Generic_X1MonsterAffixCorpseBomber { get; } // 308319
		ISnoPower Generic_X1MonsterAffixCorpseBomberCast { get; } // 308318
		ISnoPower Generic_X1MonsterAffixCorpseBomberRare { get; } // 309247
		ISnoPower Generic_X1MonsterAffixCorpseBomberRareCast { get; } // 309248
		ISnoPower Generic_X1MonsterAffixLightningStorm { get; } // 328052
		ISnoPower Generic_x1MonsterAffixLightningStormAIClose { get; } // 332756
		ISnoPower Generic_X1MonsterAffixLightningStormCast { get; } // 328053
		ISnoPower Generic_X1MonsterAffixLightningStormChampion { get; } // 349751
		ISnoPower Generic_X1MonsterAffixLightningStormKillSelf { get; } // 349748
		ISnoPower Generic_X1MonsterAffixLightningStormPulse { get; } // 348532
		ISnoPower Generic_X1MonsterAffixLightningStormTagTarget { get; } // 332683
		ISnoPower Generic_X1MonsterAffixOrbiter { get; } // 343528
		ISnoPower Generic_X1MonsterAffixOrbiterCast { get; } // 343527
		ISnoPower Generic_X1MonsterAffixOrbiterChampion { get; } // 345214
		ISnoPower Generic_X1MonsterAffixOrbiterChampionCast { get; } // 345215
		ISnoPower Generic_X1MonsterAffixTeleportMines { get; } // 337106
		ISnoPower Generic_X1MonsterAffixTeleportMinesCast { get; } // 337107
		ISnoPower Generic_X1NegativeHealthGlobeFlash { get; } // 334807
		ISnoPower Generic_x1NightScreamerAllyBiteTransform { get; } // 338025
		ISnoPower Generic_x1NightScreamerCanTransform { get; } // 338114
		ISnoPower Generic_X1NightScreamerFuriousCharge { get; } // 322542
		ISnoPower Generic_x1NightScreamerScreamAttack { get; } // 324956
		ISnoPower Generic_x1NPCWestmarchAldritchCrushingResolve { get; } // 367807
		ISnoPower Generic_x1PandBruteDecapitateSlide { get; } // 329848
		ISnoPower Generic_X1pandemoniumideationtimeStopBuff { get; } // 300679
		ISnoPower Generic_x1PandExtCollapsingPillar { get; } // 322467
		ISnoPower Generic_x1PandExtEventgreatWeaponbossSuckIn { get; } // 360331
		ISnoPower Generic_x1PandExtEventgreatWeaponfireEnergyPulses { get; } // 361400
		ISnoPower Generic_x1PandExtEventgreatWeaponsummonBoss { get; } // 358496
		ISnoPower Generic_x1PandExtEventgreatWeaponsummonMonsters { get; } // 357034
		ISnoPower Generic_x1PandExtideationbaconbeaconOnDeath { get; } // 300721
		ISnoPower Generic_x1PandExtIdeationWarSpawnerAngel { get; } // 301247
		ISnoPower Generic_x1PandExtIdeationWarSpawnerDemon { get; } // 301248
		ISnoPower Generic_x1PandExtImperiusChargetowerschains { get; } // 364483
		ISnoPower Generic_x1PandExtImperiusChargeTowersSetup { get; } // 365313
		ISnoPower Generic_X1PandExtRamKnockback { get; } // 323354
		ISnoPower Generic_x1pandExtRangedPrototype { get; } // 272299
		ISnoPower Generic_x1pandExtRangedPrototypeStrafeLeft { get; } // 323070
		ISnoPower Generic_x1pandExtRangedPrototypeStrafeRight { get; } // 323071
		ISnoPower Generic_X1PandExtTimeTrap { get; } // 347846
		ISnoPower Generic_X1PandFortressOrdnanceChronoField { get; } // 321861
		ISnoPower Generic_X1PandFortressOrdnanceMine { get; } // 321168
		ISnoPower Generic_X1PandFortressOrdnanceShocker { get; } // 321860
		ISnoPower Generic_X1PandHexMazePortalChampSummon { get; } // 347156
		ISnoPower Generic_X1PandIntSplitMonstermerge { get; } // 276351
		ISnoPower Generic_X1PandIntSplitMonstersplit { get; } // 276298
		ISnoPower Generic_x1PandLeaperAngelLeap { get; } // 277005
		ISnoPower Generic_x1PandMazePortalTestPower { get; } // 270752
		ISnoPower Generic_x1PandMazePortalTestPowerBloone { get; } // 374755
		ISnoPower Generic_x1PandMazePortalTestPowerBorgoth { get; } // 374759
		ISnoPower Generic_x1PandMazePortalTestPowerGrotescor { get; } // 374763
		ISnoPower Generic_x1PandMazePortalTestPowerHaziael { get; } // 374767
		ISnoPower Generic_x1PandMazePortalTestPowerMagrethar { get; } // 374771
		ISnoPower Generic_x1PandMazePortalTestPowerSeverag { get; } // 374775
		ISnoPower Generic_x1PandRockwormBurstOut { get; } // 330626
		ISnoPower Generic_x1PandSniperAngelcloseRangedAttack { get; } // 279220
		ISnoPower Generic_x1PandSniperAngelcloseRangedAttackLRBoss { get; } // 375514
		ISnoPower Generic_x1PandSniperAngelrangedAttack { get; } // 274493
		ISnoPower Generic_x1PandSniperAngelrangedAttackLRBoss { get; } // 365321
		ISnoPower Generic_X1PassiveBountyScroll { get; } // 356461
		ISnoPower Generic_X1PassiveBountyScrollBeastDamage { get; } // 375252
		ISnoPower Generic_X1PassiveBountyScrollBossDamage { get; } // 366183
		ISnoPower Generic_X1PassiveBountyScrollDemonDamage { get; } // 375246
		ISnoPower Generic_X1PassiveBountyScrollEliteDamage { get; } // 359128
		ISnoPower Generic_X1PassiveBountyScrollExperience { get; } // 356462
		ISnoPower Generic_X1PassiveBountyScrollLifeRegen { get; } // 377214
		ISnoPower Generic_X1PassiveBountyScrollRunSpeed { get; } // 375263
		ISnoPower Generic_X1PassiveBountyScrollUndeadDamage { get; } // 375248
		ISnoPower Generic_X1PlaguedLacuniMaleSummon { get; } // 357878
		ISnoPower Generic_x1PlaguedLacuniSpecialMelee { get; } // 359826
		ISnoPower Generic_x1portalGuardianMinionprojectile { get; } // 302416
		ISnoPower Generic_x1PortalGuardianTurning { get; } // 334633
		ISnoPower Generic_x1PortalMonsterBurrowIn { get; } // 270783
		ISnoPower Generic_x1PortalMonsterBurrowOut { get; } // 270782
		ISnoPower Generic_x1PortalMonsterLifetimeBuff { get; } // 270784
		ISnoPower Generic_X1PortalMonsterPortalSummon { get; } // 325081
		ISnoPower Generic_X1PortalMonsterRoarSummon { get; } // 330047
		ISnoPower Generic_X1PortalMonsterStomp { get; } // 279029
		ISnoPower Generic_x1PortalMonsterSwipe { get; } // 323805
		ISnoPower Generic_x1RockFodderCharge { get; } // 271815
		ISnoPower Generic_X1RockFodderFuriousCharge { get; } // 322494
		ISnoPower Generic_X1RockFodderFuriousChargeRockHiveQueen { get; } // 371040
		ISnoPower Generic_x1RockFodderTumble { get; } // 327540
		ISnoPower Generic_x1rockwormpandprojectile { get; } // 323210
		ISnoPower Generic_X1SandmonsterpetWeaponMeleeInstant { get; } // 439832
		ISnoPower Generic_X1SandmonsterWeaponMeleeInstant { get; } // 377188
		ISnoPower Generic_x1ScaryEyesBurrowInHidden { get; } // 246451
		ISnoPower Generic_x1ScaryEyesBurrowOut { get; } // 246453
		ISnoPower Generic_x1ScaryEyescharge { get; } // 254946
		ISnoPower Generic_X1ScoundrelMultishot { get; } // 365395
		ISnoPower Generic_X1ScoundrelMultishotPassive { get; } // 366585
		ISnoPower Generic_X1ShardPassiveFakeGlobes { get; } // 333071
		ISnoPower Generic_X1ShardPassiveMinResource { get; } // 333072
		ISnoPower Generic_x1SkeletonArcherFireArrow { get; } // 300136
		ISnoPower Generic_x1SkeletonArcherFireArrowBackpedal { get; } // 313920
		ISnoPower Generic_x1SkeletonStab { get; } // 315052
		ISnoPower Generic_x1SkeletonStrafe { get; } // 314835
		ISnoPower Generic_X1SnitchleyTreasureGoblinEscape { get; } // 375703
		ISnoPower Generic_X1SpectralHoundBuff { get; } // 370348
		ISnoPower Generic_X1SummonVanityPet { get; } // 319739
		ISnoPower Generic_X1tempballistaswitchleap { get; } // 286732
		ISnoPower Generic_x1UberDiabloHellSpikes { get; } // 375439
		ISnoPower Generic_x1UdderLightning { get; } // 338723
		ISnoPower Generic_x1UniqueNPCEnchantressForcefulPush { get; } // 345292
		ISnoPower Generic_x1UniqueNPCEnchantressMassCharm { get; } // 344565
		ISnoPower Generic_x1UniqueNPCEnchantressScorchedEarth { get; } // 345394
		ISnoPower Generic_x1UniqueNPCTemplarHeal { get; } // 344096
		ISnoPower Generic_x1UniqueNPCTemplarOnslaught { get; } // 344099
		ISnoPower Generic_x1UniqueNPCTemplarShieldCharge { get; } // 344098
		ISnoPower Generic_x1UniqueTriuneSummonerProjectile { get; } // 346525
		ISnoPower Generic_x1UrzaelCannonball { get; } // 340870
		ISnoPower Generic_x1UrzaelCannonballBurning { get; } // 347799
		ISnoPower Generic_x1UrzaelCeilingDebris { get; } // 346168
		ISnoPower Generic_x1UrzaelCeilingDebrisBurning { get; } // 347842
		ISnoPower Generic_x1UrzaelFlameSweep { get; } // 292061
		ISnoPower Generic_x1UrzaelLeapKnockback { get; } // 346045
		ISnoPower Generic_x1UrzaelMeleeInstant { get; } // 308295
		ISnoPower Generic_x1UrzaelPhaseOneAIState { get; } // 346028
		ISnoPower Generic_x1UrzaelPhaseTwoAIState { get; } // 346027
		ISnoPower Generic_x1WestmarchBruteBChargeCustomLRBoss { get; } // 364239
		ISnoPower Generic_x1WestmarchBruteBChargeCustomLRBossHulkmode { get; } // 367003
		ISnoPower Generic_x1WestmarchBruteCharge { get; } // 278970
		ISnoPower Generic_x1WestmarchBruteDecapitate { get; } // 278971
		ISnoPower Generic_x1WestmarchBruteVomit { get; } // 278972
		ISnoPower Generic_X1WestmarchHoundDeadPlayerTaunt { get; } // 335450
		ISnoPower Generic_X1WestmarchHoundDeadPlayerTauntSearch { get; } // 335449
		ISnoPower Generic_X1WestmarchHoundShakeTarget { get; } // 335522
		ISnoPower Generic_x1westmarchRangedRangedAttackPrototype { get; } // 289871
		ISnoPower Generic_x1westmarchRangedSlowAreaDenialPrototype { get; } // 289870
		ISnoPower Generic_x1WestmarchRatCharge { get; } // 360845
		ISnoPower Generic_x1WestmarchRatKamikaze { get; } // 360240
		ISnoPower Generic_X1WestmConvert { get; } // 306381
		ISnoPower Generic_X1WestmConvert2 { get; } // 330011
		ISnoPower Generic_X1WestmConvertAoE { get; } // 307341
		ISnoPower Generic_X1WestmConvertDelayedStart2 { get; } // 330009
		ISnoPower Generic_X1WestmConvertDelayedStartFromTarget { get; } // 313957
		ISnoPower Generic_X1WestmConvertScripted { get; } // 328861
		ISnoPower Generic_X1westmdoomedWomanvisual { get; } // 354949
		ISnoPower Generic_x1westmHoistTriggeronDeathPower { get; } // 244759
		ISnoPower Generic_x1westmideationeventRATZNGGOLD { get; } // 285955
		ISnoPower Generic_x1westmSoulSummonerOrbSummonNearTarget { get; } // 319534
		ISnoPower Generic_X1westmSoulsummonersetup { get; } // 301826
		ISnoPower Generic_X1westmSoulSummonerSummon { get; } // 313229
		ISnoPower Generic_X1westmUniqueghostLordshockwave { get; } // 315014
		ISnoPower Generic_x1WickermanAggro { get; } // 247959
		ISnoPower Generic_X1WickerManFireNova { get; } // 348207
		ISnoPower Generic_X1WickerManFirePhantom { get; } // 288538
		ISnoPower Generic_x1WickermanSuicide { get; } // 247960
		ISnoPower Generic_x1WraithChargeClose { get; } // 291711
		ISnoPower Generic_X1WraithMelee { get; } // 265587
		ISnoPower Generic_X1WraithPiercingDash { get; } // 265911
		ISnoPower Generic_X1X1EventSpeedKillChampionSpawner { get; } // 365581
		ISnoPower Generic_X1X1EventSpeedKillSpawner { get; } // 364720
		ISnoPower Generic_x1ZombieFemaleProjectilePoison { get; } // 355496
		ISnoPower Generic_ZKBallSummonSkeleton { get; } // 30804
		ISnoPower Generic_zoltsmallFloorSpawner { get; } // 30808
		ISnoPower Generic_zoltTabletstateChange { get; } // 30810
		ISnoPower Generic_ZoltunKulleCollapseCeiling { get; } // 139705
		ISnoPower Generic_ZoltunKulleEnergyTwister { get; } // 139736
		ISnoPower Generic_ZoltunKulleFieryBoulder { get; } // 139942
		ISnoPower Generic_ZoltunKulleSlowTime { get; } // 139831
		ISnoPower Generic_ZoltunKulleTeleport { get; } // 139711
		ISnoPower Generic_ZoltunKulleTeleportToPlayer { get; } // 241753
		ISnoPower Generic_ZoltunKulleTeleportToPlayerEnrage { get; } // 243289
		ISnoPower Generic_ZombieEatStart { get; } // 178483
		ISnoPower Generic_ZombieEatStop { get; } // 178485
		ISnoPower Generic_ZombieFemaleProjectile { get; } // 110518
		ISnoPower Generic_ZombieKillerGrab { get; } // 1771
    }
}

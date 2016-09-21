﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ARK_Server_Manager.Lib.ViewModel;
using WPFSharp.Globalizer;

namespace ARK_Server_Manager.Lib
{
    [DefaultValue(SurvivalEvolved)]
    public enum ArkApplication
    {
        /// <summary>
        /// All has been added only for filter selection.
        /// </summary>
        All = 0,
        SurvivalEvolved,
        SurvivalOfTheFittest,
        PrimitivePlus,
        ScorchedEarth,
        Unknown,
    }

    [DefaultValue(False)]
    public enum DinoTamable
    {
        False,
        True,
        ByBreeding,
    }

    public static class GameData
    {
        public const int DEFAULT_MAX_EXPERIENCE_POINTS_DINO = 900000;
        public const int DEFAULT_MAX_EXPERIENCE_POINTS_PLAYER = 1798540;

        private static readonly DinoSpawn[] dinoSpawns = new DinoSpawn[]
        {
            new DinoSpawn { ClassName="Allo_Character_BP_C",                DinoNameTag="Allo" },
            new DinoSpawn { ClassName="Angler_Character_BP_C",              DinoNameTag="Angler" },
            new DinoSpawn { ClassName="Ankylo_Character_BP_C",              DinoNameTag="Anky" },
            new DinoSpawn { ClassName="Ant_Character_BP_C",                 DinoNameTag="Ant" },
            new DinoSpawn { ClassName="Archa_Character_BP_C",               DinoNameTag="Archa" },
            new DinoSpawn { ClassName="Argent_Character_BP_C",              DinoNameTag="Argent" },
            new DinoSpawn { ClassName="Arthro_Character_BP_C",              DinoNameTag="Arthro" },
            new DinoSpawn { ClassName="Bat_Character_BP_C",                 DinoNameTag="Bat" },
            new DinoSpawn { ClassName="Beaver_Character_BP_C",              DinoNameTag="Beaver" },
            new DinoSpawn { ClassName="BigFoot_Character_BP_C",             DinoNameTag="Bigfoot" },
            new DinoSpawn { ClassName="BoaFrill_Character_BP_C",            DinoNameTag="Titanboa" },
            new DinoSpawn { ClassName="Carno_Character_BP_C",               DinoNameTag="Carno" },
            new DinoSpawn { ClassName="Coel_Character_BP_C",                DinoNameTag="Coel" },
            new DinoSpawn { ClassName="Compy_Character_BP_C",               DinoNameTag="Compy" },
            new DinoSpawn { ClassName="Dilo_Character_BP_C",                DinoNameTag="Dilo" },
            new DinoSpawn { ClassName="Dimetro_Character_BP_C",             DinoNameTag="Dimetro" },
            new DinoSpawn { ClassName="Dimorph_Character_BP_C",             DinoNameTag="Dimorph" },
            new DinoSpawn { ClassName="Diplodocus_Character_BP_C",          DinoNameTag="Diplo" },
            new DinoSpawn { ClassName="Direbear_Character_BP_C",            DinoNameTag="Direbear" },
            new DinoSpawn { ClassName="Direwolf_Character_BP_C",            DinoNameTag="Direwolf" },
            new DinoSpawn { ClassName="Dodo_Character_BP_C",                DinoNameTag="Dodo" },
            new DinoSpawn { ClassName="Doed_Character_BP_C",                DinoNameTag="Doed" },
            new DinoSpawn { ClassName="Dolphin_Character_BP_C",             DinoNameTag="Dolphin" },
            new DinoSpawn { ClassName="Dragonfly_Character_BP_C",           DinoNameTag="Dragonfly" },
            new DinoSpawn { ClassName="DungBeetle_Character_BP_C",          DinoNameTag="Beetle" },
            new DinoSpawn { ClassName="Dunkle_Character_BP_C",              DinoNameTag="Dunkle" },
            new DinoSpawn { ClassName="Euryp_Character_C",                  DinoNameTag="Euryp" },
            new DinoSpawn { ClassName="Galli_Character_BP_C",               DinoNameTag="Galli" },
            new DinoSpawn { ClassName="Gigant_Character_BP_C",              DinoNameTag="Gigant" },
            new DinoSpawn { ClassName="Kairuku_Character_BP_C",             DinoNameTag="Kairu" },
            new DinoSpawn { ClassName="Leech_Character_C",                  DinoNameTag="Leech" },
            new DinoSpawn { ClassName="Lystro_Character_BP_C",              DinoNameTag="Lystro" },
            new DinoSpawn { ClassName="MegaCarno_Character_BP_C",           DinoNameTag="Elite Carno" },
            new DinoSpawn { ClassName="MegaRaptor_Character_BP_C",          DinoNameTag="Elite Raptor" },
            new DinoSpawn { ClassName="MegaRex_Character_BP_C",             DinoNameTag="Elite Rex" },
            new DinoSpawn { ClassName="Mammoth_Character_BP_C",             DinoNameTag="Mammoth" },
            new DinoSpawn { ClassName="Manta_Character_BP_C",               DinoNameTag="Manta" },
            new DinoSpawn { ClassName="Megalodon_Character_BP_C",           DinoNameTag="Mega" },
            new DinoSpawn { ClassName="Monkey_Character_BP_C",              DinoNameTag="Monkey" },
            new DinoSpawn { ClassName="Mosa_Character_BP_C",                DinoNameTag="Mosasaur" },
            new DinoSpawn { ClassName="Oviraptor_Character_BP_C",           DinoNameTag="Ovi" },
            new DinoSpawn { ClassName="Pachy_Character_BP_C",               DinoNameTag="Pachy" },
            new DinoSpawn { ClassName="Para_Character_BP_C",                DinoNameTag="Para" },
            new DinoSpawn { ClassName="Paracer_Character_BP_C",             DinoNameTag="Paracer" },
            new DinoSpawn { ClassName="Pela_Character_BP_C",                DinoNameTag="Pela" },
            new DinoSpawn { ClassName="Phiomia_Character_BP_C",             DinoNameTag="Phiomia" },
            new DinoSpawn { ClassName="Piranha_Character_BP_C",             DinoNameTag="Piranha" },
            new DinoSpawn { ClassName="Plesiosaur_Character_BP_C",          DinoNameTag="Plesiosaur" },
            new DinoSpawn { ClassName="Procoptodon_Character_BP_C",         DinoNameTag="Kangaroo" },
            new DinoSpawn { ClassName="Ptero_Character_BP_C",               DinoNameTag="Ptera" },
            new DinoSpawn { ClassName="Quetz_Character_BP_C",               DinoNameTag="Quetz" },
            new DinoSpawn { ClassName="Raptor_Character_BP_C",              DinoNameTag="Raptor" },
            new DinoSpawn { ClassName="Rex_Character_BP_C",                 DinoNameTag="Rex" },
            new DinoSpawn { ClassName="Rhino_Character_BP_C",               DinoNameTag="Rhino" },
            new DinoSpawn { ClassName="Saber_Character_BP_C",               DinoNameTag="Sabertooth" },
            new DinoSpawn { ClassName="Salmon_Character_BP_C",              DinoNameTag="Salmon" },
            new DinoSpawn { ClassName="Sarco_Character_BP_C",               DinoNameTag="Sarco" },
            new DinoSpawn { ClassName="Sauropod_Character_BP_C",            DinoNameTag="Bronto" },
            new DinoSpawn { ClassName="Scorpion_Character_BP_C",            DinoNameTag="Scorpion" },
            new DinoSpawn { ClassName="SpiderS_Character_BP_C",             DinoNameTag="Spider" },
            new DinoSpawn { ClassName="Spino_Character_BP_C",               DinoNameTag="Spino" },
            new DinoSpawn { ClassName="Stag_Character_BP_C",                DinoNameTag="Stag" },
            new DinoSpawn { ClassName="Stego_Character_BP_C",               DinoNameTag="Stego" },
            new DinoSpawn { ClassName="Tapejara_Character_BP_C",            DinoNameTag="Tapejara" },
            new DinoSpawn { ClassName="TerrorBird_Character_BP_C",          DinoNameTag="TerrorBird" },
            new DinoSpawn { ClassName="Titanosaur_Character_BP_C",          DinoNameTag="Titan" },
            new DinoSpawn { ClassName="Toad_Character_BP_C",                DinoNameTag="Toad" },
            new DinoSpawn { ClassName="Trike_Character_BP_C",               DinoNameTag="Trike" },
            new DinoSpawn { ClassName="Trilobite_Character_C",              DinoNameTag="Trilobite" },
            new DinoSpawn { ClassName="Turtle_Character_BP_C",              DinoNameTag="Turtle" },

            new DinoSpawn { ClassName="FlyingAnt_Character_BP_C",           DinoNameTag=null },
            new DinoSpawn { ClassName="Leech_Character_Diseased_C",         DinoNameTag=null },
            new DinoSpawn { ClassName="Mosa_Character_BP_Mega_C",           DinoNameTag=null },
            new DinoSpawn { ClassName="Yeti_Character_BP_C",                DinoNameTag=null },

            // Scorched Earth dinos
            new DinoSpawn { ClassName="camelsaurus_Character_BP_C",         DinoNameTag="Camelsaurus",              ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Deathworm_Character_BP_C",           DinoNameTag="Deathworm",                ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Jerboa_Character_BP_C",              DinoNameTag="Jerboa",                   ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Jugbug_Oil_Character_BP_C",          DinoNameTag="JugBug",                   ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Manticore_Character_BP_C",           DinoNameTag="Manticore",                ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Mantis_Character_BP_C",              DinoNameTag="Mantis",                   ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Moth_Character_BP_C",                DinoNameTag="Moth",                     ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="RockGolem_Character_BP_C",           DinoNameTag="RockElemental",            ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="SpineyLizard_Character_BP_C",        DinoNameTag="SpineyLizard",             ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Vulture_Character_BP_C",             DinoNameTag="Vulture",                  ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Wyvern_Character_BP_Fire_C",         DinoNameTag="Wyvern",                   ArkApplication=ArkApplication.ScorchedEarth },

            new DinoSpawn { ClassName="Jugbug_Water_Character_BP_C",        DinoNameTag=null,                       ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="MegaDeathworm_Character_BP_C",       DinoNameTag=null,                       ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="MegaWyvern_Character_BP_Fire_C",     DinoNameTag=null,                       ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="RubbleGolem_Character_BP_C",         DinoNameTag=null,                       ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Wyvern_Character_BP_Lightning_C",    DinoNameTag=null,                       ArkApplication=ArkApplication.ScorchedEarth },
            new DinoSpawn { ClassName="Wyvern_Character_BP_Poison_C",       DinoNameTag=null,                       ArkApplication=ArkApplication.ScorchedEarth },
        };

        public static IEnumerable<DinoSpawn> GetDinoSpawns() => dinoSpawns.Select(d => d.Duplicate<DinoSpawn>());

        public static IEnumerable<NPCReplacement> GetNPCReplacements() => dinoSpawns.Select(d => new NPCReplacement() { FromClassName = d.ClassName, ToClassName = d.ClassName });

        public static DinoTamable IsTameableForClass(string className)
        {
            switch (className)
            {
                case "Ant_Character_BP_C":
                case "BoaFrill_Character_BP_C":
                case "Coel_Character_BP_C":
                case "Dragonfly_Character_BP_C":
                case "Leech_Character_C":
                case "MegaCarno_Character_BP_C":
                case "MegaRaptor_Character_BP_C":
                case "MegaRex_Character_BP_C":
                case "Piranha_Character_BP_C":
                case "Salmon_Character_BP_C":
                case "Trilobite_Character_C":
                    return DinoTamable.False;

                case "FlyingAnt_Character_BP_C":
                case "Leech_Character_Diseased_C":
                case "Mosa_Character_BP_Mega_C":
                case "Yeti_Character_BP_C":
                    return DinoTamable.False;

                // Scorched Earth dinos
                case "Deathworm_Character_BP_C":
                case "Jugbug_Oil_Character_BP_C":
                case "Manticore_Character_BP_C":
                    return DinoTamable.False;

                case "Jugbug_Water_Character_BP_C":
                case "MegaDeathworm_Character_BP_C":
                case "MegaWyvern_Character_BP_Fire_C":
                case "RubbleGolem_Character_BP_C":
                    return DinoTamable.False;

                case "Wyvern_Character_BP_Fire_C":
                case "Wyvern_Character_BP_Lightning_C":
                case "Wyvern_Character_BP_Poison_C":
                    return DinoTamable.ByBreeding;

                default:
                    return DinoTamable.True;
            }
        }

        public static string NameTagForClass(string className)
        {
            switch (className)
            {
                case "FlyingAnt_Character_BP_C":
                case "Leech_Character_Diseased_C":
                case "Mosa_Character_BP_Mega_C":
                case "Yeti_Character_BP_C":
                    return null;

                // Scorched Earth dinos
                case "Jugbug_Water_Character_BP_C":
                case "MegaDeathworm_Character_BP_C":
                case "MegaWyvern_Character_BP_Fire_C":
                case "RubbleGolem_Character_BP_C":
                case "Wyvern_Character_BP_Lightning_C":
                case "Wyvern_Character_BP_Poison_C":
                    return null;

                default:
                    var dinoSpawn = dinoSpawns.FirstOrDefault(d => d.ClassName == className);
                    return dinoSpawn?.DinoNameTag ?? className;
            }
        }

        public static string FriendlyNameForClass(string className)
        {
            return GlobalizedApplication.Instance.GetResourceString(className) ?? className;
        }

        private static readonly ClassMultiplier[] standardDinoMultipliers = new ClassMultiplier[]
        {
            new ClassMultiplier { ClassName="Allo_Character_BP_C" },
            new ClassMultiplier { ClassName="Angler_Character_BP_C" },
            new ClassMultiplier { ClassName="Ankylo_Character_BP_C" },
            new ClassMultiplier { ClassName="Ant_Character_BP_C" },
            new ClassMultiplier { ClassName="Archa_Character_BP_C" },
            new ClassMultiplier { ClassName="Argent_Character_BP_C" },
            new ClassMultiplier { ClassName="Arthro_Character_BP_C" },
            new ClassMultiplier { ClassName="Bat_Character_BP_C" },
            new ClassMultiplier { ClassName="Beaver_Character_BP_C" },
            new ClassMultiplier { ClassName="BigFoot_Character_BP_C" },
            new ClassMultiplier { ClassName="BoaFrill_Character_BP_C" },
            new ClassMultiplier { ClassName="Carno_Character_BP_C" },
            new ClassMultiplier { ClassName="Coel_Character_BP_C" },
            new ClassMultiplier { ClassName="Compy_Character_BP_C" },
            new ClassMultiplier { ClassName="Dilo_Character_BP_C" },
            new ClassMultiplier { ClassName="Dimetro_Character_BP_C" },
            new ClassMultiplier { ClassName="Dimorph_Character_BP_C" },
            new ClassMultiplier { ClassName="Diplodocus_Character_BP_C" },
            new ClassMultiplier { ClassName="Direbear_Character_BP_C" },
            new ClassMultiplier { ClassName="Direwolf_Character_BP_C" },
            new ClassMultiplier { ClassName="Dodo_Character_BP_C" },
            new ClassMultiplier { ClassName="Doed_Character_BP_C" },
            new ClassMultiplier { ClassName="Dolphin_Character_BP_C" },
            new ClassMultiplier { ClassName="Dragonfly_Character_BP_C" },
            new ClassMultiplier { ClassName="DungBeetle_Character_BP_C" },
            new ClassMultiplier { ClassName="Dunkle_Character_BP_C" },
            new ClassMultiplier { ClassName="Euryp_Character_C" },
            new ClassMultiplier { ClassName="Galli_Character_BP_C" },
            new ClassMultiplier { ClassName="Gigant_Character_BP_C" },
            new ClassMultiplier { ClassName="Kairuku_Character_BP_C" },
            new ClassMultiplier { ClassName="Leech_Character_C" },
            new ClassMultiplier { ClassName="Lystro_Character_BP_C" },
            new ClassMultiplier { ClassName="Mammoth_Character_BP_C" },
            new ClassMultiplier { ClassName="Manta_Character_BP_C" },
            new ClassMultiplier { ClassName="Megalodon_Character_BP_C" },
            new ClassMultiplier { ClassName="MegaCarno_Character_BP_C" },
            new ClassMultiplier { ClassName="MegaRaptor_Character_BP_C" },
            new ClassMultiplier { ClassName="MegaRex_Character_BP_C" },
            new ClassMultiplier { ClassName="Monkey_Character_BP_C" },
            new ClassMultiplier { ClassName="Mosa_Character_BP_C" },
            new ClassMultiplier { ClassName="Oviraptor_Character_BP_C" },
            new ClassMultiplier { ClassName="Pachy_Character_BP_C" },
            new ClassMultiplier { ClassName="Para_Character_BP_C" },
            new ClassMultiplier { ClassName="Paracer_Character_BP_C" },
            new ClassMultiplier { ClassName="Pela_Character_BP_C" },
            new ClassMultiplier { ClassName="Phiomia_Character_BP_C" },
            new ClassMultiplier { ClassName="Piranha_Character_BP_C" },
            new ClassMultiplier { ClassName="Plesiosaur_Character_BP_C" },
            new ClassMultiplier { ClassName="Procoptodon_Character_BP_C" },
            new ClassMultiplier { ClassName="Ptero_Character_BP_C" },
            new ClassMultiplier { ClassName="Quetz_Character_BP_C" },
            new ClassMultiplier { ClassName="Raptor_Character_BP_C" },
            new ClassMultiplier { ClassName="Rex_Character_BP_C" },
            new ClassMultiplier { ClassName="Rhino_Character_BP_C" },
            new ClassMultiplier { ClassName="Saber_Character_BP_C" },
            new ClassMultiplier { ClassName="Salmon_Character_BP_C" },
            new ClassMultiplier { ClassName="Sarco_Character_BP_C" },
            new ClassMultiplier { ClassName="Sauropod_Character_BP_C" },
            new ClassMultiplier { ClassName="Scorpion_Character_BP_C" },
            new ClassMultiplier { ClassName="SpiderS_Character_BP_C" },
            new ClassMultiplier { ClassName="Spino_Character_BP_C" },
            new ClassMultiplier { ClassName="Stag_Character_BP_C" },
            new ClassMultiplier { ClassName="Stego_Character_BP_C" },
            new ClassMultiplier { ClassName="Tapejara_Character_BP_C" },
            new ClassMultiplier { ClassName="TerrorBird_Character_BP_C" },
            new ClassMultiplier { ClassName="Titanosaur_Character_BP_C" },
            new ClassMultiplier { ClassName="Toad_Character_BP_C" },
            new ClassMultiplier { ClassName="Trike_Character_BP_C" },
            new ClassMultiplier { ClassName="Trilobite_Character_C" },
            new ClassMultiplier { ClassName="Turtle_Character_BP_C" },

            new ClassMultiplier { ClassName="FlyingAnt_Character_BP_C" },
            new ClassMultiplier { ClassName="Leech_Character_Diseased_C" },
            new ClassMultiplier { ClassName="Mosa_Character_BP_Mega_C" },
            new ClassMultiplier { ClassName="Yeti_Character_BP_C" },

            // Scorched Earth
            new ClassMultiplier { ClassName="camelsaurus_Character_BP_C" },
            new ClassMultiplier { ClassName="Deathworm_Character_BP_C" },
            new ClassMultiplier { ClassName="Jerboa_Character_BP_C" },
            new ClassMultiplier { ClassName="Jugbug_Oil_Character_BP_C" },
            new ClassMultiplier { ClassName="Manticore_Character_BP_C" },
            new ClassMultiplier { ClassName="Mantis_Character_BP_C" },
            new ClassMultiplier { ClassName="Moth_Character_BP_C" },
            new ClassMultiplier { ClassName="RockGolem_Character_BP_C" },
            new ClassMultiplier { ClassName="SpineyLizard_Character_BP_C" },
            new ClassMultiplier { ClassName="Vulture_Character_BP_C" },
            new ClassMultiplier { ClassName="Wyvern_Character_BP_Fire_C" },

            new ClassMultiplier { ClassName="Jugbug_Water_Character_BP_C" },
            new ClassMultiplier { ClassName="MegaDeathworm_Character_BP_C" },
            new ClassMultiplier { ClassName="MegaWyvern_Character_BP_Fire_C" },
            new ClassMultiplier { ClassName="RubbleGolem_Character_BP_C" },
            new ClassMultiplier { ClassName="Wyvern_Character_BP_Lightning_C" },
            new ClassMultiplier { ClassName="Wyvern_Character_BP_Poison_C" },
        };

        public static IEnumerable<ClassMultiplier> GetStandardDinoMultipliers() => standardDinoMultipliers.Select(d => d.Duplicate<ClassMultiplier>());

        private static readonly ResourceClassMultiplier[] standardResourceMultipliers = new ResourceClassMultiplier[]
        {
            new ResourceClassMultiplier { ClassName="PrimalItemResource_AnglerGel_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ApexDrop_Argentavis_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ApexDrop_Megalodon_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ApexDrop_Rex_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ApexDrop_Sauro_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_BlackPearl_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Charcoal_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Chitin_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ChitinOrKeratin_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ChitinPaste_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Crystal_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Electronics_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Fibers_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Flint_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Gasoline_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Gunpowder_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Hide_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Horn_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Keratin_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_LeechBlood_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Metal_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_MetalIngot_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Obsidian_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Oil_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Pelt_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Polymer_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Polymer_Organic_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_RareFlower_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_RareMushroom_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Sap_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Silicon_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Sparkpowder_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Stone_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Thatch_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Wood_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_RawMeat_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_RawMeat_Fish_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_RawPrimeMeat_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_RawPrimeMeat_Fish_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Berry_Amarberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Berry_Azulberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Berry_Mejoberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Berry_Narcoberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Berry_Stimberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Berry_Tintoberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Veggie_Citronal_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Veggie_Longrass_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Veggie_Rockarrot_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Veggie_Savoroot_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Amarberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Azulberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_DefensePlant_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Mejoberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Narcoberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Stimberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Tintoberry_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Citronal_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Longrass_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Rockarrot_C" },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_Savoroot_C" },

            // Scorched Earth
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ApexDrop_FireWyvern_C" ,            ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ApexDrop_LightningWyvern_C" ,       ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_ApexDrop_PoisonWyvern_C" ,          ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Clay_C" ,                           ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_KeratinSpike_C" ,                   ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_PreservingSalt_C" ,                 ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Propellant_C" ,                     ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_RawSalt_C" ,                        ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Sand_C" ,                           ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Silk_C" ,                           ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemResource_Sulfur_C" ,                         ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_CactusSap_C" ,                    ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_Seed_PlantSpeciesY_C" ,           ArkApplication=ArkApplication.ScorchedEarth },
            new ResourceClassMultiplier { ClassName="PrimalItemConsumable_WyvernMilk_C" ,                   ArkApplication=ArkApplication.ScorchedEarth },
        };

        public static IEnumerable<ResourceClassMultiplier> GetStandardResourceMultipliers() => standardResourceMultipliers.Select(d => d.Duplicate<ResourceClassMultiplier>());

        public static ResourceClassMultiplier GetResourceForClass(string className)
        {
            return standardResourceMultipliers.FirstOrDefault(e => e.ClassName.Equals(className));
        }

        public static bool HasResourceForClass(string className)
        {
            return standardResourceMultipliers.Any(e => e.ClassName.Equals(className));
        }

        private static readonly Level[] levelProgressionDinoOfficial = new Level[]
            {
                new Level { XPRequired=10 },
                new Level { XPRequired=30 },
                new Level { XPRequired=60 },
                new Level { XPRequired=100 },
                new Level { XPRequired=150 },
                new Level { XPRequired=210 },
                new Level { XPRequired=280 },
                new Level { XPRequired=360 },
                new Level { XPRequired=450 },
                new Level { XPRequired=550 },
                new Level { XPRequired=660 },
                new Level { XPRequired=780 },
                new Level { XPRequired=910 },
                new Level { XPRequired=1050 },
                new Level { XPRequired=1200 },
                new Level { XPRequired=1360 },
                new Level { XPRequired=1530 },
                new Level { XPRequired=1710 },
                new Level { XPRequired=1900 },
                new Level { XPRequired=2100 },
                new Level { XPRequired=2310 },
                new Level { XPRequired=2530 },
                new Level { XPRequired=2760 },
                new Level { XPRequired=3000 },
                new Level { XPRequired=3250 },
                new Level { XPRequired=3510 },
                new Level { XPRequired=3780 },
                new Level { XPRequired=4060 },
                new Level { XPRequired=4350 },
                new Level { XPRequired=4650 },
                new Level { XPRequired=4960 },
                new Level { XPRequired=5280 },
                new Level { XPRequired=5610 },
                new Level { XPRequired=5950 },
                new Level { XPRequired=6545 },
                new Level { XPRequired=7199 },
                new Level { XPRequired=7919 },
                new Level { XPRequired=8711 },
                new Level { XPRequired=9582 },
                new Level { XPRequired=10540 },
                new Level { XPRequired=11594 },
                new Level { XPRequired=12985 },
                new Level { XPRequired=14932 },
                new Level { XPRequired=17172 },
                new Level { XPRequired=19748 },
                new Level { XPRequired=23105 },
                new Level { XPRequired=27105 },
                new Level { XPRequired=31505 },
                new Level { XPRequired=36005 },
                new Level { XPRequired=41000 },
                new Level { XPRequired=47000 },
                new Level { XPRequired=55000 },
                new Level { XPRequired=65000 },
                new Level { XPRequired=80000 },
                new Level { XPRequired=98000 },
                new Level { XPRequired=120000 },
                new Level { XPRequired=150000 },
                new Level { XPRequired=185000 },
                new Level { XPRequired=225000 },
                new Level { XPRequired=275000 },
                new Level { XPRequired=340000 },
                new Level { XPRequired=415000 },
                new Level { XPRequired=500000 },
                new Level { XPRequired=600000 },
                new Level { XPRequired=730000 },
                new Level { XPRequired=900000 },
            };

        private static readonly Level[] levelProgressionPlayerOfficial = new Level[]
            {
                new Level { XPRequired=5,       EngramPoints=8 },
                new Level { XPRequired=20,      EngramPoints=8 },
                new Level { XPRequired=40,      EngramPoints=8 },
                new Level { XPRequired=70,      EngramPoints=8 },
                new Level { XPRequired=120,     EngramPoints=8 },
                new Level { XPRequired=190,     EngramPoints=8 },
                new Level { XPRequired=270,     EngramPoints=8 },
                new Level { XPRequired=360,     EngramPoints=8 },
                new Level { XPRequired=450,     EngramPoints=12 },
                new Level { XPRequired=550,     EngramPoints=12 },
                new Level { XPRequired=660,     EngramPoints=12 },
                new Level { XPRequired=780,     EngramPoints=12 },
                new Level { XPRequired=910,     EngramPoints=12 },
                new Level { XPRequired=1050,    EngramPoints=12 },
                new Level { XPRequired=1200,    EngramPoints=12 },
                new Level { XPRequired=1360,    EngramPoints=12 },
                new Level { XPRequired=1530,    EngramPoints=12 },
                new Level { XPRequired=1710,    EngramPoints=12 },
                new Level { XPRequired=1900,    EngramPoints=16 },
                new Level { XPRequired=2100,    EngramPoints=16 },
                new Level { XPRequired=2310,    EngramPoints=16 },
                new Level { XPRequired=2530,    EngramPoints=16 },
                new Level { XPRequired=2760,    EngramPoints=16 },
                new Level { XPRequired=3000,    EngramPoints=16 },
                new Level { XPRequired=3250,    EngramPoints=16 },
                new Level { XPRequired=3510,    EngramPoints=16 },
                new Level { XPRequired=3780,    EngramPoints=16 },
                new Level { XPRequired=4060,    EngramPoints=16 },
                new Level { XPRequired=4350,    EngramPoints=20 },
                new Level { XPRequired=4650,    EngramPoints=20 },
                new Level { XPRequired=4960,    EngramPoints=20 },
                new Level { XPRequired=5280,    EngramPoints=20 },
                new Level { XPRequired=5610,    EngramPoints=20 },
                new Level { XPRequired=5950,    EngramPoints=20 },
                new Level { XPRequired=6300,    EngramPoints=20 },
                new Level { XPRequired=6660,    EngramPoints=20 },
                new Level { XPRequired=7030,    EngramPoints=20 },
                new Level { XPRequired=7410,    EngramPoints=20 },
                new Level { XPRequired=7800,    EngramPoints=24 },
                new Level { XPRequired=8200,    EngramPoints=24 },
                new Level { XPRequired=8610,    EngramPoints=24 },
                new Level { XPRequired=9030,    EngramPoints=24 },
                new Level { XPRequired=9460,    EngramPoints=24 },
                new Level { XPRequired=9900,    EngramPoints=24 },
                new Level { XPRequired=10350,   EngramPoints=24 },
                new Level { XPRequired=10810,   EngramPoints=24 },
                new Level { XPRequired=11280,   EngramPoints=24 },
                new Level { XPRequired=11760,   EngramPoints=24 },
                new Level { XPRequired=12250,   EngramPoints=28 },
                new Level { XPRequired=12750,   EngramPoints=28 },
                new Level { XPRequired=13260,   EngramPoints=28 },
                new Level { XPRequired=13780,   EngramPoints=28 },
                new Level { XPRequired=14310,   EngramPoints=28 },
                new Level { XPRequired=14850,   EngramPoints=28 },
                new Level { XPRequired=15400,   EngramPoints=28 },
                new Level { XPRequired=15960,   EngramPoints=28 },
                new Level { XPRequired=16530,   EngramPoints=28 },
                new Level { XPRequired=17110,   EngramPoints=28 },
                new Level { XPRequired=17700,   EngramPoints=40 },
                new Level { XPRequired=18850,   EngramPoints=40 },
                new Level { XPRequired=21078,   EngramPoints=40 },
                new Level { XPRequired=22448,   EngramPoints=40 },
                new Level { XPRequired=23908,   EngramPoints=40 },
                new Level { XPRequired=25462,   EngramPoints=40 },
                new Level { XPRequired=27498,   EngramPoints=40 },
                new Level { XPRequired=30248,   EngramPoints=40 },
                new Level { XPRequired=34786,   EngramPoints=40 },
                new Level { XPRequired=40004,   EngramPoints=40 },
                new Level { XPRequired=46804,   EngramPoints=40 },
                new Level { XPRequired=54761,   EngramPoints=40 },
                new Level { XPRequired=63713,   EngramPoints=40 },
                new Level { XPRequired=73000,   EngramPoints=50 },
                new Level { XPRequired=85000,   EngramPoints=50 },
                new Level { XPRequired=98000,   EngramPoints=50 },
                new Level { XPRequired=112000,  EngramPoints=50 },
                new Level { XPRequired=127500,  EngramPoints=50 },
                new Level { XPRequired=144500,  EngramPoints=50 },
                new Level { XPRequired=163500,  EngramPoints=50 },
                new Level { XPRequired=184500,  EngramPoints=50 },
                new Level { XPRequired=207500,  EngramPoints=50 },
                new Level { XPRequired=232570,  EngramPoints=50 },
                new Level { XPRequired=259896,  EngramPoints=50 },
                new Level { XPRequired=289681,  EngramPoints=50 },
                new Level { XPRequired=323189,  EngramPoints=50 },
                new Level { XPRequired=360886,  EngramPoints=50 },
                new Level { XPRequired=403318,  EngramPoints=60 },
                new Level { XPRequired=451484,  EngramPoints=60 },
                new Level { XPRequired=506186,  EngramPoints=60 },
                new Level { XPRequired=566358,  EngramPoints=60 },
                new Level { XPRequired=632547,  EngramPoints=60 },
                new Level { XPRequired=705354,  EngramPoints=60 },
                new Level { XPRequired=785441,  EngramPoints=60 },
                new Level { XPRequired=873538,  EngramPoints=60 },
                new Level { XPRequired=971538,  EngramPoints=60 },
                new Level { XPRequired=1083538, EngramPoints=60 },
                new Level { XPRequired=1213538, EngramPoints=60 },
                new Level { XPRequired=1368538, EngramPoints=60 },
                new Level { XPRequired=1558538, EngramPoints=70 },
                new Level { XPRequired=1798538, EngramPoints=70 },
            };


        public static IEnumerable<Level> LevelProgressionDinoOfficial => levelProgressionDinoOfficial.Select(l => l.Duplicate());

        public static IEnumerable<Level> LevelProgressionPlayerOfficial => levelProgressionPlayerOfficial.Select(l => l.Duplicate());

        public static readonly EngramEntry[] engrams = new[]
        {
            new EngramEntry { EngramClassName="EngramEntry_AdvancedBullet_C",                EngramLevelRequirement=50, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_AdvancedRifleBullet_C",           EngramLevelRequirement=55, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_AdvancedSniperBullet_C",          EngramLevelRequirement=70, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_AirConditioner_C",                EngramLevelRequirement=55, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_AlarmTrap_C",                     EngramLevelRequirement=20, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_AnvilBench_C",                    EngramLevelRequirement=25, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_ArrowStone_C",                    EngramLevelRequirement=15, EngramPointsCost=2 },
            new EngramEntry { EngramClassName="EngramEntry_ArrowTranq_C",                    EngramLevelRequirement=20, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_BallistaArrow_C",                 EngramLevelRequirement=25, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_BallistaTurret_C",                EngramLevelRequirement=25, EngramPointsCost=25 },
            new EngramEntry { EngramClassName="EngramEntry_BearTrap_C",                      EngramLevelRequirement=25, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_BearTrap_Large_C",                EngramLevelRequirement=25, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_BeerBarrel_C",                    EngramLevelRequirement=35, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_BloodExtractor_C",                EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Bola_C",                          EngramLevelRequirement=10, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_Bookshelf_C",                     EngramLevelRequirement=20, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_Bow_C",                           EngramLevelRequirement=15, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_BugRepel_C",                      EngramLevelRequirement=15, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_C4Ammo_C",                        EngramLevelRequirement=55, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_Campfire_C",                      EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_Cannon_C",                        EngramLevelRequirement=35, EngramPointsCost=25 },
            new EngramEntry { EngramClassName="EngramEntry_CannonBall_C",                    EngramLevelRequirement=35, EngramPointsCost=5 },
            new EngramEntry { EngramClassName="EngramEntry_Canteen_C",                       EngramLevelRequirement=50, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_CatapultTurret_C",                EngramLevelRequirement=30, EngramPointsCost=25 },
            new EngramEntry { EngramClassName="EngramEntry_ChainBola_C",                     EngramLevelRequirement=45, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_ChemBench_C",                     EngramLevelRequirement=85, EngramPointsCost=65 },
            new EngramEntry { EngramClassName="EngramEntry_ChitinBoots_C",                   EngramLevelRequirement=35, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_ChitinGloves_C",                  EngramLevelRequirement=35, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_ChitinHelmet_C",                  EngramLevelRequirement=30, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_ChitinPants_C",                   EngramLevelRequirement=30, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_ChitinPaste_C",                   EngramLevelRequirement=10, EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ChitinShirt_C",                   EngramLevelRequirement=30, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_ClothBoots_C",                    EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ClothGloves_C",                   EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ClothHelmet_C",                   EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ClothPants_C",                    EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ClothShirt_C",                    EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_Compass_C",                       EngramLevelRequirement=10, EngramPointsCost=5 },
            new EngramEntry { EngramClassName="EngramEntry_CompostBin_C",                    EngramLevelRequirement=15, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_CompoundArrow_C",                 EngramLevelRequirement=70, EngramPointsCost=35 },
            new EngramEntry { EngramClassName="EngramEntry_CompoundBow_C",                   EngramLevelRequirement=70, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_CookingPot_C",                    EngramLevelRequirement=10, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_CropPlot_Large_C",                EngramLevelRequirement=35, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_CropPlot_Medium_C",               EngramLevelRequirement=25, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_CropPlot_Small_C",                EngramLevelRequirement=10, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_Crossbow_C",                      EngramLevelRequirement=25, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_CureLow_C",                       EngramLevelRequirement=20, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_Electronics_C",                   EngramLevelRequirement=40, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_ElectricProd_C",                  EngramLevelRequirement=80, EngramPointsCost=60 },
            new EngramEntry { EngramClassName="EngramEntry_ElevatorPlatformLarge_C",         EngramLevelRequirement=65, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_ElevatorPlatformMedium_C",        EngramLevelRequirement=65, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_ElevatorPlatformSmall_C",         EngramLevelRequirement=65, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_ElevatorTrack_C",                 EngramLevelRequirement=65, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_Fabricator_C",                    EngramLevelRequirement=40, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_FeedingTrough_C",                 EngramLevelRequirement=15, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_Fireplace_C",                     EngramLevelRequirement=30, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_FishingRod_C",                    EngramLevelRequirement=20, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_Flag_C",                          EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_FlagSingle_C",                    EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_FlareLauncher_C",                 EngramLevelRequirement=10, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Flashlight_C",                    EngramLevelRequirement=45, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Forge_C",                         EngramLevelRequirement=20, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_Furniture_WoodTable_C",           EngramLevelRequirement=15, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_FurBoots_C",                      EngramLevelRequirement=25, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_FurGloves_C",                     EngramLevelRequirement=25, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_FurHelmet_C",                     EngramLevelRequirement=25, EngramPointsCost=14 },
            new EngramEntry { EngramClassName="EngramEntry_FurPants_C",                      EngramLevelRequirement=25, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_FurShirt_C",                      EngramLevelRequirement=25, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_GPS_C",                           EngramLevelRequirement=45, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_GasGrenade_C",                    EngramLevelRequirement=25, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_GasMask_C",                       EngramLevelRequirement=85, EngramPointsCost=110 },
            new EngramEntry { EngramClassName="EngramEntry_GhillieBoots_C",                  EngramLevelRequirement=40, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_GhillieGloves_C",                 EngramLevelRequirement=40, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_GhillieHelmet_C",                 EngramLevelRequirement=35, EngramPointsCost=13 },
            new EngramEntry { EngramClassName="EngramEntry_GhilliePants_C",                  EngramLevelRequirement=35, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_GhillieShirt_C",                  EngramLevelRequirement=35, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_GrapplingHook_C",                 EngramLevelRequirement=50, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_Gravestone_C",                    EngramLevelRequirement=10, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseCeiling_C",             EngramLevelRequirement=45, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseDoor_C",                EngramLevelRequirement=45, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseRoof_C",                EngramLevelRequirement=50, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseSlopedWall_Left_C",     EngramLevelRequirement=50, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseSlopedWall_Right_C",    EngramLevelRequirement=50, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseWall_C",                EngramLevelRequirement=45, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseWallWithDoor_C",        EngramLevelRequirement=45, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_GreenhouseWindow_C",              EngramLevelRequirement=45, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_Grenade_C",                       EngramLevelRequirement=30, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_Grill_C",                         EngramLevelRequirement=45, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_Grinder_C",                       EngramLevelRequirement=60, EngramPointsCost=45 },
            new EngramEntry { EngramClassName="EngramEntry_Gunpowder_C",                     EngramLevelRequirement=10, EngramPointsCost=2 },
            new EngramEntry { EngramClassName="EngramEntry_Handcuffs_C",                     EngramLevelRequirement=25, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_HideBoots_C",                     EngramLevelRequirement=20, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_HideGloves_C",                    EngramLevelRequirement=20, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_HideHelmet_C",                    EngramLevelRequirement=20, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_HidePants_C",                     EngramLevelRequirement=15, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_HideShirt_C",                     EngramLevelRequirement=15, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_HideSleepingBag_C",               EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_HoloScope_C",                     EngramLevelRequirement=55, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_IceBox_C",                        EngramLevelRequirement=55, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_IndustrialCookingPot_C",          EngramLevelRequirement=80, EngramPointsCost=60 },
            new EngramEntry { EngramClassName="EngramEntry_IndustrialForge_C",               EngramLevelRequirement=85, EngramPointsCost=90 },
            new EngramEntry { EngramClassName="EngramEntry_Keypad_C",                        EngramLevelRequirement=50, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Lamppost_C",                      EngramLevelRequirement=50, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_LamppostOmni_C",                  EngramLevelRequirement=50, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_Laser_C",                         EngramLevelRequirement=55, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_MachinedPistol_C",                EngramLevelRequirement=50, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MachinedRifle_C",                 EngramLevelRequirement=55, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_MachinedShotgun_C",               EngramLevelRequirement=50, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MachinedSniper_C",                EngramLevelRequirement=70, EngramPointsCost=36 },
            new EngramEntry { EngramClassName="EngramEntry_MagnifyingGlass_C",               EngramLevelRequirement=20, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_MetalBoots_C",                    EngramLevelRequirement=50, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_MetalCatwalk_C",                  EngramLevelRequirement=50, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MetalCeiling_C",                  EngramLevelRequirement=35, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_MetalCeilingWithTrapdoor_C",      EngramLevelRequirement=40, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MetalCeilingWithTrapdoorGiant_C", EngramLevelRequirement=50, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_MetalDoor_C",                     EngramLevelRequirement=35, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalFenceFoundation_C",          EngramLevelRequirement=40, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalFloor_C",                    EngramLevelRequirement=30, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_MetalGate_C",                     EngramLevelRequirement=40, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_MetalGateway_C",                  EngramLevelRequirement=40, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalGateway_Large_C",            EngramLevelRequirement=55, EngramPointsCost=28 },
            new EngramEntry { EngramClassName="EngramEntry_MetalGate_Large_C",               EngramLevelRequirement=55, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_MetalGloves_C",                   EngramLevelRequirement=50, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_MetalHatchet_C",                  EngramLevelRequirement=25, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_MetalHelmet_C",                   EngramLevelRequirement=50, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_MetalLadder_C",                   EngramLevelRequirement=45, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPants_C",                    EngramLevelRequirement=45, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPick_C",                     EngramLevelRequirement=25, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPillar_C",                   EngramLevelRequirement=35, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MetalRailing_C",                  EngramLevelRequirement=30, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPipeIncline_C",              EngramLevelRequirement=45, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPipeIntake_C",               EngramLevelRequirement=40, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPipeIntersection_C",         EngramLevelRequirement=45, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPipeStraight_C",             EngramLevelRequirement=40, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPipeTap_C",                  EngramLevelRequirement=45, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MetalPipeVertical_C",             EngramLevelRequirement=45, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalRamp_C",                     EngramLevelRequirement=35, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalRoof_C",                     EngramLevelRequirement=30, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_MetalShield_C",                   EngramLevelRequirement=30, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_MetalShirt_C",                    EngramLevelRequirement=45, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MetalSickle_C",                   EngramLevelRequirement=30, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_MetalSign_C",                     EngramLevelRequirement=25, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_MetalSign_Large_C",               EngramLevelRequirement=50, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_MetalSign_Wall_C",                EngramLevelRequirement=30, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_MetalSlopedWall_Left_C",          EngramLevelRequirement=30, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_MetalSlopedWall_Right_C",         EngramLevelRequirement=30, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_MetalSpikeWall_C",                EngramLevelRequirement=25, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_MetalStairs_C",                   EngramLevelRequirement=35, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_MetalTrapdoor_C",                 EngramLevelRequirement=40, EngramPointsCost=14 },
            new EngramEntry { EngramClassName="EngramEntry_MetalTrapdoorGiant_C",            EngramLevelRequirement=50, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_MetalWall_C",                     EngramLevelRequirement=30, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_MetalWallWithDoor_C",             EngramLevelRequirement=30, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_MetalWallWithWindow_C",           EngramLevelRequirement=45, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MetalWindow_C",                   EngramLevelRequirement=50, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_MinersHelmet_C",                  EngramLevelRequirement=65, EngramPointsCost=35 },
            new EngramEntry { EngramClassName="EngramEntry_MinigunTurret_C",                 EngramLevelRequirement=85, EngramPointsCost=80 },
            new EngramEntry { EngramClassName="EngramEntry_MiracleGro_C",                    EngramLevelRequirement=35, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_ModernBed_C",                     EngramLevelRequirement=60, EngramPointsCost=28 },
            new EngramEntry { EngramClassName="EngramEntry_MortarAndPestle_C",               EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Narcotic_C",                      EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_NightVisionGoggles_C",            EngramLevelRequirement=90, EngramPointsCost=100 },
            new EngramEntry { EngramClassName="EngramEntry_NotePaper_C",                     EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_Paintbrush_C",                    EngramLevelRequirement=5,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_PaintingCanvas_C",                EngramLevelRequirement=10, EngramPointsCost=2 },
            new EngramEntry { EngramClassName="EngramEntry_Parachute_C",                     EngramLevelRequirement=15, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Pike_C",                          EngramLevelRequirement=25, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_Pistol_C",                        EngramLevelRequirement=30, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_PoisonGrenade_C",                 EngramLevelRequirement=35, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_PoisonTrap_C",                    EngramLevelRequirement=25, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_Polymer_C",                       EngramLevelRequirement=40, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_PowerCableIncline_C",             EngramLevelRequirement=55, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_PowerCableIntersection_C",        EngramLevelRequirement=55, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_PowerCableStraight_C",            EngramLevelRequirement=50, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_PowerCableVertical_C",            EngramLevelRequirement=55, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_PowerGenerator_C",                EngramLevelRequirement=50, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_PowerOutlet_C",                   EngramLevelRequirement=50, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_PreservingBin_C",                 EngramLevelRequirement=20, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_Radio_C",                         EngramLevelRequirement=25, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_Raft_C",                          EngramLevelRequirement=15, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_RiotBoots_C",                     EngramLevelRequirement=80, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_RiotGloves_C",                    EngramLevelRequirement=80, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_RiotHelmet_C",                    EngramLevelRequirement=80, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_RiotPants_C",                     EngramLevelRequirement=80, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_RiotShirt_C",                     EngramLevelRequirement=80, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_RiotShield_C",                    EngramLevelRequirement=75, EngramPointsCost=45 },
            new EngramEntry { EngramClassName="EngramEntry_RocketAmmo_C",                    EngramLevelRequirement=60, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_RocketLauncher_C",                EngramLevelRequirement=60, EngramPointsCost=32 },
            new EngramEntry { EngramClassName="EngramEntry_RocketTurret_C",                  EngramLevelRequirement=90, EngramPointsCost=100 },
            new EngramEntry { EngramClassName="EngramEntry_RopeLadder_C",                    EngramLevelRequirement=10, EngramPointsCost=5 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Allo_C",                   EngramLevelRequirement=50, EngramPointsCost=35 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Ankylo_C",                 EngramLevelRequirement=40, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Argentavis_C",             EngramLevelRequirement=55, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Arthro_C",                 EngramLevelRequirement=50, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Beaver_C",                 EngramLevelRequirement=55, EngramPointsCost=50 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Carno_C",                  EngramLevelRequirement=50, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Diplodocus_C",             EngramLevelRequirement=35, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Direbear_C",               EngramLevelRequirement=35, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Doed_C",                   EngramLevelRequirement=30, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Dolphin_C",                EngramLevelRequirement=10, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Dunkle_C",                 EngramLevelRequirement=40, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Galli_C",                  EngramLevelRequirement=30, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Gigant_C",                 EngramLevelRequirement=85, EngramPointsCost=75 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Mammoth_C",                EngramLevelRequirement=40, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Manta_C",                  EngramLevelRequirement=25, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Megalodon_C",              EngramLevelRequirement=45, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Mosa_C",                   EngramLevelRequirement=80, EngramPointsCost=60 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Mosa_Platform_C",          EngramLevelRequirement=85, EngramPointsCost=80 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Pachy_C",                  EngramLevelRequirement=15, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Para_C",                   EngramLevelRequirement=10, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Paracer_C",                EngramLevelRequirement=30, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Paracer_Platform_C",       EngramLevelRequirement=45, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Pela_C",                   EngramLevelRequirement=40, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Phiomia_C",                EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Plesia_C",                 EngramLevelRequirement=60, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Plesio_Platform_C",        EngramLevelRequirement=80, EngramPointsCost=50 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Procop_C",                 EngramLevelRequirement=50, EngramPointsCost=35 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Ptero_C",                  EngramLevelRequirement=35, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Quetz_C",                  EngramLevelRequirement=60, EngramPointsCost=44 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Quetz_Platform_C",         EngramLevelRequirement=80, EngramPointsCost=80 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Raptor_C",                 EngramLevelRequirement=15, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Rex_C",                    EngramLevelRequirement=60, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Rhino_C",                  EngramLevelRequirement=45, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Saber_C",                  EngramLevelRequirement=45, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Sarco_C",                  EngramLevelRequirement=35, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Sauro_C",                  EngramLevelRequirement=55, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Sauro_Platform_C",         EngramLevelRequirement=70, EngramPointsCost=35 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Scorpion_C",               EngramLevelRequirement=25, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Spider_C",                 EngramLevelRequirement=40, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Spino_C",                  EngramLevelRequirement=60, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Stag_C",                   EngramLevelRequirement=30, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Stego_C",                  EngramLevelRequirement=30, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Tapejara_C",               EngramLevelRequirement=50, EngramPointsCost=21 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_TerrorBird_C",             EngramLevelRequirement=25, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Titano_Platform_C",        EngramLevelRequirement=95, EngramPointsCost=170, },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Toad_C",                   EngramLevelRequirement=20, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Trike_C",                  EngramLevelRequirement=20, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Turtle_C",                 EngramLevelRequirement=25, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_Scope_C",                         EngramLevelRequirement=30, EngramPointsCost=13 },
            new EngramEntry { EngramClassName="EngramEntry_ScubaBoots_Flippers_C",           EngramLevelRequirement=75, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_ScubaHelmet_Goggles_C",           EngramLevelRequirement=75, EngramPointsCost=25 },
            new EngramEntry { EngramClassName="EngramEntry_ScubaPants_C",                    EngramLevelRequirement=75, EngramPointsCost=35 },
            new EngramEntry { EngramClassName="EngramEntry_ScubaShirt_SuitWithTank_C",       EngramLevelRequirement=75, EngramPointsCost=35 },
            new EngramEntry { EngramClassName="EngramEntry_SeaMine_C",                       EngramLevelRequirement=75, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_Silencer_C",                      EngramLevelRequirement=40, EngramPointsCost=13 },
            new EngramEntry { EngramClassName="EngramEntry_SimpleBed_C",                     EngramLevelRequirement=5,  EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_SimpleBullet_C",                  EngramLevelRequirement=30, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_SimpleRifle_C",                   EngramLevelRequirement=35, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_SimpleRifleBullet_C",             EngramLevelRequirement=35, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_SimpleShotgun_C",                 EngramLevelRequirement=35, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_SimpleShotgunBullet_C",           EngramLevelRequirement=35, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Slingshot_C",                     EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Sparkpowder_C",                   EngramLevelRequirement=5,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_Spear_C",                         EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_SprayPainter_C",                  EngramLevelRequirement=60, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_Spyglass_C",                      EngramLevelRequirement=10, EngramPointsCost=2 },
            new EngramEntry { EngramClassName="EngramEntry_StandingTorch_C",                 EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_Stimulant_C",                     EngramLevelRequirement=10, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_StoneCeiling_C",                  EngramLevelRequirement=20, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_StoneCeilingWithTrapdoor_C",      EngramLevelRequirement=25, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_StoneCeilingWithTrapdoorGiant_C", EngramLevelRequirement=35, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_StoneClub_C",                     EngramLevelRequirement=2,  EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_StoneDoor_C",                     EngramLevelRequirement=20, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_StoneFenceFoundation_C",          EngramLevelRequirement=15, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_StoneFloor_C",                    EngramLevelRequirement=20, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_StoneGate_C",                     EngramLevelRequirement=20, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_StoneGateLarge_C",                EngramLevelRequirement=30, EngramPointsCost=16 },
            new EngramEntry { EngramClassName="EngramEntry_StoneGateway_C",                  EngramLevelRequirement=20, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_StoneGateway_Large_C",            EngramLevelRequirement=30, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_StoneHatchet_C",                  EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_StonePick_C",                     EngramLevelRequirement=1,  EngramPointsCost=0 },
            new EngramEntry { EngramClassName="EngramEntry_StonePillar_C",                   EngramLevelRequirement=25, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_StonePipeInclined_C",             EngramLevelRequirement=15, EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_StonePipeIntake_C",               EngramLevelRequirement=10, EngramPointsCost=5 },
            new EngramEntry { EngramClassName="EngramEntry_StonePipeIntersection_C",         EngramLevelRequirement=15, EngramPointsCost=5 },
            new EngramEntry { EngramClassName="EngramEntry_StonePipeStraight_C",             EngramLevelRequirement=10, EngramPointsCost=2 },
            new EngramEntry { EngramClassName="EngramEntry_StonePipeTap_C",                  EngramLevelRequirement=10, EngramPointsCost=5 },
            new EngramEntry { EngramClassName="EngramEntry_StonePipeVertical_C",             EngramLevelRequirement=15, EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_StoneRailing_C",                  EngramLevelRequirement=20, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_StoneRoof_C",                     EngramLevelRequirement=15, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_StoneSlopedWall_Left_C",          EngramLevelRequirement=15, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_StoneSlopedWall_Right_C",         EngramLevelRequirement=15, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_StoneStairs_C",                   EngramLevelRequirement=20, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_StoneTrapdoor_C",                 EngramLevelRequirement=30, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_StoneTrapdoorGiant_C",            EngramLevelRequirement=35, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_StoneWall_C",                     EngramLevelRequirement=15, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_StoneWallWithDoor_C",             EngramLevelRequirement=20, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_StoneWallWithWindow_C",           EngramLevelRequirement=25, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_StoneWindow_C",                   EngramLevelRequirement=30, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_StorageBox_Huge_C",               EngramLevelRequirement=65, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_StorageBox_Large_C",              EngramLevelRequirement=15, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_StorageBox_Small_C",              EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_SubstrateAbsorbent_C",            EngramLevelRequirement=85, EngramPointsCost=60 },
            new EngramEntry { EngramClassName="EngramEntry_Sword_C",                         EngramLevelRequirement=30, EngramPointsCost=11 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchCeiling_C",                 EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchDoor_C",                    EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchFloor_C",                   EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchWall_C",                    EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchSlopedWall_Left_C",         EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchSlopedWall_Right_C",        EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchRoof_C",                    EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_ThatchWallWithDoor_C",            EngramLevelRequirement=2,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_Torch_C",                         EngramLevelRequirement=1,  EngramPointsCost=0 },
            new EngramEntry { EngramClassName="EngramEntry_TrainingDummy_C",                 EngramLevelRequirement=10, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_TranqDart_C",                     EngramLevelRequirement=60, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_TransGPS_C",                      EngramLevelRequirement=65, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_TransGPSAmmo_C",                  EngramLevelRequirement=65, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_TreePlatformMetal_C",             EngramLevelRequirement=60, EngramPointsCost=55 },
            new EngramEntry { EngramClassName="EngramEntry_TreePlatformWood_C",              EngramLevelRequirement=30, EngramPointsCost=28 },
            new EngramEntry { EngramClassName="EngramEntry_TreeSapTap_C",                    EngramLevelRequirement=35, EngramPointsCost=18 },
            new EngramEntry { EngramClassName="EngramEntry_TripwireC4_C",                    EngramLevelRequirement=45, EngramPointsCost=30 },
            new EngramEntry { EngramClassName="EngramEntry_TrophyBase_C",                    EngramLevelRequirement=20, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_TrophyWall_C",                    EngramLevelRequirement=20, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_Turret_C",                        EngramLevelRequirement=60, EngramPointsCost=40 },
            new EngramEntry { EngramClassName="EngramEntry_WallTorch_C",                     EngramLevelRequirement=25, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_Wardrums_C",                      EngramLevelRequirement=10, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WarMap_C",                        EngramLevelRequirement=50, EngramPointsCost=15 },
            new EngramEntry { EngramClassName="EngramEntry_WaterJar_C",                      EngramLevelRequirement=30, EngramPointsCost=12 },
            new EngramEntry { EngramClassName="EngramEntry_Waterskin_C",                     EngramLevelRequirement=3,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WaterTank_C",                     EngramLevelRequirement=15, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_WaterTankMetal_C",                EngramLevelRequirement=45, EngramPointsCost=20 },
            new EngramEntry { EngramClassName="EngramEntry_WeaponC4_C",                      EngramLevelRequirement=55, EngramPointsCost=24 },
            new EngramEntry { EngramClassName="EngramEntry_WoodBench_C",                     EngramLevelRequirement=15, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_WoodCage_C",                      EngramLevelRequirement=10, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_WoodCatwalk_C",                   EngramLevelRequirement=20, EngramPointsCost=8 },
            new EngramEntry { EngramClassName="EngramEntry_WoodCeiling_C",                   EngramLevelRequirement=10, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WoodCeilingWithTrapdoor_C",       EngramLevelRequirement=15, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_WoodChair_C",                     EngramLevelRequirement=10, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WoodDoor_C",                      EngramLevelRequirement=10, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_WoodFenceFoundation_C",           EngramLevelRequirement=15, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WoodFloor_C",                     EngramLevelRequirement=5,  EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WoodGate_C",                      EngramLevelRequirement=15, EngramPointsCost=5 },
            new EngramEntry { EngramClassName="EngramEntry_WoodGateway_C",                   EngramLevelRequirement=15, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_WoodLadder_C",                    EngramLevelRequirement=15, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WoodPillar_C",                    EngramLevelRequirement=15, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_WoodRailing_C",                   EngramLevelRequirement=10, EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_WoodRamp_C",                      EngramLevelRequirement=15, EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_WoodShield_C",                    EngramLevelRequirement=10, EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_WoodSign_C",                      EngramLevelRequirement=3,  EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_WoodSign_Large_C",                EngramLevelRequirement=15, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_WoodSign_Wall_C",                 EngramLevelRequirement=10, EngramPointsCost=2 },
            new EngramEntry { EngramClassName="EngramEntry_WoodSpikeWall_C",                 EngramLevelRequirement=10, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_WoodStairs_C",                    EngramLevelRequirement=10, EngramPointsCost=10 },
            new EngramEntry { EngramClassName="EngramEntry_WoodTrapdoor_C",                  EngramLevelRequirement=20, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WoodWall_C",                      EngramLevelRequirement=5,  EngramPointsCost=7 },
            new EngramEntry { EngramClassName="EngramEntry_WoodSlopedWall_Left_C",           EngramLevelRequirement=10, EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_WoodSlopedWall_Right_C",          EngramLevelRequirement=10, EngramPointsCost=3 },
            new EngramEntry { EngramClassName="EngramEntry_WoodRoof_C",                      EngramLevelRequirement=10, EngramPointsCost=4 },
            new EngramEntry { EngramClassName="EngramEntry_WoodWallWithDoor_C",              EngramLevelRequirement=10, EngramPointsCost=6 },
            new EngramEntry { EngramClassName="EngramEntry_WoodWallWithWindow_C",            EngramLevelRequirement=20, EngramPointsCost=9 },
            new EngramEntry { EngramClassName="EngramEntry_WoodWindow_C",                    EngramLevelRequirement=25, EngramPointsCost=6 },

            // Scorched Earth
            new EngramEntry { EngramClassName="EngramEntry_AdobeCeiling_C",                  EngramLevelRequirement=15, EngramPointsCost=3    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeCeilingDoorGiant_C",         EngramLevelRequirement=30, EngramPointsCost=12   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeCeilingWithDoorWay_Giant_C", EngramLevelRequirement=30, EngramPointsCost=15   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeCeilingWithTrapdoor_C",      EngramLevelRequirement=20, EngramPointsCost=8    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeDoor_C",                     EngramLevelRequirement=15, EngramPointsCost=4    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeFenceFoundation_C",          EngramLevelRequirement=15, EngramPointsCost=6    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeFloor_C",                    EngramLevelRequirement=15, EngramPointsCost=6    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeGate_C",                     EngramLevelRequirement=25, EngramPointsCost=8    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeGate_Large_C",               EngramLevelRequirement=40, EngramPointsCost=15   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeGateway_C",                  EngramLevelRequirement=25, EngramPointsCost=12   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeGateway_Large_C",            EngramLevelRequirement=40, EngramPointsCost=18   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeLadder_C",                   EngramLevelRequirement=15, EngramPointsCost=6    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobePillar_C",                   EngramLevelRequirement=20, EngramPointsCost=8    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeRailing_C",                  EngramLevelRequirement=15, EngramPointsCost=2    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeRamp_C",                     EngramLevelRequirement=20, EngramPointsCost=3    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeRoof_C",                     EngramLevelRequirement=20, EngramPointsCost=5    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeSlopedWall_Left_C",          EngramLevelRequirement=20, EngramPointsCost=3    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeSlopedWall_Right_C",         EngramLevelRequirement=20, EngramPointsCost=3    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeStairs_C",                   EngramLevelRequirement=20, EngramPointsCost=15   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeTrapdoor_C",                 EngramLevelRequirement=20, EngramPointsCost=6    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeWall_C",                     EngramLevelRequirement=15, EngramPointsCost=7    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeWallWithDoor_C",             EngramLevelRequirement=15, EngramPointsCost=6    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeWallWithWindow_C",           EngramLevelRequirement=20, EngramPointsCost=8    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_AdobeWindow_C",                   EngramLevelRequirement=20, EngramPointsCost=6    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Boomerang_C",                     EngramLevelRequirement=10, EngramPointsCost=2    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_ChainSaw_C",                      EngramLevelRequirement=45, EngramPointsCost=21   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Clay_C",                          EngramLevelRequirement=5,  EngramPointsCost=3    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_ClusterGrenade_C",                EngramLevelRequirement=50, EngramPointsCost=8    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_DesertClothBoots_C",              EngramLevelRequirement=30, EngramPointsCost=7    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_DesertClothGloves_C",             EngramLevelRequirement=30, EngramPointsCost=7    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_DesertClothGooglesHelmet_C",      EngramLevelRequirement=30, EngramPointsCost=7    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_DesertClothPants_C",              EngramLevelRequirement=25, EngramPointsCost=5    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_DesertClothShirt_C",              EngramLevelRequirement=25, EngramPointsCost=4    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_FlameArrow_C",                    EngramLevelRequirement=25, EngramPointsCost=15   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Flamethrower_C",                  EngramLevelRequirement=55, EngramPointsCost=25   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_FlamethrowerAmmo_C",              EngramLevelRequirement=55, EngramPointsCost=10   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Mirror_C",                        EngramLevelRequirement=35, EngramPointsCost=25   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_OilJar_C",                        EngramLevelRequirement=20, EngramPointsCost=15   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_OilPump_C",                       EngramLevelRequirement=60, EngramPointsCost=24   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_PreservingSalt_C",                EngramLevelRequirement=5,  EngramPointsCost=3    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Propellant_C",                    EngramLevelRequirement=20, EngramPointsCost=12   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_RocketHommingAmmo_C",             EngramLevelRequirement=75, EngramPointsCost=25   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Camelsaurus_C",            EngramLevelRequirement=15, EngramPointsCost=11   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Mantis_C",                 EngramLevelRequirement=50, EngramPointsCost=18   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_Moth_C",                   EngramLevelRequirement=45, EngramPointsCost=12   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_RockGolem_C",              EngramLevelRequirement=65, EngramPointsCost=40   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Saddle_SpineyLizard_C",           EngramLevelRequirement=40, EngramPointsCost=18   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Tent_C",                          EngramLevelRequirement=10, EngramPointsCost=8    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_Vessel_C",                        EngramLevelRequirement=15, EngramPointsCost=10   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_WaterWell_C",                     EngramLevelRequirement=15, EngramPointsCost=10   , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_WeaponWhip_C",                    EngramLevelRequirement=15, EngramPointsCost=6    , ArkApplication=ArkApplication.ScorchedEarth },
            new EngramEntry { EngramClassName="EngramEntry_WindTurbine_C",                   EngramLevelRequirement=45, EngramPointsCost=18   , ArkApplication=ArkApplication.ScorchedEarth },
        };

        public static IEnumerable<EngramEntry> GetStandardEngramOverrides() => engrams.Select(d => d.Duplicate<EngramEntry>());

        public static EngramEntry GetEngramForClass(string className)
        {
            return engrams.FirstOrDefault(e => e.EngramClassName.Equals(className));
        }

        public static bool HasEngramForClass(string className)
        {
            return engrams.Any(e => e.EngramClassName.Equals(className));
        }

        public static readonly PrimalItem[] primalItems = new[]
        {
            new PrimalItem { ClassName="PrimalItemConsumable_RawMeat_C" },
            new PrimalItem { ClassName="PrimalItemResource_Thatch_C" },
        };

        public static IEnumerable<PrimalItem> GetStandardPrimalItems() => primalItems.Select(d => d.Duplicate());

        public static PrimalItem GetPrimalItemForClass(string className)
        {
            return primalItems.FirstOrDefault(e => e.ClassName.Equals(className));
        }

        public static bool HasPrimalItemForClass(string className)
        {
            return primalItems.Any(e => e.ClassName.Equals(className));
        }

        public enum StatsMultiplier
        {
            Health = 0,
            Stamina = 1,
            Torpidity = 2,
            Oxygen = 3,
            Food = 4,
            Water = 5,
            Temperature = 6,
            Weight = 7,
            MeleeDamageMultiplier = 8,
            SpeedMultiplier = 9,
            TemperatureFortitude = 10,
            CraftingSpeedMultiplier = 11
        };

        internal static IEnumerable<float> GetPerLevelStatsMultipliers_Default()
        {
            return new float[12] { 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f };
        }

        internal static IEnumerable<float> GetPerLevelStatsMultipliers_DinoTamed()
        {
            return new float[12] { 0.23f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 0.20f, 1.0f, 1.0f, 1.0f };
        }

        internal static IEnumerable<float> GetPerLevelStatsMultipliers_DinoTamed_Add()
        {
            return new float[12] { 0.15f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 0.15f, 1.0f, 1.0f, 1.0f };
        }

        internal static IEnumerable<float> GetPerLevelStatsMultipliers_DinoTamed_Affinity()
        {
            return new float[12] { 0.45f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 0.45f, 1.0f, 1.0f, 1.0f };
        }
    }
}

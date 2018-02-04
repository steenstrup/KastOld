﻿using System.Collections.Generic;
using System.Linq;
using Kast.Models.Dnd5E;
using Kast.Models.DnD5E;
using Kast.Models.Repositorys;

namespace Kast.Models.Mocks
{
    public class MockCharecterRepository : ICharecterRepository
    {
        private List<Stat> CreateStats(int str, int dex, int con, int inte, int wis, int cha)
        {
            return new List<Stat>
                {
                    new Stat(EnumStats.Str, str, "Strength"),
                    new Stat(EnumStats.Dex, dex, "Dexterity"),
                    new Stat(EnumStats.Con, con, "Constitution"),
                    new Stat(EnumStats.Int, inte, "Intelligence"),
                    new Stat(EnumStats.Wis, wis, "Wisdom"),
                    new Stat(EnumStats.Cha, cha, "Charisma")
                };
        }

        private DndClass CreateDefualdClaric(int level, IEnumerable<string> skillProf, IEnumerable<Stat> savingThrowProf)
        {
            return new DndClass("Cleric", level)
            {
                SkillProf = skillProf,
                SavingThrowProf = savingThrowProf,
                ArmorToolAndWeaponProf = new List<string> { "Light armor", "Medium armor", "Shields", "All Simple weapons" },
                LanguageProf = new List<string> { "Drakinc", "Undcercommen"},
                FeaturesAndTraitsProf = new List<FeaturesAndTraits>
                {
                    new FeaturesAndTraits("SpellCasting Divine"),
                    new FeaturesAndTraits("Knowledge Domain"),
                    new FeaturesAndTraits("Blessing of Knowledge"),
                    new FeaturesAndTraits("Ritual Caster (c)")
                }
            };
        }

        private DndClass CreateDefualdWizzard(int level, IEnumerable<string> skillProf)
        {
            return new DndClass("Wizard", level)
            {
                SkillProf = skillProf,
                FeaturesAndTraitsProf = new List<FeaturesAndTraits>
                {
                    new FeaturesAndTraits("SpellCasting Arcane"),
                    new FeaturesAndTraits("Arcane Recovery"),
                    new FeaturesAndTraits("War magic"),
                    new FeaturesAndTraits("Arcane deflection"),
                    new FeaturesAndTraits("Tactical wit"),
                    new FeaturesAndTraits("War Caster"),
                    new FeaturesAndTraits("Ritual Caster (w)"),
                }
            };
        }
        
        public IEnumerable<Character> Charecters
        {
            get
            {
                var stats = CreateStats(8, 14, 14, 16, 14, 10);
                
                var classes = new List<DndClass>
                {
                    CreateDefualdClaric(1, new List<string> { "Arcana", "Arcana", "History", "History" }, new List<Stat>{stats.ToList()[4], stats.ToList()[5]}),
                    CreateDefualdWizzard(4, new List<string>())
                };
                
                var race = new Race
                {
                    Name = "High Elf",
                    SkillProf = new List<string> { "Insight", "Investifation", "Perception"},
                    SavingThrowProf = new List<Stat>(),
                    LanguageProf = new List<string> { "Common", "Elvish", "Drawen"},
                    ArmorToolAndWeaponProf = new List<string> { "Longsword", "Shortsword", "Shortbow", "Longbow"},
                    FeaturesAndTraitsProf = new List<FeaturesAndTraits>
                    {
                        new FeaturesAndTraits("Darkvision"),
                        new FeaturesAndTraits("Keen Senses"),
                        new FeaturesAndTraits("Fay Acestry"),
                        new FeaturesAndTraits("Trance"),
                        new FeaturesAndTraits("Cantrip")
                    }
                };

                var backgrund = new Background
                {
                    Name = "Sage",
                    SkillProf = new List<string> { "Religion", "Nature" },
                    SavingThrowProf = new List<Stat>(),
                    LanguageProf = new List<string> { "Celestial", "Infernal" },
                    ArmorToolAndWeaponProf = new List<string>(),
                    FeaturesAndTraitsProf = new List<FeaturesAndTraits>()
                    
                };

                var equipmentEquiped = new List<string> {"Half plate", "Shield", "Dagger"};

                var backpack = new List<string> { "Hat", "Dimon", "Pensle", "Component pouch", "Ink", "Pen", "Papier", "Clothes, Worm", "Clothes, common", "Rations", "Wather skin", "Herp pack", "rope", "Vin", "Gold bar" };

                var equipment = EquipmentsBuilder.DefualdEquipmentBuilder()
                    .LoadArmor().LoadWeapon().Build()
                    .Where(x => equipmentEquiped.Contains(x.Name)).Select(x =>
                    {
                        x.IsEquipped = true;
                        return x;
                    })
                    .Union(EquipmentsBuilder.DefualdEquipmentBuilder().LoadAdventuringGear().Build().Where(x => backpack.Contains(x.Name)));

                /*
                var equipment = new List<Equipment>()
                {
                    
                    new Equipment("Trap builder kit", false, BodySlots.Backpack, 0),
                    new Equipment("10 GP", false, BodySlots.Backpack, 0),
                };
                */

                return new List<Character>()
                {
                    new Character("Akercera", "Kasper Steenstrup", race, backgrund, classes, stats, 37)
                    {
                        CharacterId = 1,
                        Equipments = equipment
                    }
                };
            }
        }

        public Topic GetCharecterId(int charecterId)
        {
            throw new System.NotImplementedException();
        }
    }
    
}
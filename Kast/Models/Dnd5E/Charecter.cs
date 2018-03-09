using System.Collections.Generic;
using System.Linq;
using System;
using Kast.Models.Dnd5E;

namespace Kast.Models.DnD5E
{
    public class Character
    {
        public Character(string characterName,
            string playername,
            Race race,
            Background background,
            IEnumerable<DndClass> initClass,
            IEnumerable<Stat> states,
            int hp)
        {
            CharacterName = characterName;
            Background = background;
            PlayerName = playername;
            Race = race;
            Classes = initClass;
            Stats = states;

            HitPoint = hp;
            SavingThrows = InitSavingThrows();
            Skills = InitSkills();

        }

        private List<SavingThrow> InitSavingThrows()
        {
            var savingThrows = new List<SavingThrow>();
            foreach (var stat in Stats)
            {
                savingThrows.Add(new SavingThrow(stat, Race, Classes, Background));
            }
            return savingThrows;
        }

        private IEnumerable<Skill> InitSkills()
        {
            var skills = new List<Skill>();

            var statsList = Stats.ToList();

            // update skills from stats
            skills.Add(new Skill("Acrobatics", statsList[1], Race, Classes, Background));
            skills.Add(new Skill("AnimalHandling", statsList[4], Race, Classes, Background));
            skills.Add(new Skill("Arcana", statsList[3], Race, Classes, Background));
            skills.Add(new Skill("Athletics", statsList[0], Race, Classes, Background));
            skills.Add(new Skill("Deception", statsList[5], Race, Classes, Background));
            skills.Add(new Skill("History", statsList[3], Race, Classes, Background));
            skills.Add(new Skill("Insight", statsList[4], Race, Classes, Background));
            skills.Add(new Skill("Intimidation", statsList[5], Race, Classes, Background));
            skills.Add(new Skill("Investigation", statsList[3], Race, Classes, Background));
            skills.Add(new Skill("Medicine", statsList[4], Race, Classes, Background));
            skills.Add(new Skill("Nature", statsList[3], Race, Classes, Background));
            skills.Add(new Skill("Perception", statsList[4], Race, Classes, Background));
            skills.Add(new Skill("Performance", statsList[5], Race, Classes, Background));
            skills.Add(new Skill("Persuasion", statsList[5], Race, Classes, Background));
            skills.Add(new Skill("Religion", statsList[3], Race, Classes, Background));
            skills.Add(new Skill("SleightOfHand", statsList[1], Race, Classes, Background));
            skills.Add(new Skill("Stealth", statsList[1], Race, Classes, Background));
            skills.Add(new Skill("Survival", statsList[4], Race, Classes, Background));
            return skills;
        }

        public int CharacterId { get; set; }

        public string CharacterName { get; set; }
        public Background Background { get; set; }
        public string PlayerName { get; set; }
        public Race Race { get; set; }
        public IEnumerable<DndClass> Classes { get; set; }
        public IEnumerable<Stat> Stats { get; set; }
        public IEnumerable<SavingThrow> SavingThrows { get; set; }
        public IEnumerable<Skill> Skills { get; set; }



        public int ProfBonus
        {
            get { return (int) Math.Ceiling(Classes.Select(x => x.Level).Sum() / 2.0); }
        }

        public int Initiative
        {
            get
            {
                var dexModifire = Stats.First(x => x.EnumStat == EnumStats.Dex).Modifire;
                var extraModifire = Stats.First(x => x.EnumStat == EnumStats.Int).Modifire;

                return dexModifire + extraModifire;
            }
        }

        public int Speed => 30;

        public int ArmorClass => Equipments
                                     .Where(x => x.IsEquipped)
                                     .Sum(x => x.Ac) +
                                 Stats.First(x => x.EnumStat == EnumStats.Dex).Modifire;

        public int Carring => Equipments.Select(x => x.Weight).Sum();

        public int CarringCapasity => Stats.First(x => x.EnumStat == EnumStats.Str).Value * 15;
        public int HitPoint { get; set; }

        public int PassivePerception
        {
            get { return 10 + ProfBonus + Stats.First(x => x.EnumStat == EnumStats.Wis).Modifire; }
        }

        public int HirDice => Classes.Select(x => x.Level).Sum();

        public IEnumerable<FeaturesAndTraits> FeaturesAndTraits => Classes
            .Select(x => x.FeaturesAndTraitsProf)
            .Aggregate((accum, next) => accum.Concat(next))
            .Concat(Race.FeaturesAndTraitsProf)
            .Concat(Background.FeaturesAndTraitsProf);

        public IEnumerable<string> ArmorToolAndWeaponProf => Classes
            .Select(x => x.ArmorToolAndWeaponProf)
            .Aggregate((accum, next) => accum.Concat(next))
            .Concat(Race.ArmorToolAndWeaponProf)
            .Concat(Background.ArmorToolAndWeaponProf);

        public IEnumerable<string> Languages => Classes
            .Select(x => x.LanguageProf)
            .Aggregate((accum, next) => accum.Concat(next))
            .Concat(Race.LanguageProf)
            .Concat(Background.LanguageProf);

        public IEnumerable<string> Professions { get; set; }
        public Money Money { get; set; }

        public string History { get; set; }

        public string ClassesToString() => Classes.Select(x => x.Name + " " + x.Level)
            .Aggregate((accum, next) => accum + " / " + next);

        public IEnumerable<Equipment> Equipments { get; set; }

        public IEnumerable<Spell> WizzardSpells { get; set; }
        public IEnumerable<Spell> ClericSpells { get; set; }

        public IEnumerable<Spell> GetWizzardSpellByLevel(int i)
        {
            return WizzardSpells.Where(x => x.Level == i);
        }

        public IEnumerable<Spell> GetClericSpellByLevel(int i)
        {
            return ClericSpells.Where(x => x.Level == i);
        }

        public int GetSpellSlotByLevel(int i)
        {
            if (i == 0)
                return 0;
            var sumLevel = Classes.Select(x => x.Level).Sum();

            switch (i)
            {
                case 1:
                    if (sumLevel == 1)
                        return 2;
                    return sumLevel == 2 ? 3 : 4;
                case 2:
                    if (sumLevel < 3)
                        return 0;
                    return sumLevel == 3 ? 2 : 3;
                case 3:
                    if (sumLevel < 5)
                        return 0;
                    return sumLevel == 5 ? 2 : 3;
            }

            return 0;
        }
        
        public int SpellIntBonus => ProfBonus + Stats.First(x => x.EnumStat == EnumStats.Int).Modifire;
        public int SpellWisBonus => ProfBonus + Stats.First(x => x.EnumStat == EnumStats.Wis).Modifire;
        public int SpellChaBonus => ProfBonus + Stats.First(x => x.EnumStat == EnumStats.Cha).Modifire;


    }
}

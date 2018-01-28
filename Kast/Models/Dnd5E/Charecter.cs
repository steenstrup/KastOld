using System.Collections.Generic;
using System.Linq;
using System;

namespace Kast.Models.DnD5E
{
    public class Character
    {
        public Character(string characterName,
                string playername,
                Race race,
                Background background,
                IEnumerable<DndClass> initClass,
                IEnumerable<Stat> states)
        {
            CharacterName = characterName;
            Background = background;
            PlayerName = playername;
            Race = race;
            Classes = initClass;
            Stats = states;

            PopulateSavingThrows();
            Skills = InitSkills();
            
        }

        private void PopulateSavingThrows()
        {
            var savingThrows = new List<SavingThrow>();
            foreach (var stat in Stats)
            {
                var savingThrowValue = stat.Modifire;
                //if (Race.SavingThrowProf.Contains(stat.enumStat))
                 //   savingThrowValue += ProfBonus;
                savingThrows.Add(new SavingThrow(stat.enumStat, savingThrowValue));
            }
            SavingThrows = savingThrows;
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
            skills.Add(new Skill("Persuasion",  statsList[5], Race, Classes, Background));
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

        public int ProfBonus { get
            {
                return (int)Math.Ceiling(Classes.Select(x => x.Level).Sum() / 2.0);
            }
        }

        public int Initiative { get
            {
                return Stats.Where(x => x.enumStat == EnumStats.Dex).First().Modifire;

            }
        }

        public int Speed { get; set; }
        public int ArmorClass { get; set; }
        public int HitPoint { get; set; }

        public int PassivePerception { get
            {
                return 10 + ProfBonus + Stats.Where(x => x.enumStat == EnumStats.Wis).First().Modifire;
            } }

        public IEnumerable<string> FeaturesAndTraits { get; set; }
        public IEnumerable<string> Languages { get; set; }
        public IEnumerable<string> Professions { get; set; }
        public Money Money { get; set; }

        public string History { get; set; }
        
        public string ClassesToString() => Classes.Select(x => x.Name + " " + x.Level)
                .Aggregate((accum, next) => accum + " / " + next);



    }
}

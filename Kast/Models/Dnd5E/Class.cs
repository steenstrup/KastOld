using Kast.Models.Dnd5E;
using System.Collections.Generic;

namespace Kast.Models.DnD5E
{
    public class DndClass : IProfesion
    {
        public DndClass(string name, int level)
        {
            Name = name;
            Level = level;
            SkillProf = new List<string>();
            ItemProf = new List<string>();
            LanguageProf = new List<string>();
            SavingThrowProf = new List<Stat>();
            ArmorToolAndWeaponProf = new List<string>();
            FeaturesAndTraitsProf = new List<FeaturesAndTraits>();
        }

        public DndClass(string name, int level,
            IEnumerable<string> skillProf,
            IEnumerable<string> itemProf,
            IEnumerable<string> languageProf,
            IEnumerable<Stat> savingThrowProf)
        {
            Name = name;
            Level = level;
            SkillProf = skillProf;
            ItemProf = itemProf;
            LanguageProf = languageProf;
            SavingThrowProf = savingThrowProf;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        
        public IEnumerable<string> SkillProf { get; set; }
        public IEnumerable<string> ItemProf { get; set; }
        public IEnumerable<string> LanguageProf { get; set; }
        public IEnumerable<Stat> SavingThrowProf { get; set; }
        public IEnumerable<string> ArmorToolAndWeaponProf { get; set; }
        public IEnumerable<FeaturesAndTraits> FeaturesAndTraitsProf { get; set; }
    }
}
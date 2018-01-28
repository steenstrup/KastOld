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
            SavingThrowProf = new List<string>();
        }

        public DndClass(string name, int level,
            IEnumerable<string> skillProf,
            IEnumerable<string> itemProf,
            IEnumerable<string> languageProf,
            IEnumerable<string> savingThrowProf)
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
        public IEnumerable<string> SavingThrowProf { get; set; }
    }
}
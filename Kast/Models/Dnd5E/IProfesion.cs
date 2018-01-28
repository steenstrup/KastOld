using System.Collections.Generic;

namespace Kast.Models.Dnd5E
{
    public interface IProfesion
    {
        IEnumerable<string> SkillProf { get; set; }
        IEnumerable<string> ItemProf { get; set; }
        IEnumerable<string> LanguageProf { get; set; }
        IEnumerable<string> SavingThrowProf { get; set; }
    }
}

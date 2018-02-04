using System.Collections.Generic;
using Kast.Models.DnD5E;

namespace Kast.Models.Dnd5E
{
    public interface IProfesion
    {
        IEnumerable<string> SkillProf { get; set; }

        IEnumerable<string> ItemProf { get; set; }

        IEnumerable<string> LanguageProf { get; set; }

        IEnumerable<Stat> SavingThrowProf { get; set; }

        IEnumerable<string> ArmorToolAndWeaponProf { get; set; }

        IEnumerable<FeaturesAndTraits> FeaturesAndTraitsProf { get; set; }

    }
}

﻿using Kast.Models.Dnd5E;
using System.Collections.Generic;

namespace Kast.Models.Dnd5E
{
    public class Background : IProfesion
    {
        public string Name { get; set; }
        public IEnumerable<string> SkillProf { get; set; }
        public IEnumerable<string> ItemProf { get; set; }
        public IEnumerable<string> LanguageProf { get; set; }
        public IEnumerable<Stat> SavingThrowProf { get; set; }
        public IEnumerable<string> ArmorToolAndWeaponProf { get; set; }
        public IEnumerable<FeatureAndTrait> FeaturesAndTraitsProf { get; set; }
    }
}
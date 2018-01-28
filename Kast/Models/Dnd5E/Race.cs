﻿using Kast.Models.Dnd5E;
using System.Collections.Generic;

namespace Kast.Models.DnD5E
{
    public class Race : IProfesion
    {
        public IEnumerable<string> SkillProf { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
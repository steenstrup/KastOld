using Kast.Models.Dnd5E;
using System.Collections.Generic;

namespace Kast.Models.DnD5E
{
    public class Background : IProfesion
    {
        public string Name { get; set; }
        public IEnumerable<string> SkillProf { get; set; }
    }
}
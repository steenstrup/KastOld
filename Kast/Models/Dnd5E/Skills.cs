using Kast.Models.Dnd5E;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kast.Models.Dnd5E
{
    public class Skill
    {
        public Skill(string description, 
            Stat stat, 
            IProfesion race, 
            IEnumerable<DndClass> dndClasses,
            IProfesion background)
        {
            Description = description;
            _race = race;
            _dndClasses = dndClasses;
            _background = background;
            Stat = stat;
        }
                
        private readonly IProfesion _race;
        private readonly IProfesion _background;
        private readonly IEnumerable<DndClass> _dndClasses;
        public Stat Stat;

        private int NumberOfProfisionOnSkill()
        {
            var skillProfList = _dndClasses.Select(x => x.SkillProf).
                Aggregate((accum, next) => accum.Concat(next))
                .Concat(_race.SkillProf)
                .Concat(_background.SkillProf);

            return skillProfList.Count(x => x == Description);
        }

        public string Description { get; private set; }
        public bool IsProfesion => NumberOfProfisionOnSkill() > 0;

        public int GetValue()
        {
            var profBonus = (int)Math.Ceiling(_dndClasses.Select(x => x.Level).Sum() / 2.0);
            return Stat.Modifire + profBonus * NumberOfProfisionOnSkill();
        }
    }
}
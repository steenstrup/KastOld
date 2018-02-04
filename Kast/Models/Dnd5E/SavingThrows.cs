using System;
using System.Collections.Generic;
using Kast.Models.Dnd5E;
using System.Linq;

namespace Kast.Models.DnD5E
{
    public class SavingThrow
    {
        public int Value { get; set; }

        public SavingThrow(Stat stat,
            IProfesion race,
            IEnumerable<DndClass> dndClasses,
            IProfesion background)
        {
            _race = race;
            _dndClasses = dndClasses;
            _background = background;
            Stat = stat;
        }

        private readonly IProfesion _race;
        private readonly IProfesion _background;
        private readonly IEnumerable<DndClass> _dndClasses;
        public Stat Stat;
        
        public bool IsProfesion()
        {
            var profesionList = _dndClasses
                .Select(x => x.SavingThrowProf)
                .Aggregate((accum, next) => accum.Concat(next))
                .Concat(_race.SavingThrowProf)
                .Concat(_background.SavingThrowProf);
            
            return profesionList.Contains(Stat);
        }
        
        public int GetValue()
        {
            var profBonus = (int)Math.Ceiling(_dndClasses.Select(x => x.Level).Sum() / 2.0);
            if (IsProfesion())
                return Stat.Modifire + profBonus;
            return Stat.Modifire;
        }
    }
}
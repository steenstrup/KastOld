using System.Collections.Generic;

namespace Kast.Models.Dnd5E
{
    interface ISpellRepository
    {
        IEnumerable<Spell> Spells { get; }

        Spell GetSpellId(int spellId);
    }
}

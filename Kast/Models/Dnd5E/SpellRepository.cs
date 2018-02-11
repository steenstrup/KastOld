using System.Collections.Generic;
using System.Linq;

namespace Kast.Models.Dnd5E
{
    public class SpellRepository : ISpellRepository
    {
        private readonly Dnd5EContext _dnd5EContext;

        public SpellRepository(Dnd5EContext dnd5EContext)
        {
            _dnd5EContext = dnd5EContext;
        }

        public IEnumerable<Spell> Spells => _dnd5EContext.Spells;

        public Spell GetSpellId(int spellId)
        {
            return _dnd5EContext.Spells.FirstOrDefault(x => x.SpellId == spellId);
        }
    }
}

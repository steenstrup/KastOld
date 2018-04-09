using System.Collections.Generic;
using System.Linq;

namespace Kast.Models.Dnd5E
{
    public class Character
    {
        public int CharacterId { get; set; }

        public string CharacterName { get; set; }
        public string PlayerName { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<Spell> Spells { get; set; }

        public IEnumerable<Spell> SpellByLevel(int i)
        {
            return Spells.Where(x => x.Level == i);
        }

    }
}

using System.Collections.Generic;

namespace Kast.Roleplaying.Models.Dnd5Edition
{
    public class SpellBook
    {
        public SpellBook()
        {
            name = "";
        }

        public int SpellBookId {get; set;}

        public string name { get; set; }

        // acane spell
        public ICollection<Spell> Spells { get; set; }
        
    }
}

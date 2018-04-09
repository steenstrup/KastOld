namespace Kast.Roleplaying.Models.Dnd5Edition
{
    public class Spell
    {
        public Spell()
        {
            Retual = false;
            Concentration = false;

        }

        // database information
        public int SpellId { get; set; }
        public int SpellBookId { get; set; }

        public int Level { get; set; }

        public string Name { get; set; }
        public string Range { get; set; }
        public string Schole { get; set; }
        public string Damage { get; set; }
        public string Material { get; set; }
        public string Duration { get; set; }
        public string DamageType { get; set; }
        public string Components { get; set; }
        public string CastingTime { get; set; }
        public string Description { get; set; }
        public string ClassesCanCast { get; set; } // wizzard,bart,socerr
        public string InClass { get; set; }

        public bool Retual { get; set; }
        public bool Concentration { get; set; }

        
    }
}

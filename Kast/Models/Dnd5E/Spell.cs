using System.Collections.Generic;

namespace Kast.Models.Dnd5E
{
    public class Spell
    {
        public int SpellId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Schole { get; set; }
        public bool Retual { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Damage { get; set; }
        public string DamageType { get; set; }
        
        public string Overview()
        {
            var res = Name;

            if (Retual)
                res += "(r)";

            if (Damage != null && DamageType != null)
                res += " " + Damage + " " + DamageType; 
            
            return res;
        }
        
    }

    public class SpellBuilder
    {
        private readonly List<Spell> _spell;

        public static SpellBuilder DefualdSpellBuilder()
        {
            return new SpellBuilder();
        }

        public SpellBuilder()
        {
            _spell = new List<Spell>();
        }

        public SpellBuilder LoadCantrip()
        {
            
            // wizzard
            _spell.Add(new Spell { Name="Light", Level = 0 });
            _spell.Add(new Spell { Name = "Fire Bolt", Level = 0 });
            _spell.Add(new Spell { Name = "Mage Hand", Level = 0 });
            _spell.Add(new Spell { Name = "Mending", Level = 0 });
            _spell.Add(new Spell { Name = "Message", Level = 0 });
            _spell.Add(new Spell { Name = "Minor Illusion", Level = 0 });
            _spell.Add(new Spell { Name = "Prestidigitation", Level = 0 });
            _spell.Add(new Spell { Name = "Guidance", Level = 0 });
            _spell.Add(new Spell { Name = "Thaumaturgy", Level = 0 });
            
            return this;
        }

        public SpellBuilder LoadLvl1Spell()
        {
            _spell.Add(new Spell { Name = "Chromatic Orb", Level = 1 });
            _spell.Add(new Spell { Name = "Detect Magic", Level = 1 });
            _spell.Add(new Spell { Name = "Expeditious Retreat", Level = 1 });
            _spell.Add(new Spell { Name = "Feather Fall", Level = 1 });
            _spell.Add(new Spell { Name = "Find Familiar", Level = 1 });
            _spell.Add(new Spell { Name = "Identify", Level = 1 });
            _spell.Add(new Spell { Name = "Shield", Level = 1 });
            _spell.Add(new Spell { Name = "Sleep", Level = 1 });
            _spell.Add(new Spell { Name = "Tenser's Floating Disk", Level = 1 });
            _spell.Add(new Spell { Name = "Unseen Servant", Level = 1 });
            _spell.Add(new Spell { Name = "Arnold's World snap", Level = 1 });

            _spell.Add(new Spell { Name = "Bane", Level = 1 });
            _spell.Add(new Spell { Name = "Bless", Level = 1 });
            _spell.Add(new Spell { Name = "Command", Level = 1 });
            _spell.Add(new Spell { Name = "Create or Destroy Water", Level = 1 });
            _spell.Add(new Spell { Name = "Cure Wounds", Level = 1 });
            _spell.Add(new Spell { Name = "Detect Evil and Good", Level = 1 });
            _spell.Add(new Spell { Name = "Detect Poison and Disease", Level = 1 });
            _spell.Add(new Spell { Name = "Guiding Bold", Level = 1 });
            _spell.Add(new Spell { Name = "Healing Word", Level = 1 });
            _spell.Add(new Spell { Name = "Inflict Wounds", Level = 1 });
            _spell.Add(new Spell { Name = "Protection from Evil and Good", Level = 1 });
            _spell.Add(new Spell { Name = "Purify Food and Drink", Level = 1 });
            _spell.Add(new Spell { Name = "Sanctuary", Level = 1 });
            _spell.Add(new Spell { Name = "Shield of Faith", Level = 1 });
            
            return this;
        }

        public SpellBuilder LoadLvl2Spell()
        {
            _spell.Add(new Spell { Name = "Blur", Level = 2});
            _spell.Add(new Spell { Name = "Rope Trick", Level = 2 });
            _spell.Add(new Spell { Name = "Suggestion", Level = 2 });
            _spell.Add(new Spell { Name = "Skywrite", Level = 2 });
            _spell.Add(new Spell { Name = "Weight of the world", Level = 2 });
            _spell.Add(new Spell { Name = "Belfor's Heavy Crush", Level = 2 });
            
            return this;
        }

        public IEnumerable<Spell> Build()
        {
            return _spell;
        }
    }
}

using System.Collections.Generic;

namespace Kast.Models.Dnd5E
{
    public class Spell
    {
        public string Name { get; }

        public string Description { get; }

        public string ShortDescription { get; }

        public string Schole { get; }

        public string Materials { get; }

        public IEnumerable<string> InClass { get; }

        public int Level { get; }

        public string Range { get; }

        public string CastingTime { get; }

        public string Duration { get; }

        public bool Prepart { get; }

        public bool Retual { get; }

        public string Damage { get; }

        public string DamageType { get; }

        public Spell(string name, string decription, string shortDecription, string schole, string materials, IEnumerable<string> inClass, int level, string range, string castingTime, string duration, bool prepart, bool retual, string damage , string damageType)
        {
            Name = name;
            Description = decription;
            ShortDescription = shortDecription;
            Schole = schole;
            Materials = materials;
            InClass = inClass;
            Level = level;
            Range = range;
            CastingTime = castingTime;
            Duration = duration;
            Prepart = prepart;
            Retual = retual;
            Damage = damage;
            DamageType = damageType;
        }

        public string OverviewText()
        {
            var res = Name;

            if (Retual)
                res += "(r)";

            if (Damage != "")
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
            var t = new List<string> { "wizzard" };

            // wizzard
            _spell.Add(new Spell("Light",
                "You touch one object that is no larger than 10 feet in any dimension. Until the spell ends, the object sheds bright light in a 20-foot radius and dim light for an additional 20 feet. The light can be colored as you like. Completely covering the object with something opaque blocks the light. The spell ends if you cast it again or dismiss it as an action. If you target an object held or worn by a hostile creature, that creature must succeed on a Dexterity saving throw to avoid the spell.",
                "Small item ligth on touch", "?", "", t, 0, "Touch", "1 action", "1 hour", true, false, "", ""));

            _spell.Add(new Spell("Fire Bolt",
                "You hurl a mote of fire at a creature or object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 fire damage. A flammable object hit by this spell ignites if it isn't being worn or carried. This spell's damage increases by 1d10 when you reach 5th level (2d10), 11th level (3d10), and 17th level (4d10).",
                "Fire Bolt flow from you hand", "?", "", t, 0, "120 feet", "1 action", "Instantaneous", true, false, "2d10", "Fire"));

            _spell.Add(new Spell("Mage Hand",
               "A spectral, floating hand appears at a point you choose within range. The hand lasts for the duration or until you dismiss it as an action. The hand vanishes if it is ever more than 30 feet away from you or if you cast this spell again. You can use your action to control the hand.You can use the hand to manipulate an object, open an unlocked door or container, stow or retrieve an item from an open container, or pour the contents out of a vial.You can move the hand up to 30 feet each time you use it.The hand can't attack, activate magic items, or carry more than 10 pounds.",
               "Create a small flying hand", "?", "", t, 0, "30 feet", "1 action", "1 minute", true, false, "", ""));

            _spell.Add(new Spell("Mending",
   "This spell repairs a single break or tear in an object you touch, such as a broken chain link, two halves of a broken key, a torn cloak, or a leaking wineskin. As long as the break or tear is no larger than 1 foot in any dimension, you mend it, leaving no trace of the former damage. This spell can physically repair a magic item or construct, but the spell can’t restore magic to such an object.",
   "Mending a item", "?", "", t, 0, "Touch", "1 minute", "Instantaneous", true, false, "", ""));

            _spell.Add(new Spell("Message",
"You point your finger towards a creature within range and whisper a message. The Target (and only the target) hears the message and can reply in a whisper that only you can hear. You can cast this spell through solid objects if you are familiar with the target and know it is beyond the barrier.Magical Silence, 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood blocks the spell. The spell doesn't have to follow a straight line and can travel freely around corners or through openings.",
"Message a person that you are pointing at", "?", "", t, 0, "120 feet", "1 action", "1 Round", true, false, "", ""));

            _spell.Add(new Spell("Minor Illusion",
"You create a sound or an image of an object within range that lasts for the duration. The illusion also ends if you dismiss it as an action or cast this spell again. If you create a sound, its volume can range from a whisper to a scream.It can be your voice, someone else’s voice, a lion’s roar, a beating of drums, or any other sound you choose.The sound continues unabated throughout the duration, or you can make discrete sounds at different times before the spell ends. If you create an image of an object—such as a chair, muddy footprints, or a small chest—it must be no larger than a 5 - foot cube.The image can’t create sound, light, smell, or any other sensory effect.Physical interaction with the image reveals it to be an illusion, because things can pass through it. If a creature uses its action to examine the sound or image, the creature can determine that it is an illusion with a successful Intelligence(Investigation) check against your spell save DC.If a creature discerns the illusion for what it is, the illusion becomes faint to the creature.",
"Create a small illusion", "?", "", t, 0, "30 feet", "1 action", "1 Minute", true, false, "", ""));

            _spell.Add(new Spell("Prestidigitation",
"This spell is a minor magical trick that novice spell-casters use for practice. You create one of the following magical effects within range: You create an instantaneous, harmless sensory effect, such as a shower of sparks, a puff of wind, faint musical notes, or an odd odor. You instantaneously light or snuff out a candle, a torch, or a small campfire. You instantaneously clean or soil an object no larger than 1 cubic foot. You chill, warm, or flavor up to 1 cubic foot of nonliving material for 1 hour. You make a color, a small mark, or a symbol appear on an object or a surface for 1 hour. You create a nonmagical trinket or an illusory image that can fit in your hand and that lasts until the end of your next turn. If you cast this spell multiple times, you can have up to three of its non - instantaneous effects active at a time, and you can dismiss such an effect as an action.",
"Prestidigitation", "?", "", t, 0, "10 feet", "1 action", " Up to 1 hour", true, false, "", ""));

            return this;
        }

        public SpellBuilder LoadLvl1Spell()
        {
            var t = new List<string> { "wizzard" };

            // wizzard
            _spell.Add(new Spell("Chromatic Orb", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, false, "3d8", "Pick one"));
            _spell.Add(new Spell("Detect Magic", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, true, "", ""));
            _spell.Add(new Spell("Expeditious Retreat", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, false, "", ""));
            _spell.Add(new Spell("Feather Fall", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, false, "", ""));
            _spell.Add(new Spell("Find Familiar", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, true, "", ""));
            _spell.Add(new Spell("Identify", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, true, "", ""));
            _spell.Add(new Spell("Shield", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, false, "", ""));
            _spell.Add(new Spell("Sleep", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, false, "", ""));
            _spell.Add(new Spell("Tenser's Floating Disk", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, true, "", ""));
            _spell.Add(new Spell("Unseen Servant", "", "", "?", "", t, 1, "Touch", "1 action", "1 hour", true, true, "", ""));

            return this;
        }

        public SpellBuilder LoadLvl2Spell()
        {
            var t = new List<string> { "wizzard" };

            // wizzard
            _spell.Add(new Spell("Blur", "", "", "?", "", t, 2, "Touch", "1 action", "1 hour", true, false, "", ""));
            _spell.Add(new Spell("Rope Trick", "", "", "?", "", t, 2, "Touch", "1 action", "1 hour", true, false, "", ""));
            _spell.Add(new Spell("Suggestion", "", "", "?", "", t, 2, "Touch", "1 action", "1 hour", true, false, "", ""));
            _spell.Add(new Spell("Skywrite", "", "", "?", "", t, 2, "Touch", "1 action", "1 hour", true, true, "", ""));

            return this;
        }

        public IEnumerable<Spell> Build()
        {
            return _spell;
        }
    }
}

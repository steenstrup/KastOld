using System.Collections.Generic;
using Kast.Roleplaying.Models.Dnd5Edition;


namespace Kast.Roleplaying.Builders
{
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
            _spell.Add(new Spell
            {
                Name = "Fire Bolt",
                Level = 0,
                Schole = "Evocation",
                CastingTime = "1 Action",
                Range = "120 feet",
                Components = "V, S",
                Damage = "1d10",
                DamageType = "fire",
                Duration = "Instantaneous",
                Description = "You hurl a mote of fire at a creature or object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 fire damage. A flammable object hit by this spell ignites if it isn't being worn or carried. \n This spell's damage increases by 1d10 when you reach 5th level (2d10), 11th level (3d10), and 17th level (4d10).",
                ClassesCanCast = "Wizzard,Sorcerer"
            });
            _spell.Add(new Spell
            {
                Name = "Light",
                Level = 0,
                Schole = "Evocation",
                CastingTime = "1 Action",
                Range = "Touch",
                Material = "a firefly or phosphorescent moss",
                Components = "V, M",
                Duration = "1 hour",
                Description = "You touch one object that is no larger than 10 feet in any dimension. Until the spell ends, the object sheds bright light in a 20-foot radius and dim light for an additional 20 feet. The light can be colored as you like. Completely covering the object with something opaque blocks the light. The spell ends if you cast it again or dismiss it as an action. \n If you target an object held or worn by a hostile creature, that creature must succeed on a Dexterity saving throw to avoid the spell.",
                ClassesCanCast = "Bard,Sorcerer,Wizzard,Cleric"
            });
            _spell.Add(new Spell
            {
                Name = "Mending",
                Level = 0,
                Schole = "Transmutation",
                CastingTime = "1 minute",
                Range = "Touch",
                Material = "two lodestones",
                Components = "V, S, M",
                Duration = "Instantaneous",
                Description = "This spell repairs a single break or tear in an object you touch, such as a broken chain link, two halves of a broken key, a torn cloak, or a leaking wineskin. As long as the break or tear is no larger than 1 foot in any dimension, you mend it, leaving no trace of the former damage. \n This spell can physically repair a magic item or construct, but the spell can’t restore magic to such an object.",
                ClassesCanCast = "Bard,Sorcerer,Druid,Wizzard,Cleric"
            });
            _spell.Add(new Spell
            {
                Name = "Message",
                Level = 0,
                Schole = "Transmutation",
                CastingTime = "1 Action",
                Range = "120ft",
                Material = "a short piece of copper wire",
                Components = "V, S, M",
                Duration = "1 Round",
                Description = "You point your finger towards a creature within range and whisper a message. The Target (and only the target) hears the message and can reply in a whisper that only you can hear. \n You can cast this spell through solid objects if you are familiar with the target and know it is beyond the barrier.Magical Silence, 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood blocks the spell. The spell doesn't have to follow a straight line and can travel freely around corners or through openings.",
                ClassesCanCast = "Bard,Wizzard,Sorcerer"
            });
            _spell.Add(new Spell
            {
                Name = "Minor Illusion",
                Level = 0,
                Schole = "Illusion",
                CastingTime = "1 Action",
                Range = "30 feet",
                Material = "a bit of fleece",
                Components = "S, M",
                Duration = "1 minute",
                Description = "You create a sound or an image of an object within range that lasts for the duration. The illusion also ends if you dismiss it as an action or cast this spell again.\n If you create a sound, its volume can range from a whisper to a scream. It can be your voice, someone else’s voice, a lion’s roar, a beating of drums, or any other sound you choose. The sound continues unabated throughout the duration, or you can make discrete sounds at different times before the spell ends. \n If you create an image of an object—such as a chair, muddy footprints, or a small chest—it must be no larger than a 5-foot cube. The image can’t create sound, light, smell, or any other sensory effect. Physical interaction with the image reveals it to be an illusion, because things can pass through it. \n If a creature uses its action to examine the sound or image, the creature can determine that it is an illusion with a successful Intelligence (Investigation) check against your spell save DC. If a creature discerns the illusion for what it is, the illusion becomes faint to the creature.",
                ClassesCanCast = "Bard,Sorcerer,Warlock,Wizzard"
            });
            _spell.Add(new Spell
            {
                Name = "Prestidigitation",
                Level = 0,
                Schole = "Transmutation",
                CastingTime = "1 Action",
                Range = "10 feet",
                Components = "V, S",
                Duration = "1 hour",
                Description = "This spell is a minor magical trick that novice spell-casters use for practice. You create one of the following magical effects within range:\nYou create an instantaneous, harmless sensory effect, such as a shower of sparks, a puff of wind, faint musical notes, or an odd odor.\nYou instantaneously light or snuff out a candle, a torch, or a small campfire.\nYou instantaneously clean or soil an object no larger than 1 cubic foot. You chill, warm, or flavor up to 1 cubic foot of nonliving material for 1 hour.\nYou make a color, a small mark, or a symbol appear on an object or a surface for 1 hour.\nYou create a nonmagical trinket or an illusory image that can fit in your hand and that lasts until the end of your next turn. If you cast this spell multiple times, you can have up to three of its non - instantaneous effects active at a time, and you can dismiss such an effect as an action. ",
                ClassesCanCast = "Bard,Sorcerer,Warlock,Wizzard"
            });
            _spell.Add(new Spell
            {
                Name = "Guidance",
                Level = 0,
                Schole = "Divination",
                CastingTime = "1 Action",
                Range = "Touch",
                Components = "V, S",
                Concentration = true,
                Duration = "1 minute",
                Description = "You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one ability check of its choice. It can roll the die before or after making the ability check. The spell then ends",
                ClassesCanCast = "Cleric,Druid"
            });
            _spell.Add(new Spell
            {
                Name = "Thaumaturgy",
                Level = 0,
                Schole = "Transmutation",
                CastingTime = "1 Action",
                Range = "30 feet",
                Components = "V",
                Duration = "1 minute",
                Description = "You manifest a minor wonder, a sign of supernatural power, within range. You create one of the following magical effects within range: \n Your voice booms up to three times as loud as normal for 1 minute.\nYou cause flames to flicker, brighten, dim, or change color for 1 minute. You cause harmless tremors in the ground for 1 minute.\n You create an instantaneous sound that originates from a point of your choice within range, such as a rumble of thunder, the cry of a raven, or ominous whispers. \nYou instantaneously cause an unlocked door or window to fly open or slam shut. You alter the appearance of your eyes for 1 minute. \nIf you cast this spell multiple times, you can have up to three of its 1 - minute effects active at a time, and you can dismiss such an effect as an action.",
                ClassesCanCast = "Cleric"
            });

            return this;
        }

        public SpellBuilder LoadLvl1Spell()
        {
            _spell.Add(new Spell
            {
                Name = "Chromatic Orb",
                Level = 1,
                Schole = "Evocation",
                CastingTime = "1 Action",
                Range = "90 feet",
                Components = "V, S, M (a diamond worth at least 50 gp)",
                Damage = "3d8",
                DamageType = "Pick",
                Duration = "Instantaneous",
                Description = "You hurl a 4-inch-diameter sphere of energy at a creature that you can see within range. You choose acid, cold, fire, lightning, poison, or thunder for the type of orb you create, and then make a ranged spell attack against the target. If the attack hits, the creature takes 3d8 damage of the type you chose. \nt Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d8 for each slot level above 1st.",
                ClassesCanCast = "Socerer,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Detect Magic",
                Level = 1,
                Schole = "divination",
                Retual = true,
                CastingTime = "1 action",
                Range = "Self",
                Components = "V, S",
                Duration = "Concentration, up to 10 minutes",
                Description = "For the duration, you sense the presence of magic within 30 feet of you. If you sense magic in this way, you can use your action to see a faint aura around any visible creature or object in the area that bears magic, and you learn its school of magic, if any. \n The spell can penetrate most barriers, but it is blocked by 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood or dirt.",
                ClassesCanCast = "Bard,Cleric,Druid,Ranger,Socerer,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Expeditious Retreat",
                Level = 1,
                Schole = "transmutation",
                CastingTime = "1 bonus action",
                Range = "Self",
                Components = "V, S",
                Duration = "Concentration, up to 10 minutes",
                Description = "This spell allows you to move at an incredible pace. When you cast this spell, and then as a bonus action on each of your turns until the spell ends, you can take the Dash action.",
                ClassesCanCast = "Socerer,Warlock,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Feather Fall",
                Level = 1,
                Schole = "transmutation",
                CastingTime = "1 reaction, which you take when you or a creature within 60 feet of you falls",
                Range = "60 feet",
                Components = "V, M (a small feather or piece of down)",
                Duration = "1 minute",
                Description = "Choose up to five falling creatures within range. A falling creature's rate of descent slows to 60 feet per round until the spell ends. If the creature lands before the spell ends, it takes no falling damage and can land on its feet, and the spell ends for that creature.",
                ClassesCanCast = "Socerer,Bard,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Find Familiar",
                Level = 1,
                Retual = true,
                Schole = "conjuration",
                CastingTime = "1 hour",
                Range = "10 feet",
                Components = "V, S, M (10 gp worth of charcoal, incense, and herbs that must be consumed by fire in a brass brazier)",
                Duration = "Instantaneous",
                Description = "You gain the service of a familiar, a spirit that takes an animal form you choose: bat, cat, crab, frog (toad), hawk, lizard, octopus, owl, poisonous snake, fish (quipper), rat, raven, sea horse, spider, or weasel. Appearing in an unoccupied space within range, the familiar has the statistics of the chosen form, though it is a celestial, fey, or fiend (your choice) instead of a beast.\nYour familiar acts independently of you, but it always obeys your commands. In combat, it rolls its own initiative and acts on its own turn. A familiar can’t attack, but it can take other actions as normal.\nWhen the familiar drops to 0 hit points, it disappears, leaving behind no physical form. It reappears after you cast this spell again.\nWhile your familiar is within 100 feet of you, you can communicate with it telepathically. Additionally, as an action, you can see through your familiar’s eyes and hear what it hears until the start of your next turn, gaining the benefits of any special senses that the familiar has. During this time, you are deaf and blind with regard to your own senses.\nAs an action, you can temporarily dismiss your familiar. It disappears into a pocket dimension where it awaits your summons. Alternatively, you can dismiss it forever. As an action while it is temporarily dismissed, you can cause it to reappear in any unoccupied space within 30 feet of you.\nYou can’t have more than one familiar at a time. If you cast this spell while you already have a familiar, you instead cause it to adopt a new form. Choose one of the forms from the above list. Your familiar transforms into the chosen creature.\nFinally, when you cast a spell with a range of touch, your familiar can deliver the spell as if it had cast the spell. Your familiar must be within 100 feet of you, and it must use its reaction to deliver the spell when you cast it. If the spell requires an attack roll, you use your attack modifier for the roll.",
                ClassesCanCast = "Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Identify",
                Level = 1,
                Retual = true,
                Schole = "divination",
                CastingTime = "1 minute",
                Range = "Touch",
                Components = "V, S, M (a pearl worth at least 100gp and an owl feather)",
                Duration = "Instantaneous",
                Description = "You choose one object that you must touch throughout the casting of the spell. If it is a magic item or some other magic-imbued object, you learn its properties and how to use them, whether it requires attunement to use, and how many charges it has, if any. You learn whether any spells are affecting the item and what they are. If the item was created by a spell, you learn which spell created it.\nIf you instead touch a creature throughout the casting, you learn what spells, if any, are currently affecting it.",
                ClassesCanCast = "Bard,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Shield",
                Level = 1,
                Schole = "abjuration",
                CastingTime = "1 reaction, which you take when you are hit by an attack or targeted by the magic missile spell",
                Range = "Self",
                Components = "V, S",
                Duration = "1 round",
                Description = "An invisible barrier of magical force appears and protects you. Until the start of your next turn, you have a +5 bonus to AC, including against the triggering attack, and you take no damage from the spell magic missile.",
                ClassesCanCast = "Sorcerer,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Sleep",
                Level = 1,
                Schole = "enchantment",
                CastingTime = "1 action",
                Range = "90 feet",
                Components = "V, S, M (a pinch of fine sand, rose petals, or a cricket)",
                Duration = "1 minute",
                Description = "This spell sends creatures into a magical slumber. Roll 5d8; the total is how many hit points of creatures this spell can affect. Creatures within 20 feet of a point you choose within range are affected in ascending order of their current hit points (ignoring unconscious creatures). \ntarting with the creature that has the lowest current hit points, each creature affected by this spell falls unconscious until the spell ends, the sleeper takes damage, or someone uses an action to shake or slap the sleeper awake.Subtract each creature's hit points from the total before moving on to the creature with the next lowest hit points. A creature’s hit points must be equal to or less than the remaining total for that creature to be affected.\n Undead and creatures immune to being charmed aren’t affected by this spell.\nAt higher levels.When you cast this spell using a spell slot of 2nd level or higher, roll an additional 2d8 for each slot level above 1st.",
                ClassesCanCast = "Bard,Sorcerer,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Tenser's Floating Disk",
                Level = 1,
                Retual = true,
                Schole = "Conjuration ",
                CastingTime = "1 Action",
                Range = "30 feet",
                Components = "V, S, M (a drop of mercury)",
                Duration = "1 Hour",
                Description = "This spell creates a circular, horizontal plane of force, 3 feet in diameter and 1 inch thick, that floats 3 feet above the ground in an unoccupied space of your choice that you can see within range. The disk remains for the duration, and can hold up to 500 pounds. If more weight is placed on it, the spell ends, and everything on the disk falls to the ground.\nThe disk is immobile while you are within 20 feet of it.If you move more than 20 feet away from it, the disk follows you so that it remains within 20 feet of you.It can move across uneven terrain, up or down stairs, slopes and the like, but it can’t cross an elevation change of 10 feet or more.For example, the disk can’t move across a 10 - foot - deep pit, nor could it leave such a pit if it was created at the bottom.\nIf you move more than 100 feet from the disk(typically because it can’t move around an obstacle to follow you), the spell ends.",
                ClassesCanCast = "Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Unseen Servant",
                Level = 1,
                Retual = true,
                Schole = "conjuration",
                CastingTime = "1 action",
                Range = "60 feet",
                Components = "V, S, M (a piece of string and a bit of wood)",
                Duration = "Instantaneous",
                Description = "This spell creates an invisible, mindless, shapeless force that performs simple tasks at your command until the spell ends. The servant springs into existence in an unoccupied space on the ground within range. It has AC 10, 1 hit point, and a Strength of 2, and it can’t attack. If it drops to 0 hit points, the spell ends. Once on each of your turns as a bonus action, you can mentally command the servant to move up to 15 feet and interact with an object. The servant can perform simple tasks that a human servant could do, such as fetching things, cleaning, mending, folding clothes, lighting fires, serving food, and pouring wine. Once you give the command, the servant performs the task to the best of its ability until it completes the task, then waits for your next command. If you command the servant to perform a task that would move it more than 60 feet away from you, the spell ends.",
                ClassesCanCast = "Bard,Warlock,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Arnold's World snap",
                Level = 1,
                Schole = "",
                CastingTime = "",
                Range = "",
                Components = "",
                Duration = "Instantaneous",
                Description = "",
                ClassesCanCast = "Wizard"
            });

            _spell.Add(new Spell
            {
                Name = "Bane",
                Level = 1,
                Schole = "enchantment",
                CastingTime = "1 action",
                Range = "30 feet",
                Components = "V, S, M (a drop of blood)",
                Duration = "Concentration, up to 1 minute",
                Description = "Up to three creatures of your choice that you can see within range must make Charisma saving throws. Whenever a target that fails this saving throw makes an attack roll or a saving throw before the spell ends, the target must roll a d4 and subtract the number rolled from the attack roll or saving throw.\nAt Higher Levels.When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.",
                ClassesCanCast = "Bard,Cleric"
            });
            _spell.Add(new Spell
            {
                Name = "Bless",
                Level = 1,
                Schole = "enchantment",
                CastingTime = "1 action",
                Range = "30 feet",
                Components = "V, S, M (a sprinkling of holy water)",
                Duration = "Concentration, up to 1 minute",
                Description = "You bless up to three creatures of your choice within range. Whenever a target makes an attack roll or a saving throw before the spell ends, the target can roll a d4 and add the number rolled to the attack roll or saving throw.\nAt Higher Levels.When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.",
                ClassesCanCast = "Paladin,Cleric"
            });
            _spell.Add(new Spell
            {
                Name = "Command",
                Level = 1,
                Schole = "enchantment",
                CastingTime = "1 action",
                Range = "60 feet",
                Components = "V",
                Duration = "1 round",
                Description = "You speak a one-word command to a creature you can see within range. The target must succeed on a Wisdom saving throw or follow the command on its next turn. The spell has no effect if the target is undead, if it doesn’t understand your language, or if your command is directly harmful to it.\nSome typical commands and their effects follow. You might issue a command other than one described here. If you do so, the DM determines how the target behaves. If the target can’t follow your command, the spell ends.\nApproach. The target moves toward you by the shortest and most direct route, ending its turn if it moves within 5 feet of you.\nDrop. The target drops whatever it is holding and then ends its turn.\nFlee. The target spends its turn moving away from you by the fastest available means.\nGrovel. The target falls prone and then ends its turn.\nHalt. The target doesn’t move and takes no actions. A flying creature stays aloft, provided that it is able to do so. If it must move to stay aloft, it flies the minimum distance needed to remain in the air.\nAt Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can affect one additional creature for each slot level above 1st. The creatures must be within 30 feet of each other when you target them.",
                ClassesCanCast = "Paladin,Cleric"
            });

            /*
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
            */
            return this;
        }

        public SpellBuilder LoadLvl2Spell()
        {
            _spell.Add(new Spell
            {
                Name = "Blur",
                Level = 2,
                Schole = "illusion",
                CastingTime = "1 Action",
                Range = "Self",
                Components = "V",
                Duration = "Concentration, up to 1 minute",
                Description = "Your body becomes blurred, shifting and wavering to all who can see you. For the duration, any creature has disadvantage on attack rolls against you. An attacker is immune to this effect if it doesn’t rely on sight, as with blindsight, or can see through illusions, as with truesight.",
                ClassesCanCast = "Sorcerer,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Mirror Image",
                Level = 2,
                Schole = "illusion",
                CastingTime = "1 Action",
                Range = "Self",
                Components = "V, S",
                Duration = "1 minute",
                Description = "Three illusory duplicates of yourself appear in your space. Until the spell ends, the duplicates move with you and mimic your actions, shifting position so it’s impossible to track which image is real. You can use your action to dismiss the illusory duplicates.\nEach time a creature targets you with an attack during the spell’s duration, roll a d20 to determine whether the attack instead targets one of your duplicates.\n If you have three duplicates, you must roll a 6 or higher to change the attack’s target to a duplicate.With two duplicates, you must roll an 8 or higher.With one duplicate, you must roll an 11 or higher.\nA duplicate’s AC equals 10 + your Dexterity modifier.If an attack hits a duplicate, the duplicate is destroyed.A duplicate can be destroyed only by an attack that hits it.It ignores all other damage and effects.The spell ends when all three duplicates are destroyed.\nA creature is unaffected by this spell if it can’t see, if it relies on senses other than sight, such as blind sight, or if it can perceive illusions as false, as with true sight.",
                ClassesCanCast = "Sorcerer,Warlock,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Rope Trick",
                Level = 2,
                Schole = "transmutation",
                CastingTime = "1 action",
                Range = "Touch",
                Components = "V, S, M (Powdered corn extract and a twisted loop of parchment)",
                Duration = "1 hour",
                Description = "You touch a length of rope that is up to 60 feet long. One end of the rope then rises into the air until the whole rope hangs perpendicular to the ground. At the upper end of the rope, an invisible entrance opens to an extradimensional space that lasts until the spell ends.\nThe extradimensional space can be reached by climbing to the top of the rope. The space can hold as many as eight medium or smaller creatures. The rope can be pulled into the space, making the rope disappear from view outside the space.\nAttacks and spells can't cross through the entrance into or out of the extradimensional space, but those inside can see out of it as if through a 3-foot-by-5-foot window centered on the rope.\nAnything inside the extradimensional space drops out when the spell ends.",
                ClassesCanCast = "Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Suggestion",
                Level = 2,
                Schole = "enchantment",
                CastingTime = "1 action",
                Range = "30 feet",
                Components = "V, M (a snake’s tongue and either a bit of honeycomb or a drop of sweet oil)",
                Duration = "Concentration, up to 8 hours",
                Description = "You suggest a course of activity (limited to a sentence or two) and magically influence a creature you can see within range that can hear and understand you. Creatures that can’t be charmed are immune to this effect. The suggestion must be worded in such a manner as to make the course of action sound reasonable. Asking the creature to stab itself, throw itself onto a spear, immolate itself, or do some other obviously harmful act ends the spell.\nThe target must make a Wisdom saving throw.On a failed save, it pursues the course of action you described to the best of its ability.The suggested course of action can continue for the entire duration.If the suggested activity can be completed in a shorter time, the spell ends when the subject finishes what it was asked to do.\nYou can also specify conditions that will trigger a special activity during the duration.For example, you might suggest that a knight give her warhorse to the first beggar she meets. If the condition isn’t met before the spell expires, the activity isn’t performed.\nIf you or any of your companions damage the target, the spell ends.",
                ClassesCanCast = "Bard,Sorcerer,Warlock,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Skywrite",
                Retual = true,
                Level = 2,
                Schole = "transmutation",
                CastingTime = "1 action",
                Range = "Sight",
                Components = "V, S",
                Duration = "Concentration, up to 1 hour",
                Description = "You cause up to ten words to form in a part of the sky you can see. The words appear to be made of cloud and remain in place for the spell's duration. The words dissipate when the spell ends. A strong wind can disperse the clouds and end the spell early.",
                ClassesCanCast = "Bard,Druid,Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Weight of the world",
                Level = 2,
                Schole = "",
                CastingTime = "",
                Range = "",
                Components = "",
                Duration = "Instantaneous",
                Description = "",
                ClassesCanCast = "Wizard"
            });
            _spell.Add(new Spell
            {
                Name = "Belfor's Heavy Crush",
                Level = 2,
                Schole = "",
                CastingTime = "",
                Range = "",
                Components = "",
                Duration = "Instantaneous",
                Description = "",
                ClassesCanCast = "Wizard"
            });

            return this;
        }

        public IEnumerable<Spell> Build()
        {
            return _spell;
        }
    }
}

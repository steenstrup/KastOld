using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Kast.Models.Dnd5E
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Dnd5EContext(
                serviceProvider.GetRequiredService<DbContextOptions<Dnd5EContext>>()))
            {
                SeedSpell(context);
                SeedEquipment(context);
                SeedFeatureAndTrait(context);
                SeedCharacter(context);
            }
        }

        private static void SeedCharacter(Dnd5EContext context)
        {
            //if (context.Characters.Any())
            //    return;

            // seed spells
            var cantrip = new List<string> { "Light", "Fire Bolt", "Mending", "Message", "Minor Illusion", "Prestidigitation", "Guidance", "Thaumaturgy" };
            var lvl1Spell = new List<string> { "Arnold's World snap", "Chromatic Orb", "Detect Magic", "Expeditious Retreat", "Feather Fall", "Find Familiar", "Identify", "Shield", "Sleep", "Tenser's Floating Disk", "Unseen Servant" };
            var lvl1ClericSpell = new List<string> { "Bane", "Bless", "Command", "Create or Destroy Water", "Cure Wounds", "Detect Evil and Good", "Detect Poison and Disease", "Guiding Bold", "Healing Word", "Inflict Wounds", "Protection from Evil and Good", "Purify Food and Drink", "Sanctuary", "Shield of Faith" };
            var lvl2Spell = new List<string> { "Belfor's Heavy Crush", "Weight of the world", "Mirre Image", "Rope Trick", "Suggestion", "Skywrite" };
            var spellNames = cantrip.Union(lvl1Spell.Union(lvl2Spell.Union(lvl1ClericSpell)));
            var spell = context.Spells.Where(x => spellNames.Contains(x.Name)).ToList();

            // seed Equipments
            var magicItems = new List<string> { "Googgles of Dwarf Identification", "The Identificed Cube", "Dwarfen Armor of HeadenHeim" };
            var equipmentEquiped = new List<string> { "Half plate", "Shield", "Dagger" };
            var backpack = new List<string> { "Hat", "Dimon", "Pensle", "Component pouch", "Ink", "Pen", "Papier", "Clothes, Worm", "Clothes, common", "Rations", "Wather skin", "Herp pack", "rope", "Vin", "Gold bar" };
            var equipmentNames = magicItems.Union(equipmentEquiped.Union(backpack));
            var equipment = context.Equipments.Where(x => equipmentNames.Contains(x.Name)).ToList();


            context.Characters.AddRange(
                new List<Character>
                {
                    new Character(){CharacterName="Bo", PlayerName="Kasper Steenstrup", Spells=spell, Equipments=equipment },
                    new Character(){CharacterName="Bo2", PlayerName="Irene Heilmann", Spells=spell, Equipments=equipment}
                });

            context.SaveChanges();
        }

        private static void SeedFeatureAndTrait(Dnd5EContext context)
        {
            if (context.FeaturesAndTraits.Any())
                return;

            var featuresAndTraits = FeatureAndTraitBuilder.DefualdFeatureAndTraitBuilder()
                .loadFeatures()
                .loadTraits()
                .Build().ToList();
            
            context.FeaturesAndTraits.AddRange(featuresAndTraits);
            context.SaveChanges();
        }

        private static void SeedEquipment(Dnd5EContext context)
        {
            if (context.Equipments.Any())
                return; 

            var equipment = EquipmentsBuilder.DefualdEquipmentBuilder()
                .LoadAllItems()
                .Build().ToList();

            context.Equipments.AddRange(equipment);
            context.SaveChanges();
        }

        private static void SeedSpell(Dnd5EContext context)
        {
            if (context.Spells.Any())
                return;

            var spells = SpellBuilder.DefualdSpellBuilder()
                .LoadCantrip()
                .LoadLvl1Spell()
                .LoadLvl2Spell()
                .Build().ToList();

            context.Spells.AddRange(spells);
            context.SaveChanges();
        }
    }
}
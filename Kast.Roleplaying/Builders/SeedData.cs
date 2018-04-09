using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Kast.Roleplaying.Models.Dnd5Edition;
using System.Linq;

namespace Kast.Roleplaying.Builders
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Dnd5EContext(
                serviceProvider.GetRequiredService<DbContextOptions<Dnd5EContext>>()))
            {
                SeedSpellBook(context);
            }
        }

        private static void SeedSpellBook(Dnd5EContext context)
        {
            if (context.SpellBooks.Any())
                return;
            
            var wizzardSpellbook = new SpellBook() { name = "Wizzard" };
            var sorcererSpellbook = new SpellBook() { name = "Sorcerer" };
            var druidSpellbook = new SpellBook() { name = "Druid" };
            var paladinSpellbook = new SpellBook() { name = "Paladin" };
            var warlockSpellbook = new SpellBook() { name = "Warlock" };
            var clericSpellbook = new SpellBook() { name = "Cleric" };
            var clericAndWizzardSpellbook = new SpellBook() { name = "Cleric and Wizzard" };

            wizzardSpellbook.Spells = SpellBuilder.DefualdSpellBuilder().LoadCantrip()
                .LoadLvl1Spell().LoadLvl2Spell().Build()
                .Where(x => CanClassCastSepll(x, "Wizzard"))
                .Select(x => 
                {
                    x.InClass = "Wizzard";
                    return x;
                })
                .ToList();


            sorcererSpellbook.Spells = SpellBuilder.DefualdSpellBuilder().LoadCantrip()
                .LoadLvl1Spell().LoadLvl2Spell().Build()
                .Where(x => CanClassCastSepll(x, "Sorcerer"))
                .Select(x =>
                {
                    x.InClass = "Sorcerer";
                    return x;
                })
                .ToList();

            druidSpellbook.Spells = SpellBuilder.DefualdSpellBuilder().LoadCantrip()
                .LoadLvl1Spell().LoadLvl2Spell().Build()
                .Where(x => CanClassCastSepll(x, "Druid"))
                .Select(x =>
                {
                    x.InClass = "Druid";
                    return x;
                })
                .ToList();

            paladinSpellbook.Spells = SpellBuilder.DefualdSpellBuilder().LoadCantrip()
                .LoadLvl1Spell().LoadLvl2Spell().Build()
                .Where(x => CanClassCastSepll(x, "Paladin"))
                .Select(x =>
                {
                    x.InClass = "Paladin";
                    return x;
                })
                .ToList();

            clericSpellbook.Spells = SpellBuilder.DefualdSpellBuilder().LoadCantrip()
                .LoadLvl1Spell().LoadLvl2Spell().Build()
                .Where(x => CanClassCastSepll(x, "Cleric"))
                .Select(x =>
                {
                    x.InClass = "Cleric";
                    return x;
                })
                .ToList();

            warlockSpellbook.Spells = SpellBuilder.DefualdSpellBuilder().LoadCantrip()
                .LoadLvl1Spell().LoadLvl2Spell().Build()
                .Where(x => CanClassCastSepll(x, "Warlock"))
                .Select(x =>
                {
                    x.InClass = "Warlock";
                    return x;
                })
                .ToList();

            context.SpellBooks.Add(wizzardSpellbook);
            context.SpellBooks.Add(sorcererSpellbook);
            context.SpellBooks.Add(druidSpellbook);
            context.SpellBooks.Add(paladinSpellbook);
            context.SpellBooks.Add(clericSpellbook);
            context.SpellBooks.Add(warlockSpellbook);

            clericAndWizzardSpellbook.Spells = wizzardSpellbook.Spells.Union(clericSpellbook.Spells).ToList();

            context.SpellBooks.Add(clericAndWizzardSpellbook);

            context.SaveChanges();

        }

        private static bool CanClassCastSepll(Spell spell, string dndClass)
        {
            return spell.ClassesCanCast.Split(",").Contains(dndClass);
        }
        
    }
}
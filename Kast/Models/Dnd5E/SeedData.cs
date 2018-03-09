using System;
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
                // Look for any Spell.
                if (context.Spells.Any())
                {
                    return;   // DB has been seeded
                }

                var spells = SpellBuilder.DefualdSpellBuilder().LoadCantrip().LoadLvl1Spell().LoadLvl2Spell().Build().ToList();
                
                context.Spells.AddRange(spells);
                context.SaveChanges();
            }
        }

    }
}

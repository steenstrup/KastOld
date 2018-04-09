using Microsoft.EntityFrameworkCore;

namespace Kast.Models.Dnd5E
{
    public class Dnd5EContext : DbContext
    {
        public Dnd5EContext(DbContextOptions<Dnd5EContext> options)
            : base(options)
        { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<FeatureAndTrait> FeaturesAndTraits { get; set; }

    }
}
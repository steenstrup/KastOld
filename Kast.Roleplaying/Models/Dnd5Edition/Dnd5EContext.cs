using Microsoft.EntityFrameworkCore;

namespace Kast.Roleplaying.Models.Dnd5Edition
{
    public class Dnd5EContext : DbContext
    {
        public Dnd5EContext(DbContextOptions<Dnd5EContext> options)
            : base(options)
        { }
        
        public DbSet<Spell> Spells { get; set; }
        public DbSet<SpellBook> SpellBooks { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SpellBook>().HasMany(s => s.Students).WithOne(s => s.School);
        //}
    }
}

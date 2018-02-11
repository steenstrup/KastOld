using Microsoft.EntityFrameworkCore;

namespace Kast.Models.Dnd5E
{
    public class Dnd5EContext : DbContext
    {
        public Dnd5EContext(DbContextOptions<Dnd5EContext> options)
            : base(options)
        { }

        public DbSet<Spell> Spells { get; set; }
    }
}
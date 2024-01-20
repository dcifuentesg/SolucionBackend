using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class PersonaContext : DbContext
    {
        public PersonaContext(DbContextOptions<PersonaContext> options) : base(options) 
        {
        }

        public DbSet<Persona>Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persona>().HasIndex(c => c.Id).IsUnique();
        }

    }
}

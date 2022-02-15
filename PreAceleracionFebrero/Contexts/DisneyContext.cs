using Microsoft.EntityFrameworkCore;
using PreAceleracionFebrero.Models;

namespace PreAceleracionFebrero.Contexts
{
    public class DisneyContext:DbContext
    {
        private const string Schema = "disney";
        public DisneyContext(DbContextOptions<DisneyContext>options):base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
        }
        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

    }
}

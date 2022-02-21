using GamesApp.Models;
using Microsoft.EntityFrameworkCore;


namespace GamesApp.Data
{
    public partial class GamesContext : DbContext
    {
        public GamesContext()
        {
        }

        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public  DbSet<Games> Games { get; set; }
        public  DbSet<GamesGenres> GamesGenres { get; set; }
        public  DbSet<Genres> Genres { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<GamesGenres>(entity =>
            {
                entity.HasKey(e => new { e.GenreId, e.GameId });
            });

            

            base.OnModelCreating(modelBuilder);
        }

        
    }
}

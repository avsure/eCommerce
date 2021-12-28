using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.ActorId, am.MovieId });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movie).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor).WithMany(am => am.Actor_Movie).HasForeignKey(a => a.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public Actor Actors { get; set; }

        public Movie Movies { get; set; }

        public Producer Producer { get; set; }

        public Actor_Movie Actor_Movie { get; set; }

        public Cinema Cinemas { get; set; }
    }
}

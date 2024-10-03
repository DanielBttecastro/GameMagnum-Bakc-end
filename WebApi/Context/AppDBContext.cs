using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<RoundsGames> RoundsGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Round>()
         .HasOne(r => r.Game)  
         .WithMany(g => g.Rounds)  
         .HasForeignKey(r => r.Id_Game)  
         .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<RoundsGames>()
            .HasOne(rg => rg.Round)
            .WithMany(r => r.RoundsGames)
            .HasForeignKey(rg => rg.Id_Rounds);

            modelBuilder.Entity<RoundsGames>()
                .HasOne(rg => rg.Player)
                .WithMany(p => p.RoundsGames)
                .HasForeignKey(rg => rg.Id_Players);

            modelBuilder.Entity<RoundsGames>()
                .HasOne(rg => rg.Option)
                .WithMany(o => o.RoundsGames)
                .HasForeignKey(rg => rg.Id_Options);
        }
    }
}

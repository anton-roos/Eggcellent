using Microsoft.EntityFrameworkCore;
using Eggcellent.Models;

namespace Eggcellent.Data
{
    public class EggcellentDbContext : DbContext
    {
        public EggcellentDbContext(DbContextOptions<EggcellentDbContext> options)
           : base(options)
        {
        }

        public DbSet<GradedEgg> GradedEggs { get; set; }
        public DbSet<RejectedEgg> RejectedEggs { get; set; }
        public DbSet<SoldEgg> SoldEggs { get; set; }
        public DbSet<UngradedEgg> UngradedEggs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GradedEgg>().ToTable("GradedEgg");
            modelBuilder.Entity<RejectedEgg>().ToTable("RejectedEgg");
            modelBuilder.Entity<SoldEgg>().ToTable("SoldEgg");
            modelBuilder.Entity<UngradedEgg>().ToTable("UngradedEgg");
        }
    }

}
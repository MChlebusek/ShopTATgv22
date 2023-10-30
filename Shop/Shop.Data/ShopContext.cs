using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;

namespace Shop.Data
{
    public class ShopContext : DbContext
    {
        
        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToApi> FileToApis { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FilesToDatabase> FilesToDatabases { get; set; }
        public DbSet<KinderGarten> KinderGartens { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RealEstate>()
                .HasMany(r => r.Files)
                .WithOne(f => f.RealEstate)
                .HasForeignKey(f => f.RealEstateId)
                .OnDelete(DeleteBehavior.Cascade);
        }


    }
}


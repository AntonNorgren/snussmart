using SnusSmartAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace SnusSmartAPI.DAL
{
    public class SnusSmartContext : DbContext
    {
        public virtual DbSet<Snuff> Snuff { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<PouchType> Variations { get; set; }

        public SnusSmartContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var dbConnection = config.GetConnectionString("DefaultConnection");
            optionsbuilder.UseSqlServer(dbConnection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Brand>()
                .HasData(new
                {
                    ID = 1,
                    Name = "Swedish Match",
                });

            modelBuilder
                .Entity<Size>()
                .HasData(new
                {
                    ID = 1,
                    PouchSize = "Normal",
                });

            modelBuilder
                 .Entity<PouchType>()
                 .HasData(new
                 {
                     ID = 1,
                     Variation = "White",
                 });

            modelBuilder
                .Entity<Snuff>()
                .HasData(new
                {
                    ID = 1,
                    Name = "General",
                    Price = 49,
                    BrandID = 1,
                    PouchTypeID = 1,
                    SizeID = 1
                });

        }

    }
}

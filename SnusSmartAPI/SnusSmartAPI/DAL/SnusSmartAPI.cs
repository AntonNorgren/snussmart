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

        }

    }
}

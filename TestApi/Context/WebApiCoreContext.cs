using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TestApi
{
    public class WebApiCoreContext : DbContext
    {
        // objects for bind with Db
        public DbSet<CarModel> CarModels { get; set; }

        public WebApiCoreContext(DbContextOptions<WebApiCoreContext> options) : base(options)
        {
            Database.Migrate();
        }
        // methods for configure Db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarModel>().HasData(new CarModel { Id = 1, Vendor = "BMW", Model = "M3", CarClass = "S", Price = 54000 });
            modelBuilder.Entity<CarModel>().HasData(new CarModel { Id = 2, Vendor = "Infiniti", Model = "FX50", CarClass = "J", Price = 25000 });
        }
    }
}

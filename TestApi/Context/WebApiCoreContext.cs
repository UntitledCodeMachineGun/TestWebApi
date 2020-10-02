using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi
{
    public class WebApiCoreContext : DbContext
    {
        // objects for bind with Db
        public DbSet<CarClass> carClasses { get; set; }
        public DbSet<CarVendor> carVendors { get; set; }
        public DbSet<CarModel> carModels { get; set; }

        public WebApiCoreContext(DbContextOptions<WebApiCoreContext> options) : base(options)
        { 
        
        }
        // methods for configure Db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        
        }
    }
}

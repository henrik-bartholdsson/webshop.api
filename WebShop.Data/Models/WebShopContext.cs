using Microsoft.EntityFrameworkCore;

namespace WebShop.API.Models
{
    public class WebShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (options.IsConfigured == false)
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Database=WebShop; Trusted_connection=true");
        }

        public DbSet<CORS> CORS { get; set; }
        public DbSet<PRODUCT> PRODUCT { get; set; }
        public DbSet<CATEGORY> CATEGORY { get; set; }
    }
}

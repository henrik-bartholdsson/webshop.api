using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebShop.API.Models
{
    public class WebShopContext : DbContext // add  : IdentityDbContext<ApplicationUser>
    {
        public WebShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CORS> CORS { get; set; }
        public DbSet<PRODUCT> PRODUCT { get; set; }
        public DbSet<CATEGORIES> CATEGORY { get; set; }
    }
}

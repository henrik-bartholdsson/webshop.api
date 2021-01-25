using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.API.Authenticate;
using WebShop.Data.Models;

namespace WebShop.API.Models
{
    public class WebShopContext : IdentityDbContext<ApplicationUser>
    {
        public WebShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CORS> CORS { get; set; }
        public DbSet<PRODUCT> PRODUCT { get; set; }
        public DbSet<CATEGORIES> CATEGORY { get; set; }
        public DbSet<ORDER> ORDERS { get; set; }
        public DbSet<ORDERRECORD> ORDERRECORDS { get; set; }
        public DbSet<ORDER_STATUS> ORDER_STATUS { get; set; }

    }
}

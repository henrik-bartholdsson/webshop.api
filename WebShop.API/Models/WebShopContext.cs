using Microsoft.EntityFrameworkCore;

namespace WebShop.API.Models
{
    public class WebShopContext : DbContext
    {
        public WebShopContext(DbContextOptions<WebShopContext> options) : base(options)
        {
        }

        public DbSet<Cors> Cors { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}

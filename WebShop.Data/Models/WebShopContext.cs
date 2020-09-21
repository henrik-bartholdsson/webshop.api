﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.API.Authenticate;

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
    }
}

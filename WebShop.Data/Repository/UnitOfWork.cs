﻿using Microsoft.EntityFrameworkCore;
using WebShop.API.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebShopContext _context;

        public UnitOfWork(DbContextOptions options)
        {
            _context = new WebShopContext(options); ;
            Category = new CategoryRepo(_context);
            Product = new ProductRepo(_context);
            Order = new OrderRepo(_context);

        }
        public ICategoryRepo Category { get; private set; }
        public IProductRepo Product { get; private set; }
        public IOrderRepo Order { get; private set; }
    }
}

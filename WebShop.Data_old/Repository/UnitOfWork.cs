using Microsoft.EntityFrameworkCore;
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
            CORS = new CORSRepo(_context);

        }
        public ICategoryRepo Category { get; private set; }
        public IProductRepo Product { get; private set; }
        public CORSRepo CORS { get; private set; }
    }
}

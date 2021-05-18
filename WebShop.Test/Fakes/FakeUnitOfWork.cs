using Microsoft.EntityFrameworkCore;
using WebShop.API.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.Data.Repository
{
    public class FakeUnitOfWork : IUnitOfWork
    {
        private readonly WebShopContext _context;

        public FakeUnitOfWork(DbContextOptions options)
        {
            _context = new WebShopContext(options); ;
            Category = new CategoryRepo(_context);
            Product = new FakeProductRepo(_context);
            Order = new FakeOrderRepo(_context);

        }
        public ICategoryRepo Category { get; private set; }
        public IProductRepo Product { get; private set; }
        public IOrderRepo Order { get; private set; }
        public FakeCORSRepo CORS { get; private set; }
    }
}

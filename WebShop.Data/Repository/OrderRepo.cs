using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebShop.API.Models;
using WebShop.Data.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.Data.Repository
{
    class OrderRepo : Repository<ORDER>, IOrderRepo
    {
        private readonly WebShopContext _context;
        public OrderRepo(WebShopContext context) : base(context)
        {
            _context = context;
        }


        public async Task<ORDER> CreateOrderAsync(ORDER order)
        {
            var result = await  _context.AddAsync(order);
            await _context.SaveChangesAsync();

            result.Entity.OrderId = order.OrderId;

            return result.Entity;
        }

        public string GetOrdersByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public ORDER GetOrderByIdAsync(int orderId)
        {
            return _context.ORDERS.Where(x => x.OrderId == orderId).Include("OrderRecords").FirstOrDefault();
        }

        public async override Task<ORDER> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

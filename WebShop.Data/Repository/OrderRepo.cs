using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<ORDER>> GetOrdersByUserIdAsync(string userId)
        {
            var result = await _context.ORDERS.Where(o => o.UserId == userId).Include("OrderRecords").Include("OrderStatus").ToListAsync();

            return result;
        }

        public ORDER GetOrderByIdAsync(int orderId)
        {
            return _context.ORDERS.Where(x => x.OrderId == orderId).Include("OrderRecords").Include("OrderStatus").FirstOrDefault();
        }

        public async override Task<ORDER> GetAsync(int id)
        {
            return await _context.ORDERS.Where(x => x.OrderId == id).FirstAsync();
        }

        public async Task<ORDER_STATUS> GetOrderStatus(string text)
        {
            var result = await _context.ORDER_STATUS.Where(x => x.OrderStatusText == text).SingleAsync();

            return result;
        }
    }
}

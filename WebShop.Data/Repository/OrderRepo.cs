using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public string GetAllOrdersByUser(string userId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ORDER> GetOrderByOrderId(int orderId)
        {
            return _context.ORDERS.Where(x => x.OrderId == orderId).Include("OrderRecords").ToList();
        }
    }
}

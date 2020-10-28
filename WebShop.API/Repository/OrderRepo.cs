using Microsoft.EntityFrameworkCore;
using System;
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


        public ORDER CreateOrder(ORDER order)
        {
            var result = _context.Add(order);

            _context.SaveChanges();

            return result.Entity;
        }

        public string GetAllOrdersByUser(string userId)
        {
            throw new System.NotImplementedException();
        }

        public ORDER GetOrderByOrderId(int orderId)
        {
            return _context.ORDERS.Where(x => x.OrderId == orderId).Include("OrderRecords").FirstOrDefault();
        }

        public override ORDER Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}

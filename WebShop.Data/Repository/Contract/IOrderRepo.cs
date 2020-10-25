using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data.Models;

namespace WebShop.Data.Repository.Contract
{
    public interface IOrderRepo : IRepository<ORDER>
    {
        public string GetAllOrdersByUser(string userId);

        public ORDER GetOrderByOrderId(int orderId);
    }
}

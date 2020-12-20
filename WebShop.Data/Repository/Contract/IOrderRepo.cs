using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.Data.Repository.Contract
{
    public interface IOrderRepo : IRepository<ORDER>
    {
        public Task<ORDER> CreateOrderAsync(ORDER order);
        public Task<IEnumerable<ORDER>> GetOrdersByUserIdAsync(string userId);

        public ORDER GetOrderByIdAsync(int orderId);
    }
}

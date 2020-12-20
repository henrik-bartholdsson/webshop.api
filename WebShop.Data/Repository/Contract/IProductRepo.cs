using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.API.Models;

namespace WebShop.Data.Repository.Contract
{
    public interface IProductRepo : IRepository<PRODUCT>
    {
        Task<IEnumerable<PRODUCT>> GetAllinCategoryAsync(int productId);
    }
}

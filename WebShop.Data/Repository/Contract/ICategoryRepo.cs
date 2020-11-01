using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.API.Models;

namespace WebShop.Data.Repository.Contract
{
    public interface ICategoryRepo : IRepository<CATEGORIES>
    {
        Task<IEnumerable<CATEGORIES>> GetAllNestedCategoriesAsync();
    }
}

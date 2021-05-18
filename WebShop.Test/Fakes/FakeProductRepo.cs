using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.API.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.Data.Repository
{
    class FakeProductRepo : FakeRepository<PRODUCT> ,IProductRepo
    {
        private readonly WebShopContext _context;
        public FakeProductRepo(WebShopContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PRODUCT>> GetAllinCategoryAsync(int productId)
        {
            return await _context.PRODUCT.Where(p => p.PARENT_CATEGORY_ID == productId).ToListAsync();
        }
    }
}

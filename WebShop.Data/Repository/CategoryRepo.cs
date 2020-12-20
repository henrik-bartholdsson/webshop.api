using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.API.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.Data.Repository
{
    class CategoryRepo : Repository<CATEGORIES>,ICategoryRepo
    {
        private readonly WebShopContext _context;
        public CategoryRepo(WebShopContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CATEGORIES>> GetAllNestedCategoriesAsync()
        {
            return await _context.CATEGORY.Where(c => c.PARENT_ID == null).Include("SUBCATEGORIES").ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.API.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.Data.Repository
{
    class ProductRepo : Repository<PRODUCT> ,IProductRepo
    {
        private readonly WebShopContext _context;
        public ProductRepo(WebShopContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<PRODUCT> GetAllByProduct(int productId)
        {
            return _context.PRODUCT.Where(p => p.PARENT_CATEGORY_ID == productId).ToList();
        }
    }
}

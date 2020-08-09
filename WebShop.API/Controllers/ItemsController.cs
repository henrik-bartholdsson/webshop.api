using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebShop.API.Models;

namespace WebShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly WebShopContext _context;
        public ItemsController(WebShopContext context)
        {
            _context = context;
        }
        public IEnumerable<Item> Get()
        {
            var allItems = _context.Items;



            return allItems;
        }
    }
}

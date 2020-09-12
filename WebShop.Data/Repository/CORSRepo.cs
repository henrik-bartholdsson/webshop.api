using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebShop.API.Models;

namespace WebShop.Data.Repository
{
    public class CORSRepo
    {
        private readonly WebShopContext _context;
        public CORSRepo(WebShopContext context)
        {
            _context = context;
        }

        public string[] GetAllActiveCors()
        {
            var activeCors = _context.CORS.Where(cors => cors.ACTIVE).ToList();
            return activeCors.Select(c => c.ADDRESS).ToArray();
        }
    }
}

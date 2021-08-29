﻿using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebShop.API.Models;

namespace WebShop.Data.Repository
{
    public class FakeCORSRepo
    {
        private readonly WebShopContext _context;
        public FakeCORSRepo(WebShopContext context)
        {
            _context = context;
        }

        public async Task<string[]> GetAllActiveCorsAsync()
        {
            var activeCors = await _context.CORS.Where(cors => cors.ACTIVE).ToListAsync();
            return activeCors.Select(c => c.ADDRESS).ToArray();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.API.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.Data.Repository
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly WebShopContext _context;

        public Repository(WebShopContext context)
        {
            _context = context;
        }

        virtual public async void AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        virtual public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        virtual public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        virtual public async void RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

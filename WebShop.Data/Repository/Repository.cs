﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
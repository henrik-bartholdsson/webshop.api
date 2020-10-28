using System;
using System.Collections.Generic;
using System.Text;
using WebShop.API.Models;

namespace WebShop.Data.Repository.Contract
{
    public interface ICategoryRepo : IRepository<CATEGORIES>
    {
        IEnumerable<CATEGORIES> GetAllNestedCategories();
    }
}

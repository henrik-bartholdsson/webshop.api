using System;
using System.Collections.Generic;
using System.Text;
using WebShop.API.Models;

namespace WebShop.Data.Repository.Contract
{
    public interface IProductRepo : IRepository<PRODUCT>
    {
        IEnumerable<PRODUCT> GetAllByProduct(int productId);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WebShop.API.Models;

namespace WebShop.Data.Repository.Contract
{
    public interface IUnitOfWork
    {
        ICategoryRepo Category { get; }
        IProductRepo Product { get; }
        CORSRepo CORS { get; }

    }
}

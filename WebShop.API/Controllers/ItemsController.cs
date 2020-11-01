using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShop.API.Models;
using WebShop.Data.Models.Dto;
using WebShop.Data.Models.Mapper;
using WebShop.Data.Repository.Contract;

namespace WebShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        
        private readonly IUnitOfWork _unitOfWork;
        public ItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<ProductDto> Get(int category)
        {
            var mapper = new DtoMapper();
            var products = _unitOfWork.Product.GetAsync(category).Result;
            var p2 = new List<PRODUCT>(); // Ta bort denna och gör rätt.
            p2.Add(products); // Ta bort denna och gör rätt.
            var productsDto = mapper.Products(p2);

            return productsDto;
        }

    }
}

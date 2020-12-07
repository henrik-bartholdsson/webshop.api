using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShop.Data.Models.Dto;
using WebShop.Service.v1;

namespace WebShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        
        private readonly IServiceV1 _service;
        public ItemsController(IServiceV1 service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<ProductDto> Get(int category)
        {
            var response = _service.GetProductsInCategory(category);

            return response;
        }

    }
}

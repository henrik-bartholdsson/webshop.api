using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShop.API.Services;
using WebShop.Data.Models.Dto;

namespace WebShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IWebShopService _webShopService;
        public ItemsController(IWebShopService categoryService)
        {
            _webShopService = categoryService;
        }

        [HttpGet]
        public IEnumerable<ProductDto> Get(int category)
        {
            var allItems = _webShopService.GetProductsByCategoryId(category);

            return allItems;
        }

    }
}

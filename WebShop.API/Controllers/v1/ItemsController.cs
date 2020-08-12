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
        private readonly IWebShopService _categoryService;
        public ItemsController(IWebShopService categoryService)
        {
            _categoryService = categoryService;
        }
        public IEnumerable<ItemDto> Get()
        {
            var allItems = _categoryService.GetAllItems();

            return allItems;
        }
    }
}

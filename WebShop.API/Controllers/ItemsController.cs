using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShop.API.Services;
using WebShop.Data.Models.Dto;

namespace WebShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        public IEnumerable<ItemDto> Get()
        {
            var cat = new WebShopService();

            var allItems = cat.GetAllItems();



            return allItems;
        }
    }
}

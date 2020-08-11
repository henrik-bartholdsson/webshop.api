using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShop.API.Models;
using WebShop.API.Services;

namespace WebShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IWebShopService _categoryService;
        public CategoriesController()
        {
            _categoryService = new WebShopService();
        }

        public IEnumerable<CategoryDto> Get()
        {
            var categories = _categoryService.GetAllActiveCategories();

            return categories;
        }
    }
}

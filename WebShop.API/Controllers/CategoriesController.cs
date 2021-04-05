using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShop.API.Models;
using WebShop.Data.Repository.Contract;

namespace WebShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<CATEGORIES> Get()
        {
            var categories = _unitOfWork.Category.GetAllNestedCategoriesAsync().Result;

            return categories;
        }
    }
}

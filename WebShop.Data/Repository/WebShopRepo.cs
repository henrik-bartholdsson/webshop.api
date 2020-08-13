using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebShop.API.Models;
using WebShop.Data.Models.Dto;

namespace WebShop.API.Repository
{
    public interface IWebShopRepo
    {
        List<CategoryDto> GetAllCategories();
        List<ProductDto> GetAllProducts();
        List<CORS> GetAllCors();
        List<PRODUCT> GetItemsByCategoryId(int catId);
    }
    public class WebShopRepo : IWebShopRepo
    {
        private readonly WebShopContext _context;
        public WebShopRepo(DbContextOptions options)
        {
            _context = new WebShopContext(options);
        }

        public List<CategoryDto> GetAllCategories()
        {
            var categoriesDto = new List<CategoryDto>();
            var categories = _context.CATEGORY.ToList();


            foreach (var categorie in categories)
            {
                categoriesDto.Add(new CategoryDto()
                {
                    Active = categorie.ACTIVE,
                    Description = categorie.DESCRIPTION,
                    ParentId = categorie.PARENT_ID,
                    ProductId = categorie.PRODUCT_ID,
                    RedirectToId = categorie.REDIRECT_TO_ID,
                    SortOrder = categorie.SORT_ORDER,
                    Title = categorie.TITLE,
                });
            }

            return categoriesDto;
        }

        public List<ProductDto> GetAllProducts()
        {
            var allItems = _context.PRODUCT.ToList();
            var itemDto = new List<ProductDto>();

            foreach (var item in allItems)
            {
                itemDto.Add(new ProductDto
                {
                    Description = item.DESCRIPTION,
                    ExtraPrice = item.EXTRA_PRICE,
                    ExtraPriceActive = item.EXTRA_PRICE_ACTIVE,
                    Id = item.PRODUCT_ID,
                    Name = item.NAME,
                    Price = item.PRICE
                });
            }

            return itemDto;
        }

        public List<PRODUCT> GetItemsByCategoryId(int catId)
        {
            return _context.PRODUCT.Where(p => p.PARENT_CATEGORY_ID == catId).ToList();
        }

        public List<CORS> GetAllCors()
        {
            return _context.CORS.ToList();
        }
    }
}

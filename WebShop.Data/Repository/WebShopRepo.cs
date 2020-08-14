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
        List<ProductDto> GetProductsByCategoryId(int catId);
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

            return ConvertToProductDto(allItems);
        }

        public List<ProductDto> GetProductsByCategoryId(int catId)
        {
            var products = _context.PRODUCT.Where(p => p.PARENT_CATEGORY_ID == catId).ToList();

            return ConvertToProductDto(products);
        }

        public List<CORS> GetAllCors()
        {
            return _context.CORS.ToList();
        }





        #region Private methods
        private static List<ProductDto> ConvertToProductDto(List<PRODUCT> products)
        {
            var _products = new List<ProductDto>();

            foreach (var p in products)
            {
                _products.Add(new ProductDto()
                {
                    Description = p.DESCRIPTION,
                    ExtraPrice = p.EXTRA_PRICE,
                    ExtraPriceActive = p.EXTRA_PRICE_ACTIVE,
                    Id = p.PRODUCT_ID,
                    Name = p.NAME,
                    Price = p.PRICE,
                    Category_id = p.PARENT_CATEGORY_ID,
                });
            }

            return _products;
        }








        #endregion
    }
}

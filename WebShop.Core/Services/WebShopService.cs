using System;
using System.Collections.Generic;
using System.Linq;
using WebShop.API.Models;
using WebShop.API.Repository;
using WebShop.Data.Models.Dto;

namespace WebShop.API.Services
{
    public interface IWebShopService
    {
        List<CategoryDto> GetAllActiveCategories();
        List<ProductDto> GetAllProducts();
        List<ProductDto> GetProductsByCategoryId(int catId);
        string[] GetListOfAllActiveCors();
    }
    public class WebShopService : IWebShopService
    {
        private readonly IWebShopRepo _categoryRepo;
        public WebShopService(IWebShopRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }


        public List<CategoryDto> GetAllActiveCategories()
        {
            var returnCategories = new List<CategoryDto>();
            var allCategories = _categoryRepo.GetAllCategories();

            foreach(var category in allCategories)
            {
                if (category.Active == false)
                    continue;

                returnCategories.Add(category);
            }

            return MergeCategories(returnCategories);
        }

        public List<ProductDto> GetAllProducts()
        {
            return _categoryRepo.GetAllProducts();
        }

        public List<ProductDto> GetProductsByCategoryId(int catId)
        {
            var categoryProducts = _categoryRepo.GetItemsByCategoryId(catId);

            return ConvertToProductDto(categoryProducts);
        }

        public string[] GetListOfAllActiveCors()
        {
            var allcors = _categoryRepo.GetAllCors();

                var allActiveCors = allcors.Where(cors => cors.ACTIVE == true && !String.IsNullOrEmpty(cors.ADDRESS) && !cors.ADDRESS.Contains("*")).ToList();
                var allActiveCorsAsList = allActiveCors.Select(c => c.ADDRESS).ToArray();

                return allActiveCorsAsList;
        }


        #region Private methods

        private static List<CategoryDto> MergeCategories(List<CategoryDto> categories, int? id = null)
        {
            var result = categories.Where(c => c.ParentId == id).ToList();

            foreach (var category in result)
            {
                category.SubCategories = MergeCategories(categories, category.ProductId);
            }

            return result;
        }

        private static List<ProductDto> ConvertToProductDto(List<PRODUCT> products)
        {
            var _products = new List<ProductDto>();

            foreach(var p in products)
            {
                _products.Add(new ProductDto() {
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

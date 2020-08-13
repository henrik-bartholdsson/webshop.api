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
        List<ItemDto> GetAllItems();
        List<ItemDto> GetProductsByCategoryId(int catId);
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

        public List<ItemDto> GetAllItems()
        {
            return _categoryRepo.GetAllItems();
        }

        public List<ItemDto> GetProductsByCategoryId(int catId)
        {
            var a = _categoryRepo.GetItemsByCategoryId(catId);

            var b = ConvertProductToProductDto(a);

            return b;
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

        private static List<ItemDto> ConvertProductToProductDto(List<PRODUCT> products)
        {
            var _products = new List<ItemDto>();

            foreach(var proddut in products)
            {
                _products.Add(new ItemDto() {
                    Description = proddut.DESCRIPTION,
                    ExtraPrice = proddut.EXTRA_PRICE,
                    ExtraPriceActive = proddut.EXTRA_PRICE_ACTIVE,
                    Id = proddut.PRODUCT_ID,
                    Name = proddut.NAME,
                    Price = proddut.PRICE,
                });
            }

            return _products;
        }

        #endregion
    }
}

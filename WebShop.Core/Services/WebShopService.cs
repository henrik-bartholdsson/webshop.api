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

        public string[] GetListOfAllActiveCors()
        {
            var allcors = _categoryRepo.GetAllCors();

                var allActiveCors = allcors.Where(cors => cors.ACTIVE == true && !String.IsNullOrEmpty(cors.ADDRESS) && !cors.ADDRESS.Contains("*")).ToList();
                var allActiveCorsAsList = allActiveCors.Select(c => c.ADDRESS).ToArray();

                return allActiveCorsAsList;
        }


        #region Private methods
        private static List<CategoryDto> MergeCategories(List<CategoryDto> categories)
        {
            var categoryList = new List<CategoryDto>();

            categoryList = categories.Where(c => c.ParentId == 0 || c.ParentId == null).ToList();

            foreach (var category in categoryList)
            {
                category.SubCategories = categories.Where(c => c.ParentId == category.ProductId).ToList();
            }

            return categoryList;
        }

        #endregion
    }
}

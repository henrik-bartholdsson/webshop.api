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
            var returnCategories = _categoryRepo.GetAllCategories().Where(c => c.Active == true).ToList();


            return MergeCategories(returnCategories);
        }

        public List<ProductDto> GetProductsByCategoryId(int id)
        {
            if (id == 0)
                return _categoryRepo.GetAllProducts();

            return _categoryRepo.GetProductsByCategoryId(id);
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
                category.SubCategories = MergeCategories(categories, category.Id);
            }

            return result;
        }





        #endregion
    }
}

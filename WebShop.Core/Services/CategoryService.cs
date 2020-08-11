using System.Collections.Generic;
using System.Linq;
using WebShop.API.Models;
using WebShop.API.Repository;
using WebShop.Data.Models.Dto;

namespace WebShop.API.Services
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAllActiveCategories();
        List<ItemDto> GetAllItems();
    }
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryService()
        {
            _categoryRepo = new CategoryRepo();
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
            var _categoryRepo = new CategoryRepo();
            return _categoryRepo.GetAllItems();
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

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using WebShop.API.Models;
using WebShop.API.Repository;

namespace WebShop.API.Services
{
    public interface ICategoryService
    {
        List<CategoryDto> GetActiveCategories();
    }
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }


        public List<CategoryDto> GetActiveCategories()
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
    }
}

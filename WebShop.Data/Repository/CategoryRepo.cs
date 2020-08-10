using System.Collections.Generic;
using WebShop.API.Models;

namespace WebShop.API.Repository
{
    public interface ICategoryRepo
    {
        List<CategoryDto> GetAllCategories();
    }
    public class CategoryRepo : ICategoryRepo
    {
        private readonly WebShopContext _context;
        public CategoryRepo(WebShopContext context)
        {
            _context = context;
        }

        public List<CategoryDto> GetAllCategories()
        {
            var categoriesDto = new List<CategoryDto>();
            var categories = _context.Category;


                foreach (var categorie in categories)
                {
                    categoriesDto.Add(new CategoryDto()
                    {
                        Active = categorie.ACTIVE,
                        Description = categorie.DESCRIPTION,
                        ParentId = categorie.PARENT_ID,
                        ProductId = categorie.PRODUCT_ID,
                        ProjectId = categorie.PROJECT_ID,
                        RedirectToId = categorie.REDIRECT_TO_ID,
                        SortOrder = categorie.SORT_ORDER,
                        Title = categorie.TITLE,
                        TypId = categorie.TYPE_ID
                    });
                }

            return categoriesDto;
        }
    }
}

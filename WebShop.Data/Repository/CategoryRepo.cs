using System.Collections.Generic;
using System.Linq;
using WebShop.API.Models;
using WebShop.Data.Models.Dto;

namespace WebShop.API.Repository
{
    public interface ICategoryRepo
    {
        List<CategoryDto> GetAllCategories();
        List<ItemDto> GetAllItems();
    }
    public class CategoryRepo : ICategoryRepo
    {
        private readonly WebShopContext _context;
        public CategoryRepo()
        {
            _context = new WebShopContext(); // Använd using istället
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
                    ProjectId = categorie.PROJECT_ID,
                    RedirectToId = categorie.REDIRECT_TO_ID,
                    SortOrder = categorie.SORT_ORDER,
                    Title = categorie.TITLE,
                    TypId = categorie.TYPE_ID
                });
            }

            return categoriesDto;
        }

        public List<ItemDto> GetAllItems()
        {
            using (var context = new WebShopContext())
            {
                var allItems = context.PRODUCT.ToList();
                var itemDto = new List<ItemDto>();

                foreach (var item in allItems)
                {
                    itemDto.Add(new ItemDto
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
        }
    }
}

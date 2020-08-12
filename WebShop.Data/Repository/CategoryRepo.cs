using Microsoft.EntityFrameworkCore;
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
        List<CORS> GetAllCors();
    }
    public class CategoryRepo : ICategoryRepo
    {
        private readonly WebShopContext _context;
        public CategoryRepo(DbContextOptions options)
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

        public List<ItemDto> GetAllItems()
        {
            var allItems = _context.PRODUCT.ToList();
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

        public List<CORS> GetAllCors()
        {
            return _context.CORS.ToList();
        }

    }
}

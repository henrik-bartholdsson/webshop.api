using System.Collections.Generic;
using WebShop.API.Models;
using WebShop.Data.Models.Dto;

namespace WebShop.Data.Models.Mapper
{
    public class DtoMapper
    {
        public ProductDto Product(PRODUCT _product)
        {
            return new ProductDto()
            {
                Category_id = _product.PARENT_CATEGORY_ID,
                Description = _product.DESCRIPTION,
                ExtraPrice = _product.EXTRA_PRICE,
                ExtraPriceActive = _product.EXTRA_PRICE_ACTIVE,
                Id = _product.ID,
                Name = _product.NAME,
                Price = _product.PRICE
            };
        }

        public IEnumerable<ProductDto> Products(IEnumerable<PRODUCT> _products)
        {
            List<ProductDto> products = new List<ProductDto>();

            foreach (var p in _products)
            {
                products.Add(new ProductDto()
                {
                    Category_id = p.PARENT_CATEGORY_ID,
                    Description = p.DESCRIPTION,
                    ExtraPrice = p.EXTRA_PRICE,
                    ExtraPriceActive = p.EXTRA_PRICE_ACTIVE,
                    Id = p.ID,
                    Name = p.NAME,
                    Price = p.PRICE

                });
            };

            return products;
        }
    }
}

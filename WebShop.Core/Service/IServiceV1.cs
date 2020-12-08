using System.Collections.Generic;
using WebShop.Contracts.v1.Requests;
using WebShop.Data.Models.Dto;

namespace WebShop.Service.v1
{
    public interface IServiceV1
    {
        OrderDto CreateOrder(RequestOrderDto order);
        OrderDto GetOrder(int id, string userId);
        IEnumerable<OrderDto> GetAllOrders(string userId);
        IEnumerable<ProductDto> GetProductsInCategory(int categoryId);
    }
}

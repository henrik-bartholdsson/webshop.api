using WebShop.Contracts.v1.Requests;
using WebShop.Contracts.v1.Responses;
using WebShop.Data.Models;
using WebShop.Data.Models.Dto;
using WebShop.Data.Repository.Contract;

namespace WebShop.Service.v1
{
    public interface IOrderService
    {
        bool ValidateOrderInput(OrderInputDto input);

        ORDER BuildOrder(RequestOrder input);
        ResponseOrder CreateResponse(ORDER order);
        ORDER CreateOrder(ORDER order);
    }
}

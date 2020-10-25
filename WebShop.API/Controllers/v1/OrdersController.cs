using Microsoft.AspNetCore.Mvc;
using WebShop.Core.Service;
using WebShop.Data.Models.Dto;
using WebShop.Data.Repository.Contract;

namespace WebShop.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrdersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetOrder(int id)
        {
            if (id == 0)
                return BadRequest();

            var orders = _unitOfWork.Order.GetOrderByOrderId(id);

            if (orders == null)
                return NotFound();

            return Ok(orders);
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody]OrderInputDto input)
        {
            var service = new OrderService();
            var order = service.InputOrderToDomainModel(input);

            _unitOfWork.Order.Add(order);


            return Ok(order);
        }

        // throw new ValidationException("Invalid input, missing data.");

        // return Request.CreateResponse(HttpStatusCode.InternalServerError);

        //[HttpPost]
        //public void CreateOrders()
        //{
        //    var recAA = new ORDERRECORD { ItemName = "Hårddisk", ItemId = 1, Price= 123.3, ProductId = 123 };
        //    var recAB = new ORDERRECORD { ItemName = "SSD", ItemId = 2, Price = 244.9, ProductId = 312 };
        //    var orderA = new ORDER();
        //    orderA.OrderRecords = new List<ORDERRECORD>();
        //    orderA.OrderRecords.Add(recAA);
        //    orderA.OrderRecords.Add(recAB);
        //    orderA.UserId = "abc";
        //    orderA.OrderInfo = "En order på lite saker";
        //    _unitOfWork.Order.Add(orderA);

        //}
    }
}

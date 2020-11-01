using Microsoft.AspNetCore.Mvc;
using System;
using WebShop.Contracts.v1.Requests;
using WebShop.Core.Service;
using WebShop.Data.Models;
using WebShop.Data.Models.Dto;
using WebShop.Data.Repository.Contract;
using WebShop.Service.v1;

namespace WebShop.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderService _orderService;

        public OrdersController(IUnitOfWork unitOfWork, IOrderService orderService)
        {
            _unitOfWork = unitOfWork;
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetOrder(int id)
        {
            if (id == 0)
                return BadRequest();

            var orders = _unitOfWork.Order.GetOrderByIdAsync(id);

            if (orders == null)
                return NotFound("Not found");

            return Ok(orders);
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody]RequestOrder requestOrder)
        {
            ORDER order;

            try
            {
                order = _orderService.BuildOrder(requestOrder);
                _orderService.CreateOrder(order);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var responce = _orderService.CreateResponse(order);

            return Ok(responce);
        }

        // return Request.CreateResponse(HttpStatusCode.InternalServerError);

    }
}

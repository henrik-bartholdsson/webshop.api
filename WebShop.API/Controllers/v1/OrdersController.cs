using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Data.Models;
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
        public IEnumerable<ORDER> GetOrder(int id)
        {
            var orders = _unitOfWork.Order.GetOrderByOrderId(id);

            // Use UnitOfWork

            return orders;
        }

        [HttpPost]
        public void CreateOrders()
        {
            var recAA = new ORDERRECORD { ItemName = "Hårddisk", ItemId = 1, Price= 123.3, ProductId = 123 };
            var recAB = new ORDERRECORD { ItemName = "SSD", ItemId = 2, Price = 244.9, ProductId = 312 };
            var orderA = new ORDER();
            orderA.OrderRecords = new List<ORDERRECORD>();
            orderA.OrderRecords.Add(recAA);
            orderA.OrderRecords.Add(recAB);
            orderA.UserId = "abc";
            orderA.OrderInfo = "En order på lite saker";
            _unitOfWork.Order.Add(orderA);
            
        }
    }
}

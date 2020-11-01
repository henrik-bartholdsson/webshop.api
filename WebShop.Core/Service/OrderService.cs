using System;
using System.Collections.Generic;
using WebShop.Contracts.v1.Requests;
using WebShop.Contracts.v1.Responses;
using WebShop.Data.Models;
using WebShop.Data.Models.Dto;
using WebShop.Data.Repository.Contract;
using WebShop.Service.v1;

namespace WebShop.Core.Service
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool ValidateOrderInput(OrderInputDto input)
        {
            // Check if orderrId exist in local List of ints
            // If not
            // Check if orderId exist in db and is active
            // If not - return error
            // else save in local list and go to nex iteration
            // If so goto nex iteration


            // if all good return true

            return true;
        }


        public ORDER BuildOrder(RequestOrder input)
        {
            List<ORDERRECORD> recordList = new List<ORDERRECORD>();
            int itemId = 0;

            foreach (var rec in input.Items)
            {
                itemId++;
                var item = _unitOfWork.Product.GetAsync(rec);

                if(item == null)
                    throw new Exception("Invalid input, bad item(s).");


                var orderRecord = new ORDERRECORD
                {
                    ItemName = item.NAME,
                    OrderItemSequence = itemId,
                    ProductId = item.ID
                };

                if (item.EXTRA_PRICE_ACTIVE)
                    orderRecord.Price = item.EXTRA_PRICE;
                else
                    orderRecord.Price = item.PRICE;

                recordList.Add(orderRecord);
            }

            var order = new ORDER() { OrderRecords = new List<ORDERRECORD>() };

            order.OrderInfo = input.OrderInfo;
            order.OrderRecords = recordList;

            return order;
        }

        public ResponseOrder CreateResponse(ORDER order)
        {
            var responseOrder = new ResponseOrder
            {
                OrderInfo = order.OrderInfo,
                OrderId = order.OrderId.ToString()
            };

            responseOrder.Items = new List<OrderRecord>();

            foreach(var i in order.OrderRecords)
            {
                responseOrder.Items.Add(new OrderRecord { ListNumber = i.OrderItemSequence, Name = i.ItemName, Price = i.Price });
            }
    
            return responseOrder;
        }

        public ORDER CreateOrder(ORDER order)
        {
            var response = _unitOfWork.Order.CreateOrderAsync(order);

            return response;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data.Models;
using WebShop.Data.Models.Dto;

namespace WebShop.Core.Service
{
    public class OrderService
    {
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


        public ORDER InputOrderToDomainModel(OrderInputDto input)
        {
            var order = new ORDER() { OrderRecords = new List<ORDERRECORD>() };
            order.OrderInfo = input.OrderInfo;

            foreach (var item in input.Items)
            {
                order.OrderRecords.Add(new ORDERRECORD { ProductId = item, ItemName = $"Hej {item}" });
            }

            return order;
        }
    }
}

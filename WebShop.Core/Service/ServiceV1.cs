using System;
using System.Collections.Generic;
using WebShop.API.Models;
using WebShop.Contracts.v1.Requests;
using WebShop.Data.Models;
using WebShop.Data.Models.Dto;
using WebShop.Data.Repository.Contract;
using WebShop.Service.v1;

namespace WebShop.Core.Service
{
    public class ServiceV1 : IServiceV1
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceV1(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public OrderDto CreateOrder(RequestOrderDto requestOrder) // Kolla så att användaren som skapar ordern finns.
        {
            ValidateOrderInput(requestOrder);

            var order = BuildOrder(requestOrder);
            var response = _unitOfWork.Order.CreateOrderAsync(order);

            var a = ConvertOrder(response.Result);

            return a;
        }


        public OrderDto GetOrder(int id, string userId)
        {
            var order = _unitOfWork.Order.GetOrderByIdAsync(id);

            if (order == null)
                throw new Exception("Bad request. Order not found");

            if (order.UserId != userId)
                throw new Exception("Unauthorized");

            var result = ConvertOrder(order);

            return result;
        }

        public IEnumerable<OrderDto> GetAllOrders(string userId)
        {
            var lista = _unitOfWork.Order.GetOrdersByUserIdAsync(userId).Result;
            var orders = new List<OrderDto>();

            if (lista == null)
                throw new Exception("No orders found");

            foreach(var o in lista)
            {
                orders.Add(ConvertOrder(o));
            }

            return orders;
        }


        public IEnumerable<ProductDto> GetProductsInCategory(int categoryId)
        {
            var products = _unitOfWork.Product.GetAllinCategoryAsync(categoryId).Result;
            var _products = ConvertProducts(products);

            return _products;
        }







        #region Private Methods

        private ORDER BuildOrder(RequestOrderDto order)
        {
            var result = new ORDER
            {
                OrderInfo = order.OrderInfo,
                OrderRecords = new List<ORDERRECORD>(),
                UserId = order.UserId
            };

            foreach (var item in order.Items)
            {
                var product = _unitOfWork.Product.GetAsync(item).Result;

                if (product == null)
                    throw new Exception($"Product {item} not found");

                result.OrderRecords.Add(
                    new ORDERRECORD
                    {
                        ItemName = product.NAME,
                        Price = product.EXTRA_PRICE_ACTIVE ? product.EXTRA_PRICE : product.PRICE,
                        ProductId = product.ID
                    });
            };



            return result;
        }


        private void ValidateOrderInput(RequestOrderDto order)
        {
            if (order == null)
                throw new Exception("Bad input");

            if (order.Items == null)
                throw new Exception("Empty order");

            if (order.Items.Count < 1)
                throw new Exception("Empty order");

            if (String.IsNullOrEmpty(order.OrderInfo) || order.OrderInfo.Length < 4)
                throw new Exception("Order info not set.");
        }

        #endregion





        #region Private Static Converters

        private static IEnumerable<ProductDto> ConvertProducts(IEnumerable<PRODUCT> products)
        {
            var result = new List<ProductDto>();

            foreach (var p in products)
            {
                result.Add(new ProductDto
                {
                    Category_id = p.PARENT_CATEGORY_ID,
                    Description = p.DESCRIPTION,
                    ExtraPrice = p.EXTRA_PRICE,
                    ExtraPriceActive = p.EXTRA_PRICE_ACTIVE,
                    Id = p.ID,
                    Name = p.NAME,
                    Price = p.PRICE,
                });
            }

            return result;
        }


        private static OrderDto ConvertOrder(ORDER order)
        {
            var result = new OrderDto
            {
                OrderInfo = order.OrderInfo,
                OrderId = order.OrderId,
                Items = new List<Dto.OrderRecordDto>(),
            };

            foreach (var r in order.OrderRecords)
            {
                result.Items.Add(new Dto.OrderRecordDto
                {
                    ItemName = r.ItemName,
                    OrderItemSequence = r.OrderItemSequence,
                    Price = r.Price,
                    ProductId = r.ProductId
                });
            }

            return result;
        }



        #endregion
    }
}

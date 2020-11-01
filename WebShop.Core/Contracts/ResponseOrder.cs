using System.Collections.Generic;

namespace WebShop.Contracts.v1.Responses
{
    public class ResponseOrder
    {
        public List<OrderRecord> Items { get; set; }
        public string OrderInfo { get; set; }
        public string OrderId { get; set; }
    }

    public class OrderRecord
    {
        public int ListNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

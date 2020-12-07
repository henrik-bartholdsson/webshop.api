using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebShop.Contracts.v1.Requests
{
    public class RequestOrderDto
    {
        public List<int> Items { get; set; }
        public string OrderInfo { get; set; }
        public string UserId { get; set; }
    }
}

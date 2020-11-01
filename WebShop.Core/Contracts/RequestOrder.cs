using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebShop.Contracts.v1.Requests
{
    public class RequestOrder
    {
        [JsonProperty(PropertyName = "Items")]
        public List<int> Items { get; set; }
        [JsonProperty(PropertyName = "OrderInfo")]
        public string OrderInfo { get; set; }
    }
}

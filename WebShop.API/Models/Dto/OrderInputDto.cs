using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebShop.Data.Models.Dto
{
    public class OrderInputDto
    {
        [JsonProperty(PropertyName = "Items")]
        public List<int> Items { get; set; }
        [JsonProperty(PropertyName = "OrderInfo")]
        public string OrderInfo { get; set; }
    }
}

using System.Collections.Generic;
using WebShop.Core.Dto;

namespace WebShop.Data.Models.Dto
{
    public class OrderDto
    {
        public List<OrderRecordDto> Items { get; set; }
        public string OrderInfo { get; set; }
        public int OrderId { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Data.Models
{
    public class ORDER
    {
        [Key]
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public string OrderInfo { get; set; }
        public virtual List<ORDERRECORD> OrderRecords { get; set; }
        public virtual ORDER_STATUS OrderStatus { get; set; }
    }
}

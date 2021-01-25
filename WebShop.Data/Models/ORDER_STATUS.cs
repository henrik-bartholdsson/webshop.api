using System.ComponentModel.DataAnnotations;

namespace WebShop.Data.Models
{
    public class ORDER_STATUS
    {
        [Key]
        public int OrderStatusId { get; set; }
        public string OrderStatusText { get; set; }
    }
}

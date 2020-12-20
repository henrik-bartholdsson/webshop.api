using System.ComponentModel.DataAnnotations;

namespace WebShop.Data.Models
{
    public class ORDERRECORD
    {
        [Key]
        public int OrderRecordId { get; set; }
        public int OrderItemSequence { get; set; }
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public virtual ORDER Order { get; set; }
    }
}

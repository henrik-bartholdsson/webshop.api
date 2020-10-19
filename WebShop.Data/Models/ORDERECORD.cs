using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Data.Models
{
    public class ORDERECORD
    {
        [Key]
        public int OrderRecordId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public int ItemId { get; set; } // Post id on the order, forst post have 1, second have 2, and so on.
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
    }
}

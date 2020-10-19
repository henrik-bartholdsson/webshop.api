using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebShop.API.Models;

namespace WebShop.Data.Models
{
    public class ORDER
    {
        [Key]
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public ICollection<ORDERECORD> OrderRecords { get; set; }
    }
}

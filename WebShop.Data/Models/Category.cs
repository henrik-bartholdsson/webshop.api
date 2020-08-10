using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.API.Models
{
    public class Category
    {
        [Key]
        public int PRODUCT_ID { get; set; }
        public int? PROJECT_ID { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public int SORT_ORDER { get; set; }
        public int TYPE_ID { get; set; }
        public int? PARENT_ID { get; set; }
        public int? REDIRECT_TO_ID { get; set; }
        public bool ACTIVE { get; set; }
    }
}

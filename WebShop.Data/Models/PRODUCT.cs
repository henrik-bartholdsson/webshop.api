using System.ComponentModel.DataAnnotations;

namespace WebShop.API.Models
{
    public class PRODUCT
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int PRICE { get; set; }
        public int EXTRA_PRICE { get; set; }
        public bool EXTRA_PRICE_ACTIVE { get; set; }
        public int PARENT_CATEGORY_ID { get; set; }
    }
}

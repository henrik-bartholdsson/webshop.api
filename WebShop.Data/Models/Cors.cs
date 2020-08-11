using System.ComponentModel.DataAnnotations;

namespace WebShop.API.Models
{
    public class CORS
    {
        [Key]
        public int ID { get; set; }
        public string ADDRESS { get; set; }
        public bool ACTIVE { get; set; }
        public string COMMENT { get; set; }
    }
}

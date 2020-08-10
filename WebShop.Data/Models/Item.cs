using System.ComponentModel.DataAnnotations;

namespace WebShop.API.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int ExtraPrice { get; set; }
        public bool ExtraPriceActive { get; set; }
    }
}

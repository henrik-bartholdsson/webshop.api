using System.ComponentModel.DataAnnotations;

namespace WebShop.API.Models
{
    public class Cors
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public bool Enabled { get; set; }
    }
}

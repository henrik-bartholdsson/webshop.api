using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.API.Models
{
    public class CATEGORIES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public int SORT_ORDER { get; set; }
        [ForeignKey("CATEGORIES")]
        public int? PARENT_ID { get; set; }
        public int? REDIRECT_TO_ID { get; set; }
        public bool ACTIVE { get; set; }
        [ForeignKey("PARENT_ID")]
        public List<CATEGORIES> SUBCATEGORIES { get; set; }
    }
}

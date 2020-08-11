using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Data.Models.Dto
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int ExtraPrice { get; set; }
        public bool ExtraPriceActive { get; set; }
    }
}

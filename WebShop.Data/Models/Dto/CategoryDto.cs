using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.API.Models
{
    public class CategoryDto
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public int? ParentId { get; set; }
        public int? RedirectToId { get; set; }
        public bool Active { get; set; }
        public List<CategoryDto> SubCategories { get; set; }
    }
}

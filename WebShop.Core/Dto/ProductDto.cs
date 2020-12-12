namespace WebShop.Data.Models.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int ExtraPrice { get; set; }
        public bool ExtraPriceActive { get; set; }
        public int Category_id { get; set; }
        public int Avalible { get; set; }
    }
}

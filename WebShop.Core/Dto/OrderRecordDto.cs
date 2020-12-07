namespace WebShop.Core.Dto
{
    public class OrderRecordDto
    {
        public int OrderItemSequence { get; set; }
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
    }
}

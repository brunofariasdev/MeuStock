namespace Stock.Models
{
    public class Product : Default
    {
        public int Price { get; set; }
        public int Stock { get; set; }
        public long UserId { get; set; }
        public long SupplierId { get; set; }
    }
}
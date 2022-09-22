namespace WebStar_.Models
{
    public class Product
    {
        public Product()
        {
            this.ProductImages = new HashSet<Images>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal StartPrice { get; set; }
        public decimal Price { get; set; }
        public double Rate { get; set; }
        public ICollection<Images> ProductImages { get; set; } = null!;
    }
}

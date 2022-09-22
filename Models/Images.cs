namespace WebStar_.Models
{
    public class Images
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Url { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}

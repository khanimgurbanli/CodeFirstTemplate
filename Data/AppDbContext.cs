using Microsoft.EntityFrameworkCore;
using WebStar_.Models;

namespace WebStar_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Images> Images { get; set; }
    }
}

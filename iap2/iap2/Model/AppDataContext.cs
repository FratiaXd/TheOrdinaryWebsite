using Microsoft.EntityFrameworkCore;

namespace iap2.Model
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}

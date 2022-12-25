using Electronics_Shop.Models.Product;
using Electronics_Shop.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Electronics_Shop.DataBaseContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<BuyProduct> BuyProducts { get; set; }
        public DbSet<Users> User { get; set; }
    }
}

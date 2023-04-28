using Microsoft.EntityFrameworkCore;
using MVCProduct.Models;

namespace MVCProduct.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


    }
}

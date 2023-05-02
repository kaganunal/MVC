using Microsoft.EntityFrameworkCore;
using MVCCategoriesandProductsSQL.Models;

namespace MVCCategoriesandProductsSQL.Context
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddDummyData(modelBuilder);
            base.OnModelCreating(modelBuilder);

        }

        private void AddDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category(1, "Phone") { },
            new Category(2, "Computer") { },
            new Category(3, "Television") { }
            );
            modelBuilder.Entity<Product>().HasData(
            new Product() { Id = 1, Name = "Hp", Price = 30000, IsInStock = true, CategoryId = 2 },
            new Product() { Id = 2, Name = "MacBook", Price = 50000, IsInStock = true, CategoryId = 2 },
            new Product() { Id = 3, Name = "Apple", Price = 20000, IsInStock = true, CategoryId = 1 },
            new Product() { Id = 4, Name = "Xiaomi", Price = 12000, IsInStock = true, CategoryId = 1 },
            new Product() { Id = 5, Name = "Samsung", Price = 27500, IsInStock = true, CategoryId = 3 },
            new Product() { Id = 6, Name = "Vestel", Price = 32700, IsInStock = true, CategoryId = 3 }
            );
        }
    }
}

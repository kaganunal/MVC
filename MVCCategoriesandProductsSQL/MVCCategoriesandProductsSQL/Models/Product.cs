using System.ComponentModel.DataAnnotations;

namespace MVCCategoriesandProductsSQL.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, decimal price, bool ısInStock)
        {
            Id = id;
            Name = name;
            Price = price;
            IsInStock = ısInStock;
        }
        public Product()
        {

        }
    }
}

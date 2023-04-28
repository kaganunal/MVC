using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCProduct.Models
{
    public class Product
    {
        [Required]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be null! ")]
        [StringLength(25)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price cannot be null! ")]
        [Range(1, 150, ErrorMessage = "Please enter a value 1-150 TL!")]
        public decimal Price { get; set; }
        public bool IsInStock { get; set; }
        public Product(string name, decimal price, bool ınStock)
        {
            Name = name;
            Price = price;
            IsInStock = ınStock;
        }
        public Product()
        {

        }
    }
}

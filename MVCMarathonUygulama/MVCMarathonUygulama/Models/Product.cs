using System.ComponentModel.DataAnnotations;

namespace MVCMarathonUygulama.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        public string? PicturePath { get; set; }
        public List<Category> Categories { get; set; }
        public List<CartProduct> CartProducts { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}

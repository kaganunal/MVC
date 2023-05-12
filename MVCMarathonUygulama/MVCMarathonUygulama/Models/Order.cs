using System.ComponentModel.DataAnnotations;

namespace MVCMarathonUygulama.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public string Adress { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}

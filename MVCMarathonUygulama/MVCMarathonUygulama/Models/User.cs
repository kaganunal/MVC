using System.ComponentModel.DataAnnotations;

namespace MVCMarathonUygulama.Models
{
    public class User
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Password { get; set; }

        public string Adress { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
    }
}

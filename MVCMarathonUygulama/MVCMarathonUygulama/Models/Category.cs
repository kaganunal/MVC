using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCMarathonUygulama.Models
{
    public class Category
    {
        [DisplayName("ID")]
        [Key]
        public int Id { get; set; }

        [DisplayName("Category")]
        [Required]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}

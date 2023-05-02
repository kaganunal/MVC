using System.ComponentModel;

namespace MVCCategoriesandProductsSQL.Models
{
    public class Category
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Category")]

        public string Name { get; set; }

        public List<Product> Products { get; set; }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;

        }

        public Category()
        {

        }
    }
}

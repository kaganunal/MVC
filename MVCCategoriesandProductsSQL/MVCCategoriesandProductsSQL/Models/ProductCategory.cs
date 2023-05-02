using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCategoriesandProductsSQL.Models
{
    [NotMapped]
    public class ProductCategory
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Category> Categories { get; set; } = new List<Category>();

        public ProductCategory(List<Product> products, List<Category> categories)
        {
            Products = products;
            Categories = categories;
        }
        public ProductCategory()
        {

        }
    }
}

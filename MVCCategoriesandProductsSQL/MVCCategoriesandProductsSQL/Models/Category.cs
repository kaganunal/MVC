namespace MVCCategoriesandProductsSQL.Models
{
    public class Category
    {
        public int Id { get; set; }
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

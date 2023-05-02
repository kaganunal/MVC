namespace MVCCategoriesandProductsSQL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
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

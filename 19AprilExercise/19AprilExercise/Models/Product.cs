namespace _19AprilExercise.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public string Category { get; set; }

        public Product(int ıd, string name, int unitsInStock, string category)
        {
            Id = ıd;
            Name = name;
            UnitsInStock = unitsInStock;
            Category = category;
        }
        public Product()
        {

        }
    }
}

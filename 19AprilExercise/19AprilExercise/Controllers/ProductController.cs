using _19AprilExercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace _19AprilExercise.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new()
        {
            new Product
            {
                Id= 1,
                Name = "Legion-Y540",
                UnitsInStock= 15,
                Category = "Laptop"
            },
            new Product
            {
                Id= 2,
                Name = "Marshall-BT-400",
                UnitsInStock= 55,
                Category = "Headphone"
            },
            new Product
            {
                Id= 3,
                Name = "Rampage-SMX-G72",
                UnitsInStock= 0,
                Category = "Mouse"
            },
            new Product
            {
                Id= 4,
                Name = "Logitech-KB-87",
                UnitsInStock= 22,
                Category = "Keyboard"
            }

        };


        public IActionResult Index()
        {
            return View(products);
        }
    }
}

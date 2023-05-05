using Authentication_Identity_Area_Roles.Context;
using Authentication_Identity_Area_Roles.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Authentication_Identity_Area_Roles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _dbContext = new();
        public HomeController(ILogger<HomeController> logger, NorthwindContext northwindContext)
        {
            _logger = logger;
            //SOLID (D- Dependency Enjection)
            //DEPENDENCY ENJECTION
            _dbContext = northwindContext;
        }

        public IActionResult Index()
        {

            return View(_dbContext.Products.FirstOrDefault());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void Test1()
        {
            _dbContext.Products.Where(KontrolEt).FirstOrDefault();
        }

        public bool KontrolEt(Product prod)
        {
            return prod.ProductId == 1;
        }
        public void Test2()
        {

        }
    }
}
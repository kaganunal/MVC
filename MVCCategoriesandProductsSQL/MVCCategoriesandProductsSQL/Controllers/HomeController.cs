using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCategoriesandProductsSQL.Context;
using MVCCategoriesandProductsSQL.Models;
using System.Diagnostics;

namespace MVCCategoriesandProductsSQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsContext _context;
        public HomeController(ProductsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.Include(c => c.Products).ToListAsync();


            return View(categories);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Onur_Hoca_MVC.Models;
using System.Diagnostics;

namespace Onur_Hoca_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MyAction(string name)
        {
            name = "Oğuz Kağan Ünal";
            TempData["name"] = "Oğuz Kağan Ünal";
            ViewData["name"] = name;
            ViewBag.Name = name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
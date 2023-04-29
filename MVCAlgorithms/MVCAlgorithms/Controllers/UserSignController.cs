using Microsoft.AspNetCore.Mvc;
using MVCAlgorithms.Models;

namespace MVCAlgorithms.Controllers
{
    public class UserSignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            return View();
        }


    }
}

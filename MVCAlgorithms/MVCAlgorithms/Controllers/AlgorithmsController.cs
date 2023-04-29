using Microsoft.AspNetCore.Mvc;
using MVCAlgorithms.Models;

namespace MVCAlgorithms.Controllers
{
    public class AlgorithmsController : Controller
    {
        public IActionResult ShowDifferential()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowDifferential(Numbers numbers)
        {
            ViewBag.diff = numbers.Number2 - numbers.Number1;
            if (numbers.Number1 < numbers.Number2)
            {
                ViewBag.message = null;
            }
            else
            {
                ViewBag.message = "Üst limit alt limitten küçük veya eşit olamaz!";
            }
            return View();
        }
    }
}

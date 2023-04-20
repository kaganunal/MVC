using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace _18April.Controllers
{
    public class TekCift_AsalController : Controller
    {
        public IActionResult Index()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                numbers.Add(i);
            }
            return View(numbers);
        }
    }
}

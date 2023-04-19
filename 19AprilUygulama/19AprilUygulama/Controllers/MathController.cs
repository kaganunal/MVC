using Microsoft.AspNetCore.Mvc;

namespace _19AprilUygulama.Controllers
{
    public class MathController : Controller
    {

        public IActionResult Index()
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(i);
            }
            return View(sayilar);
        }
    }
}


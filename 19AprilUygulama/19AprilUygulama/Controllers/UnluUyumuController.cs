using _19AprilUygulama.Models;
using Microsoft.AspNetCore.Mvc;

namespace _19AprilUygulama.Controllers
{
    public class UnluUyumuController : Controller
    {
        public IActionResult Uyum()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UyumluMu(Metin metin)
        {
            return View(metin);
        }


    }
}

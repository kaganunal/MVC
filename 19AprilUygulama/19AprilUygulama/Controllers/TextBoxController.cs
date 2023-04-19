using _19AprilUygulama.Models;
using Microsoft.AspNetCore.Mvc;

namespace _19AprilUygulama.Controllers
{
    public class TextBoxController : Controller
    {
        public ActionResult SayiGir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sonuc(Number number)
        {
            ViewBag.Sonuc = (number.Sayi % 2 == 0) ? "Çift" : "Tek";
            return View();
        }
    }
}

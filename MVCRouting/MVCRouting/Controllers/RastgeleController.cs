using Microsoft.AspNetCore.Mvc;


namespace MVCRouting.Controllers
{

    public class RastgeleController : Controller
    {
        [Route("/sayiVer")]
        public IActionResult SayiUret()
        {
            return View();
        }
        [Route("/KazananNumaralar")]
        public IActionResult KazananNumaralar()
        {
            return View();
        }
    }
}

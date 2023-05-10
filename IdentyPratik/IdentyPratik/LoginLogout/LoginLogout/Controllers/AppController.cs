using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginLogout.Controllers
{

    [Authorize(Roles = "admin,editor")]
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

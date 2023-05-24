using API_UI_CORSUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_UI_CORSUygulaması.Controllers
{

    public class UserController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            var json = await client.GetStringAsync("https://localhost:7019/api/Students");
            var users = JsonConvert.DeserializeObject<List<AppUser>>(json);

            return View(users);
        }
    }

}

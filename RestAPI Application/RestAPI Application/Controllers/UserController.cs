using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestAPI_Application.Models;

namespace RestAPI_Application.Controllers
{
    public class UserController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            var json = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var users = JsonConvert.DeserializeObject<List<AppUser>>(json);

            return View(users);
        }
    }
}

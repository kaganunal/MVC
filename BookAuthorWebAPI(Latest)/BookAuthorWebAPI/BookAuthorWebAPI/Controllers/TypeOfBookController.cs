using BookAuthorWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookAuthorWebAPI.Controllers
{
    public class TypeOfBookController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            var json = await client.GetStringAsync("https://localhost:7106/api/TypeOfBook");
            var typeOfBooks = JsonConvert.DeserializeObject<List<TypeOfBook>>(json);

            return View(typeOfBooks);
        }
    }
}

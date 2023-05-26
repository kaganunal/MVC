using BookAuthorWebAPI.Models;
using BookAuthorWebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace BookAuthorWebAPI.Controllers
{
    public class AuthorController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            var json = await client.GetStringAsync("https://localhost:7106/api/Author");
            var authors = JsonConvert.DeserializeObject<List<Author>>(json);

            return View(authors);
        }
    }
}

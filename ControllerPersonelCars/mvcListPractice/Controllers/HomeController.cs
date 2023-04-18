using Microsoft.AspNetCore.Mvc;
using mvcListPractice.Models;
using System.Diagnostics;

namespace mvcListPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Doga()
        {
            return View();
        }

        public IActionResult DoganinArabalari()
        {
            Dictionary<int, string> doga = new Dictionary<int, string>();
            doga.Add(2010, "Tofaş");
            doga.Add(2015, "Ford");
            doga.Add(2013, "Audi");
            return View(doga);
        }

        public List<Personel> personels = new List<Personel>
        {
            new Personel {
                Id = 1,
                FirstName = "Ali",
                LastName = "Sağlam",
                Cars = new Dictionary<int, string> { { 2015,"Opel" },{2003, "Honda"}}
            },
            new Personel {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Serçe",
                Cars = new Dictionary<int, string> { { 1998,"Toyota" },{2008, "Peugeot"}}
            },
            new Personel {
                Id = 3,
                FirstName = "Mehmet",
                LastName = "Gün",
                Cars = new Dictionary<int, string> { { 1989,"BMW" },{2007, "Mondial"}}
            },
            new Personel {
                Id = 4,
                FirstName = "Hüseyin",
                LastName = "Tok",
                Cars = new Dictionary<int, string> { { 2022,"Chevrolet" },{2020, "Citroen"}}
            },
            new Personel {
                Id = 5,
                FirstName = "Alp",
                LastName = "Dağ",
                Cars = new Dictionary<int, string> { { 2013,"Dacia" },{2015, "Renault"}}
            },
            new Personel {
                Id = 6,
                FirstName = "Cem",
                LastName = "Yılmaz",
                Cars = new Dictionary<int, string> { { 2002,"Fiat" },{2000, "Ford"}}
            }
        };
        public IActionResult Personeller()
        {
            return View(personels);
        }

        public IActionResult PersonellerinArabalari(int id)
        {
            return View(personels[id].Cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
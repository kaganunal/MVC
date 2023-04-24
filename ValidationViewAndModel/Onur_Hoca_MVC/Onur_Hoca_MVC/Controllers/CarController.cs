using Microsoft.AspNetCore.Mvc;
using Onur_Hoca_MVC.Models;

namespace Onur_Hoca_MVC.Controllers
{
    public class CarController : Controller
    {

        public IActionResult ShowCar()
        {
            Car cars = new Car() { Marka = "Opel", Model = 1998 };
            return View(cars);
        }

    }
}

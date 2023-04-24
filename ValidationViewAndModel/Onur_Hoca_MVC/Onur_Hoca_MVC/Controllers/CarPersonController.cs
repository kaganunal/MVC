using Microsoft.AspNetCore.Mvc;
using Onur_Hoca_MVC.Models;

namespace Onur_Hoca_MVC.Controllers
{
    public class CarPersonController : Controller
    {
        public IActionResult ShowCarPerson()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Oğuz Kağan",
                Age = "25",
            };
            Car car = new Car()
            {
                Marka = "Mercedes",
                Model = 2017
            };
            CarPersonView carPerson = new CarPersonView(car, person);
            return View(carPerson);
        }
    }
}

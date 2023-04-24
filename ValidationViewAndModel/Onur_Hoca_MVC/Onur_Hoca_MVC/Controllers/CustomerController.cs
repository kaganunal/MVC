using Microsoft.AspNetCore.Mvc;
using Onur_Hoca_MVC.Models;

namespace Onur_Hoca_MVC.Controllers
{
    public class CustomerController : Controller
    {
        //[HttpPost]
        public IActionResult ShowCustomer()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                CompanyName = "H&Work Company",
                Age = 12,
                Email = "handworkcompany@gmail.com",
                JoinDate = DateTime.Now.AddYears(-8),
                CustomerType = CustomerType.Elite,
            };
            return View(customer);
        }
    }
}

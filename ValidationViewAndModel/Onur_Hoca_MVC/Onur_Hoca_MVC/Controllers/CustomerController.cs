using Microsoft.AspNetCore.Mvc;
using Onur_Hoca_MVC.Models;

namespace Onur_Hoca_MVC.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult ShowCustomer()
        {
            Customer _customer = new Customer();
            //{
            //    Id = 1,
            //    CompanyName = "H&Work Company",
            //    Age = 12,
            //    Email = "handworkcompany@gmail.com",
            //    JoinDate = DateTime.Now.AddYears(-12),
            //    CustomerType = CustomerType.Elite
            //};
            return View(_customer);
        }

        [HttpPost]
        public IActionResult ShowCustomer(Customer _customer)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(_customer);
            return View(_customer);
        }
    }
}

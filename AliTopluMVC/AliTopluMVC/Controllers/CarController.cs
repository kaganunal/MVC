using AliTopluMVC.Context;
using AliTopluMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AliTopluMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly KisiContext _context;
        public CarController(KisiContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Cars.ToList());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var silinecekArac = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(silinecekArac);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _context.Cars.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Car car)
        {
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

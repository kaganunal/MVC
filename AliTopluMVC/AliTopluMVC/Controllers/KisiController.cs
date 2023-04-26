using AliTopluMVC.Context;
using AliTopluMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AliTopluMVC.Controllers
{
    public class KisiController : Controller
    {
        private readonly KisiContext _context;
        public KisiController(KisiContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var kisiler = await _context.Kisiler.ToListAsync();
            return View(kisiler);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Kisi kisi)
        {
            await _context.Kisiler.AddAsync(kisi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var silinecekKisi = await _context.Kisiler.FindAsync(id);
            _context.Kisiler.Remove(silinecekKisi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _context.Kisiler.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Kisi kisi)
        {
            _context.Kisiler.Update(kisi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}

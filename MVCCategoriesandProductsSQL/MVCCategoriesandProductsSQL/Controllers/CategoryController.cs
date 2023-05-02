using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCategoriesandProductsSQL.Context;
using MVCCategoriesandProductsSQL.Models;

namespace MVCCategoriesandProductsSQL.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProductsContext _context;
        public CategoryController(ProductsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {

            //if (ModelState.IsValid)
            //{
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            //}
            //else
            //{
            //    return View(category);
            //}
        }
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCategory = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(deleteCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _context.Categories.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {

            //if (ModelState.IsValid)
            //{
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            //}
            ////else
            //{
            //    return View(category);
            //}
        }

        public async Task<IActionResult> Details(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(a => a.Id == id);
            if (category == null)
            {
                return BadRequest();
            }
            return View(category);
        }

    }
}

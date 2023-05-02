using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCategoriesandProductsSQL.Context;
using MVCCategoriesandProductsSQL.Models;

namespace MVCCategoriesandProductsSQL.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsContext _context;
        public ProductController(ProductsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(x => x.Category).ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {

            //if (ModelState.IsValid)
            //{
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            //}
            //else
            //{
            //    return View(product);
            //}
        }
        public async Task<IActionResult> Delete(int id)
        {
            var deleteProduct = await _context.Products.FindAsync(id);
            _context.Products.Remove(deleteProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _context.Products.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {

            //if (ModelState.IsValid)
            //{
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            //}
            //else
            //{
            //    return View(product);
            //}
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(a => a.Id == id);
            if (product == null)
            {
                return BadRequest();
            }
            return View(product);
        }
    }
}

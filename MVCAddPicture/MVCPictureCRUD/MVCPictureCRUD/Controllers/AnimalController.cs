using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCPictureCRUD.Context;
using MVCPictureCRUD.Models;

namespace MVCPictureCRUD.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalContext _context;
        public AnimalController(AnimalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var animals = await _context.Animals.ToListAsync();
            return View(animals);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Animal animal, IFormFile? file)
        {

            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    animal.PicturePath = "/images/" + fileName;

                }
                else
                {
                    animal.PicturePath = "/images/default_animal.jpg";
                }

                SetSound(animal);
                await _context.Animals.AddAsync(animal);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(animal);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteAnimal = await _context.Animals.FindAsync(id);
            _context.Animals.Remove(deleteAnimal);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _context.Animals.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Animal animal, IFormFile? file)
        {

            // ??????????????????????????????????????????????????????????
            //var pictureName = animal.PicturePath;
            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    animal.PicturePath = "/images/" + fileName;
                }
                else
                {
                    var existingAnimal = await _context.Animals.AsNoTracking().FirstOrDefaultAsync(a => a.Id == animal.Id);
                    animal.PicturePath = existingAnimal.PicturePath;
                }

                SetSound(animal);
                _context.Animals.Update(animal);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(animal);
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var animal = await _context.Animals.FirstOrDefaultAsync(a => a.Id == id);
            if (animal == null)
            {
                return BadRequest();
            }
            return View(animal);
        }

        private void SetSound(Animal animal)
        {
            switch (animal.Type)
            {
                case AnimalType.Cat:
                    animal.SoundPath = "/Sound/CatMeows.mp3";
                    break;
                case AnimalType.Dog:
                    animal.SoundPath = "/Sound/dogBarking.mp3";
                    break;
                case AnimalType.Mouse:
                    animal.SoundPath = "/Sound/miceSqeak.mp3";
                    break;
                case AnimalType.Bird:
                    animal.SoundPath = "/Sound/birdsSinging.mp3";
                    break;
                default:
                    animal.SoundPath = "/Sound/default_sound.mp3";
                    break;
            }
        }
    }
}

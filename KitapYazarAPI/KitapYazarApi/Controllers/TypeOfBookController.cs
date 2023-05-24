using KitapYazarApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KitapYazarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfBookController : ControllerBase
    {
        private readonly Context _db;

        public TypeOfBookController(Context db)
        {
            _db = db;
        }

        [HttpGet]
        public List<TypeOfBook> ListAuthor()
        {
            var authorList = _db.TypeOfBooks.ToList();
            return authorList;
        }
        [HttpPost]
        public async void AddAuthor(TypeOfBook author)
        {
            await _db.TypeOfBooks.AddAsync(author);
            await _db.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public async void DeleteAuthor(int id)
        {
            var selectedAuthor = await _db.TypeOfBooks.FindAsync(id);
            if (selectedAuthor != null)
            {
                _db.TypeOfBooks.Remove(selectedAuthor);
                await _db.SaveChangesAsync();
            }
        }
        [HttpPut]
        public async void UpdateAuthor(TypeOfBook author)
        {
            _db.TypeOfBooks.Update(author);
            await _db.SaveChangesAsync();
        }
        [HttpGet("{id}")]
        public async Task<TypeOfBook> AuthorDetails(int id)
        {
            var selectedAuthor = await _db.TypeOfBooks.FindAsync(id);
            return selectedAuthor;
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace KitapYazarApi.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTypeOfBook> BookTypeOfBooks { get; set; }
        public DbSet<TypeOfBook> TypeOfBooks { get; set; }

    }
}

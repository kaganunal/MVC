using Microsoft.EntityFrameworkCore;
using MVCPictureCRUD.Models;

namespace MVCPictureCRUD.Context
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Animal> Animals { get; set; }
    }
}

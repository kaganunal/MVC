using AliTopluMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AliTopluMVC.Context
{
    public class KisiContext : DbContext
    {
        public KisiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Kisi> Kisiler { get; set; }

        public DbSet<Car> Cars { get; set; }

    }
}

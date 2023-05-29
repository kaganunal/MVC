using ETicaretApp.Application.Interfaces.Repositories;
using ETicaretApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaretApp.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ETicaretAppDBContext _context;

        public Repository(ETicaretAppDBContext context)
        {
            _context = context;
        }

        //public DbSet<T> Tablo {get { return _context.Set<T>(); } }
        public DbSet<T> Tablo => _context.Set<T>();
    }
}

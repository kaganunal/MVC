using ETicaretApp.Application.Interfaces.Repositories;
using ETicaretApp.Persistence.Context;
using System.Linq.Expressions;

namespace ETicaretApp.Persistence.Repositories
{
    public class ReadRepository<T> : Repository<T>, IReadRepository<T> where T : class
    {
        public ReadRepository(ETicaretAppDBContext context) : base(context)
        {
        }

        /*public IQueryable<T> GetAll()
        {
            return Tablo;
        }*/
        public IQueryable<T> GetAll() => Tablo;

        /*public async Task<T> GetByKeysAsync(params object?[]? keyValues)
        {
            return await Tablo.FindAsync(keyValues);
        }*/

        public async Task<T> GetByKeysAsync(params object?[]? keyValues) => await Tablo.FindAsync(keyValues);

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Tablo.FirstOrDefault(predicate);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return Tablo.Where(predicate);
        }
    }
}

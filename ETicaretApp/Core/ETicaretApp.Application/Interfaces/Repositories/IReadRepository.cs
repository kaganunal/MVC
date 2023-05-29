using System.Linq.Expressions;

namespace ETicaretApp.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);

        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> GetByKeysAsync(params object?[]? keyValues);
    }
}

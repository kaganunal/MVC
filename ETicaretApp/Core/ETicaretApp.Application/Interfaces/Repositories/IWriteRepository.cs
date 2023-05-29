using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Application.Interfaces.Repositories
{
    //Bir varlığın yazma işlemlerine dair metotlarının imzasını atacağız.
    //Methods prototype - Metotların prototipi
    //writable
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        bool Add(T entity);
        Task<bool> AddAsync(T entity);
        bool AddRange(IEnumerable<T> entities);
        Task<bool> AddRangeAsync(IEnumerable<T> entities);

        bool Update(T entity);
        bool UpdateRange(IEnumerable<T> entities);

        bool Remove(T entity);
        bool RemoveRange(IEnumerable<T> entities);

        int Save();
        Task<int> SaveAsync();
    }
}

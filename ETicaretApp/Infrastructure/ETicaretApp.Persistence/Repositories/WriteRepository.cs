using ETicaretApp.Application.Interfaces.Repositories;
using ETicaretApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence.Repositories
{
    public class WriteRepository<T> : Repository<T>, IWriteRepository<T> where T : class
    {
        public WriteRepository(ETicaretAppDBContext context) : base(context)
        {
        }

        public bool Add(T entity)
        {
            EntityEntry<T> entityEntry = Tablo.Add(entity);
            var result = entityEntry.State == EntityState.Added;
            Save();
            return result;
        }

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Tablo.AddAsync(entity);
            var result = entityEntry.State == EntityState.Added;
            await SaveAsync();
            return result;
        }

        public bool AddRange(IEnumerable<T> entities)
        {
            bool result = false;
            try
            {
                Tablo.AddRange(entities);
                Save();
                result = true;
            }
            catch(Exception ex)
            {

            }
            return result;
        }

        public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
        {
            bool result = false;
            try
            {
                await Tablo.AddRangeAsync(entities);
                await SaveAsync();
                result = true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Tablo.Remove(entity);
            bool result = entityEntry.State == EntityState.Deleted;
            Save();
            return result;
        }

        public bool RemoveRange(IEnumerable<T> entities)
        {
            bool result = false;
            try
            {
                Tablo.RemoveRange(entities);
                Save();
                result = true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry = Tablo.Update(entity);
            bool result = entityEntry.State == EntityState.Modified;
            Save();
            return result;
        }

        public bool UpdateRange(IEnumerable<T> entities)
        {
            bool result = false;
            try
            {
                Tablo.UpdateRange(entities);
                Save();
                result = true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}

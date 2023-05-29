using ETicaretApp.Application.Interfaces;
using ETicaretApp.Application.Interfaces.Repositories.ProductRepo;
using ETicaretApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ETicaretAppDBContext _dbContext;
        public IProductWriteRepository ProductsWrite { get; }

        public IProductReadRepository ProductsRead { get; }

        public UnitOfWork(ETicaretAppDBContext dbContext, IProductWriteRepository productsWrite, IProductReadRepository productsRead)
        {
            _dbContext = dbContext;
            ProductsWrite = productsWrite;
            ProductsRead = productsRead;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}

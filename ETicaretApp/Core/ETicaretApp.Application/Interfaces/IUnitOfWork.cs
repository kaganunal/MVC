using ETicaretApp.Application.Interfaces.Repositories.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Application.Interfaces
{

    public interface IUnitOfWork : IDisposable
    {
        IProductWriteRepository ProductsWrite { get; }
        IProductReadRepository ProductsRead { get; }
    }

}

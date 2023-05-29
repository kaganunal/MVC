using Core.ETicaretApp.Domain.Entities;
using ETicaretApp.Application.Interfaces.Repositories.ProductRepo;

using ETicaretApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence.Repositories.ProductRepo
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretAppDBContext context) : base(context)
        {
        }

        
    }
}

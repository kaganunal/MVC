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
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAppDBContext context):base(context)
        {

        }
    }
}

using Core.ETicaretApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Application.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        Task<Product> GetProductByIdAsync(int id);
    }
}

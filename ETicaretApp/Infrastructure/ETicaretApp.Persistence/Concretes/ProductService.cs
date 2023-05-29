using Core.ETicaretApp.Domain.Entities;
using ETicaretApp.Application.Interfaces;
using ETicaretApp.Application.Interfaces.Repositories.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        /*
        private readonly IProductReadRepository _productRead;
        public ProductService(IProductReadRepository productRead)
        {
            _productRead = productRead;
        }
        */
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Product GetProductById(int id)
        {
            return _unitOfWork.ProductsRead.GetFirstOrDefault(p => p.Id == id);
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            return _unitOfWork.ProductsRead.GetByKeysAsync(id);
        }

        public List<Product> GetProducts()
        {
            return _unitOfWork.ProductsRead.GetAll().ToList();
        }
    }
}


using ETicaretApp.Application.Interfaces.Repositories.ProductRepo;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApp.WEBAPI.Controllers
{
    public class ProductsController : Controller
    {

        //private readonly IProductReadRepository _productReadRepository;
        //private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductService _productService;
        public ProductsController(IProductService productService/*IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, */)
        {

            //_productReadRepository = productReadRepository;
            ///_productWriteRepository = productWriteRepository;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(_productReadRepository.GetAll().ToList());
            return Ok(_productService.GetProducts());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return Ok( product != null ? product : new AppResponse(){Message = $"{id} id numaralı ürün bulunmamaktadır!"});
        }

        /*
        [HttpPost("addProduct")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            return Ok(await _productWriteRepository.AddAsync(product));
        }

        [HttpPut("updateProduct")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            //TODO: Update edildiğinde sadece yollana verilerin güncellenmesi sağlanacak.
            return Ok(_productWriteRepository.Update(product));
        }

        [HttpDelete("deleteProduct/{id}")]
        public IActionResult RemoveProduct(int id)
        {
            return Ok(_productWriteRepository.Remove(_productReadRepository.GetWhere(p => p.Id == id).First()));
        }
        */
    }
}

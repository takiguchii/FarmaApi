using FarmaApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi.Controller

{
    [ApiController]
    [Route("[controller]")]
    
    private IProductService _productService;

    public class ProductController : ControllerBase
    {
        public ProductController()
        {
            _productService = productService;
        }

        [HttpGet(Name = "GetProducts")]
        public IActionResult GetProducts()
        {
            var clients = _ProductService.GetProducts();
            return Ok(products);
        }

        [HttpPost(Name = "PostClients")]
        public IActionResult CreateClient(CreateProductDTO dto)
        {
            var client = _productService.CreateProduct(dto);
            return Ok(product);
        }
    }
}
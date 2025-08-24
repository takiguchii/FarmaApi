using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmaAPI.Controllers // << Corrija esta linha
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "GetProducts")]
        public IActionResult GetProducts()
        {
            List<Product> products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost(Name = "CreateProduct")]
        public IActionResult CreateProduct(CreateProductDTO dto)
        {
            Product product = _productService.CreateProduct(dto);
            return Ok(product);
        }
    }
}
using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi.Controller
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
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost(Name = "CreateProduct")]
        public IActionResult CreateProduct(CreateProductDTO dto)
        {
            var product = _productService.CreateProduct(dto);
            return Ok(product);
        }
    }
}
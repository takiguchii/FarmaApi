using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet(Name = "GetSales")]
        public IActionResult GetSales()
        {
            List<Sale> sales = _saleService.GetSales();
            return Ok(sales);
        }

        [HttpPost(Name = "CreateSale")]
        public IActionResult CreateSale([FromBody] CreateSaleDTO dto)
        {
            Sale sale = _saleService.CreateSale(dto);
            return Ok(sale);
        }
    }
}
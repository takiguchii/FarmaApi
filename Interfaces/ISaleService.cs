using FarmaApi.DTOs;
using FarmaApi.Models;

namespace FarmaApi.Interfaces;

public interface ISaleService
{
    public Sale CreateSale(CreateSaleDTO dto);
    public List<Sale> GetSales();
}
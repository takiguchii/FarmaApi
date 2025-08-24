using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using System.Collections.Generic;

namespace FarmaApi.Service;

public class SaleService : ISaleService
{
    private readonly IClientService _clientService;
    private readonly IProductService _productService;
    
    private readonly List<Sale> _sales = new List<Sale>();
    private int _nextId = 1;

    public SaleService(IClientService clientService, IProductService productService)
    {
        _clientService = clientService;
        _productService = productService;
    }
    public Sale CreateSale(CreateSaleDTO dto)
    {
        Sale newSale = new Sale
        {
            Id = _nextId++,
            Quantity = dto.Quantity,
        };
        _sales.Add(newSale);
        return newSale;
    }
    public List<Sale> GetSales()
    {
        return _sales;
    }
}
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
        // 1. Validar se o cliente comprador é válido
        var clients = _clientService.GetClients();
        var client = clients.FirstOrDefault(c => c.id == dto.ClientId);
        if (client == null)
        {
            throw new InvalidOperationException("Cliente não encontrado.");
        }

        // 2. Validar se produto comprado é válido
        var products = _productService.GetProducts();
        var product = products.FirstOrDefault(p => p.id == dto.ProductId);
        if (product == null)
        {
            throw new InvalidOperationException("Produto não encontrado.");
        }

        // 3. Validar se a quantidade é válida 
        if (dto.Quantity <= 0)
        {
            throw new InvalidOperationException("Quantidade da venda deve ser maior que zero.");
        }

        // Se tudo for aprovado a venda é criada
        Sale newSale = new Sale
        {
            Id = _nextId++,
            Client = client,
            Product = product,
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
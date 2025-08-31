using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using FarmaApi.Repositories; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FarmaApi.Service;

public class SaleService : ISaleService
{
    private readonly ISaleRepository _saleRepository;
    private readonly IClientRepository _clientRepository;
    private readonly IProductRepository _productRepository;

    public SaleService(ISaleRepository saleRepository, IClientRepository clientRepository, IProductRepository productRepository)
    {
        _saleRepository = saleRepository;
        _clientRepository = clientRepository;
        _productRepository = productRepository;
    }

    public Sale CreateSale(CreateSaleDTO dto)
    {
        var client = _clientRepository.GetById(dto.ClientId);
        if (client == null)
        {
            throw new InvalidOperationException("Cliente não encontrado.");
        }

        var product = _productRepository.GetById(dto.ProductId);
        if (product == null)
        {
            throw new InvalidOperationException("Produto não encontrado.");
        }

        if (dto.Quantity <= 0)
        {
            throw new InvalidOperationException("Quantidade da venda deve ser maior que zero.");
        }

        Sale newSale = new Sale
        {
            Client = client,
            Product = product,
            Quantity = dto.Quantity,
        };

        _saleRepository.Add(newSale);
        _saleRepository.SaveChanges();
        return newSale;
    }

    public List<Sale> GetSales()
    {
        return _saleRepository.GetAll();
    }
}
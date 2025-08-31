using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using FarmaApi.Data; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore; 

namespace FarmaApi.Service;

public class SaleService : ISaleService
{
    private readonly FarmaApiContext _dbContext;
    
    public SaleService(FarmaApiContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public Sale CreateSale(CreateSaleDTO dto)
    {
        var client = _dbContext.Clients.FirstOrDefault(c => c.id == dto.ClientId);
        if (client == null)
        {
            throw new InvalidOperationException("Cliente não encontrado.");
        }

        var product = _dbContext.Products.FirstOrDefault(p => p.id == dto.ProductId);
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
        
        _dbContext.Sales.Add(newSale);
        _dbContext.SaveChanges();
        return newSale;
    }

    public List<Sale> GetSales()
    {
        return _dbContext.Sales
            .Include(s => s.Client)
            .Include(s => s.Product)
            .ToList();
    }
}
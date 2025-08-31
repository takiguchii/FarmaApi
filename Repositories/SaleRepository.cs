using FarmaApi.Data;
using FarmaApi.Models;
using FarmaApi.Repositories;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FarmaApi.Repositories;

public class SaleRepository : ISaleRepository
{
    private readonly FarmaApiContext _dbContext;

    public SaleRepository(FarmaApiContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Sale> GetAll()
    {
        return _dbContext.Sales
            .Include(s => s.Client)
            .Include(s => s.Product)
            .ToList();
    }

    public void Add(Sale sale)
    {
        _dbContext.Sales.Add(sale);
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
}
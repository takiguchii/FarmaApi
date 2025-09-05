using FarmaApi.Data;
using FarmaApi.Models;
using FarmaApi.Repositories;
using System.Collections.Generic;
using System.Linq;
using System; // Adicione esta linha

namespace FarmaApi.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly FarmaApiContext _dbContext;

    public ProductRepository(FarmaApiContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Product> GetAll()
    {
        return _dbContext.Products.ToList();
    }

    // O erro estava aqui. O tipo de entrada foi mudado para Guid.
    public Product GetById(Guid id)
    {
        return _dbContext.Products.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Product product)
    {
        _dbContext.Products.Add(product);
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
}
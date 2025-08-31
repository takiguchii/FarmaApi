using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using FarmaApi.Data;
using System.Collections.Generic;
using System.Linq;

namespace FarmaApi.Service;

public class ProductService : IProductService
{
    private readonly FarmaApiContext _dbContext;

    public ProductService(FarmaApiContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Product CreateProduct(CreateProductDTO dto)
    {
        Product newProduct = new Product
        {
            Name = dto.Name,
            Description = dto.Description
        };

        _dbContext.Products.Add(newProduct);
        _dbContext.SaveChanges();
        return newProduct;
    }

    public List<Product> GetProducts()
    {
        return _dbContext.Products.ToList();
    }
}
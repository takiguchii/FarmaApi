
using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using FarmaApi.Repositories; 
using System.Collections.Generic;
using System.Linq;

namespace FarmaApi.Service;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product CreateProduct(CreateProductDTO dto)
    {
        Product newProduct = new Product
        {
            Name = dto.Name,
            Description = dto.Description
        };

        _productRepository.Add(newProduct);
        _productRepository.SaveChanges();
        return newProduct;
    }

    public List<Product> GetProducts()
    {
        return _productRepository.GetAll();
    }
}
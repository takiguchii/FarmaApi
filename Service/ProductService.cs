using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;

namespace FarmaApi.Service;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new List<Product>();
    private int _nextId = 1;

    public ProductService()
    {
        _products.Add(new Product{ id = _nextId++, Name = "Arroz", Description = "Arroz vale branco"});
        _products.Add(new Product{ id = _nextId++, Name = "feijão", Description = "Feijão preto"});
    }

    public Product CreateProduct(CreateProductDTO dto)
    {
        Product newProduct = new Product
        {
            id = _nextId++,
            Name = dto.Name,
            Description = dto.Description
        };
        _products.Add(newProduct);
        return newProduct;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
}
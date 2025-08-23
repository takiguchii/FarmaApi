using FarmaApi.DTOs;
using FarmaApi.Models;

namespace FarmaApi.Interfaces;

public interface IProductService
{
    public List<Product> GetProducts();
    public Product CreateProduct(CreateProductDTO dto);
}
using FarmaApi.Models;

namespace FarmaApi.Repositories;

public interface IProductRepository
{
    List<Product> GetAll();
    Product GetById(int id);
    void Add(Product product);
    void SaveChanges();
}
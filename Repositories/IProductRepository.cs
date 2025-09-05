using FarmaApi.Models;
using System.Collections.Generic;
using System; // Adicione esta linha

namespace FarmaApi.Repositories;

public interface IProductRepository
{
    List<Product> GetAll();
    // O erro estava aqui. Mude de 'int id' para 'Guid id'
    Product GetById(Guid id);
    void Add(Product product);
    void SaveChanges();
}
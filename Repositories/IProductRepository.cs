using FarmaApi.Models;
using System.Collections.Generic;
using System;

namespace FarmaApi.Repositories;

public interface IProductRepository
{
    List<Product> GetAll();
    Product GetById(Guid id);
    void Add(Product product);
    void SaveChanges();
}
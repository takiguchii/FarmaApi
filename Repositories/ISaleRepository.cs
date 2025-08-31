using FarmaApi.Models;

namespace FarmaApi.Repositories;

public interface ISaleRepository
{
    List<Sale> GetAll();
    void Add(Sale sale);
    void SaveChanges();
}
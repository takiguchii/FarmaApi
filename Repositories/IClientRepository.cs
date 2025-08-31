using FarmaApi.Models;

namespace FarmaApi.Repositories;

public interface IClientRepository
{
    List<Client> GetAll();
    Client GetById(int id);
    void Add(Client client);
    void SaveChanges();
}
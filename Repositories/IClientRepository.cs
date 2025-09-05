using FarmaApi.Models;
using System.Collections.Generic;
using System; // Adicione esta linha

namespace FarmaApi.Repositories;

public interface IClientRepository
{
    List<Client> GetAll();
    // O erro estava aqui. Mude de 'int id' para 'Guid id'
    Client GetById(Guid id);
    void Add(Client client);
    void SaveChanges();
}
using FarmaApi.Data;
using FarmaApi.Models;
using FarmaApi.Repositories;
using System.Collections.Generic;
using System.Linq;
using System; 

namespace FarmaApi.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly FarmaApiContext _dbContext;

    public ClientRepository(FarmaApiContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Client> GetAll()
    {
        return _dbContext.Clients.ToList();
    }

    // O erro estava aqui. O tipo de entrada foi mudado para Guid.
    public Client GetById(Guid id)
    {
        return _dbContext.Clients.FirstOrDefault(c => c.Id == id);
    }

    public void Add(Client client)
    {
        _dbContext.Clients.Add(client);
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
}
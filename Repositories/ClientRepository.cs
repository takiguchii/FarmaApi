using FarmaApi.Data;
using FarmaApi.Models;
using FarmaApi.Repositories;
using System.Collections.Generic;
using System.Linq;

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

    public Client GetById(int id)
    {
        return _dbContext.Clients.FirstOrDefault(c => c.id == id);
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
using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using FarmaApi.Data;

namespace FarmaApi.Service;

public class ClientService : IClientService
{
    private readonly FarmaApiContext _dbContext;

    public ClientService(FarmaApiContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Client CreateClient(CreateClientDTO dto)
    {
        Client newClient = new Client
        {
            Name = dto.Name,
            Email = dto.Email
        };
        
        _dbContext.Clients.Add(newClient);
        _dbContext.SaveChanges();
        return newClient;
    }

    public List<Client> GetClients()
    {
        return _dbContext.Clients.ToList();
    }
}
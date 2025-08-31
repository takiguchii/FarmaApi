
using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using FarmaApi.Repositories; 
using System.Collections.Generic;
using System.Linq;

namespace FarmaApi.Service;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public Client CreateClient(CreateClientDTO dto)
    {
        Client newClient = new Client
        {
            Name = dto.Name,
            Email = dto.Email
        };

        _clientRepository.Add(newClient);
        _clientRepository.SaveChanges();
        return newClient;
    }

    public List<Client> GetClients()
    {
        return _clientRepository.GetAll();
    }
}
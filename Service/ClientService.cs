using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;

namespace FarmaApi.Service;

public class ClientService : IClientService
{
    private readonly List<Client> _clients = new List<Client>();
    private int _nextId = 1;

    public ClientService()
    {
        _clients.Add(new Client { id = _nextId++, Name = "João da Silva", Email = "joao@email.com" });
        _clients.Add(new Client { id = _nextId++, Name = "Maria Souza", Email = "maria@email.com" });
    }

    public Client CreateClient(CreateClientDTO dto)
    {
        Client newClient = new Client
        {
            id = _nextId++, 
            Name = dto.Name,
            Email = dto.Email
        };
        _clients.Add(newClient); // Salvando clientes na litsa
        return newClient;
    }

    public List<Client> GetClients()
    {
        return _clients; // Retorna a lista com todos os clientes
    }
}
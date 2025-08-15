using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;

namespace FarmaApi.Service;

public class ClientService : IClientService
{
    public Client CreateClient(CreateClientDTO dto)
    {
        // Lógica para criar um cliente
        // Exemplo: Salvar no "banco de dados" em memória
        Client newClient = new Client
        {
            Name = dto.Name,
            Email = dto.Email
        };
        newClient.id = 1; // ID fixo para exemplo
        return newClient;
    }

    public List<Client> GetClients()
    {
        // Lógica para obter clientes
        // Exemplo: Retornar uma lista de clientes
        return new List<Client>
        {
            new Client { id = 1, Name = "João da Silva", Email = "joao@email.com" },
            new Client { id = 2, Name = "Maria Souza", Email = "maria@email.com" }
        };
    }
}
using FarmaApi.DTOs;
using FarmaApi.Models;

namespace FarmaApi.Interfaces;

public interface IClientService
{
    public List<Client> GetClients();
    public Client CreateClient(CreateClientDTO dto);
}
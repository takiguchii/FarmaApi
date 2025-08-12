using FarmaApi.Models;

namespace FarmaApi.Interfaces;

public interface IClientService
{
    public List<Client> GetClientes();
    public Client CreateClient();
}
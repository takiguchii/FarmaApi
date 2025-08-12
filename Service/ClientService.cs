using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;

namespace FarmaApi.Service;
public class ClientService
{
    public class ClientService : IClientService
    {
        private IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client CreateClient(CreateClientDTO dto)
        {
            throw new NotImplementedException();
        }
        public List<Client> GetClients()
        {
            List<Client> clients = _clientRepository.GetClients();
            return clients;
        }
    }
}
using FarmaApi.DTOs;
using FarmaApi.Interfaces;
using FarmaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService) 
        {
            _clientService = clientService;
        }

        [HttpGet(Name = "GetClients")]
        public IActionResult GetClients()
        {
            List<Client> clients = _clientService.GetClients();
            return Ok(clients);
        }

        [HttpPost(Name = "CreateClient")]
        public IActionResult CreateClient(CreateClientDTO dto)
        {
            Client client = _clientService.CreateClient(dto);
            return Ok(client);
        }
    }
}
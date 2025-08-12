using FarmaApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi.Controller

{
    [ApiController]
    [Route("[controller]")]
    
    private IClientService _clientService;

    public class ClientController : ControllerBase
    {
        public ClientController()
        {
            _clientService = clientService;
        }

        [HttpGet(Name = "GetClients")]
        public IActionResult GetClients()
        {
            var clients = _clientService.GetClients();
            return Ok(clients);
        }

        [HttpPost(Name = "PostClients")]
        public IActionResult CreateClient(CreateClientDTO dto)
        {
            var client = _clientService.CreateClient(dto);
            return Ok(client);
        }
    }
}
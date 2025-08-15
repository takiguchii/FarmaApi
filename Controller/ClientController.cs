using FarmaApi.DTOs;
using FarmaApi.Interfaces; // Importamos a Interface, não a classe
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi.Controller;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private IClientService _clientService; // Apontamos para a Interface

    public ClientController(IClientService clientService)
    {
        // A dependência é recebida como parâmetro
        _clientService = clientService;
    }

    [HttpGet(Name = "GetClients")]
    public IActionResult GetClients()
    {
        var clients = _clientService.GetClients();
        return Ok(clients);
    }

    [HttpPost(Name = "CreateClient")]
    public IActionResult CreateClient(CreateClientDTO dto)
    {
        var client = _clientService.CreateClient(dto);
        return Ok(client);
    }
}
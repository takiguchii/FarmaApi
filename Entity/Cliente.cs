using System.ComponentModel.DataAnnotations;
namespace FarmaApi.Models;

public class Client
{
    [Key]
    public int id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
}
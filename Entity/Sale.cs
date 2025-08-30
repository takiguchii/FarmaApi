using FarmaApi.Models;
using System.ComponentModel.DataAnnotations;
namespace FarmaApi.Models;

public class Sale
{
    [Key]
    public int Id { get; set; }
    public Client Client { get; set; } 
    public Product Product { get; set; } 
    public int Quantity { get; set; }
}
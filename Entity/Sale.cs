using FarmaApi.Models;

namespace FarmaApi.Models;

public class Sale
{
    public int Id { get; set; }
    public Client Client { get; set; } 
    public Product Product { get; set; } 
    public int Quantity { get; set; }
}
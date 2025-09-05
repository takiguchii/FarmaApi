using System;
using System.ComponentModel.DataAnnotations;

namespace FarmaApi.Models;

public class Sale
{
    [Key]
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Client Client { get; set; } 
    public Guid ProductId { get; set; } 
    public Product Product { get; set; } 
    public int Quantity { get; set; }
}
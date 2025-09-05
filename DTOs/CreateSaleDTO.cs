using System;

namespace FarmaApi.DTOs;

public class CreateSaleDTO
{
    public Guid ClientId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
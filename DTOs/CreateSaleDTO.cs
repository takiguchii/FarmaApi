namespace FarmaApi.DTOs;

public class CreateSaleDTO
{
    public int ClientId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
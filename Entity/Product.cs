using System.ComponentModel.DataAnnotations;
namespace FarmaApi.Models;

public class Product
{
    [Key]
    public int id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FarmaApi.Models;

public class Product
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Sale> Sales { get; set; } 
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FarmaApi.Models;

public class Client
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public ICollection<Sale> Sales { get; set; } // Adicionando a propriedade de navegação
}
using FarmaApi.Models;
using Microsoft.EntityFrameworkCore;
namespace FarmaApi.Data;
public class FarmaApiContext : DbContext
{
    public FarmaApiContext(DbContextOptions<FarmaApiContext> options) : base(options) { }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
}
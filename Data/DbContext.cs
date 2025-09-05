using FarmaApi.Models;
using Microsoft.EntityFrameworkCore;
namespace FarmaApi.Data;

public class FarmaApiContext : DbContext
{
    public FarmaApiContext(DbContextOptions<FarmaApiContext> options) : base(options) { }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasKey(product => product.Id);

        modelBuilder.Entity<Client>()
            .HasKey(client => client.Id);

        modelBuilder.Entity<Sale>()
            .HasKey(sale => sale.Id);

        modelBuilder.Entity<Sale>()
            .HasOne(sale => sale.Client)
            .WithMany(client => client.Sales)
            .HasForeignKey(sale => sale.ClientId);

        modelBuilder.Entity<Sale>()
            .HasOne(sale => sale.Product)
            .WithMany(product => product.Sales)
            .HasForeignKey(sale => sale.ProductId);
            
        base.OnModelCreating(modelBuilder);
    }
}
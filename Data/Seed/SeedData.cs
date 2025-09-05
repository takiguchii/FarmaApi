using System;
using System.Collections.Generic;
using System.Linq;
using FarmaApi.Data; 
using FarmaApi.Models;
using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Initialize(FarmaApiContext context) 
    {
        context.Database.EnsureCreated();

        // Verifica se já existe algum client
        if (context.Clients.Any())
        {
            return; // DB já foi populado
        }

        // Seed de Clients
        var clients = new List<Client>
        {
            new Client { Id = Guid.NewGuid(), Name = "Alice", Email = "alice@email.com" },
            new Client { Id = Guid.NewGuid(), Name = "Bob", Email = "bob@email.com" },
            new Client { Id = Guid.NewGuid(), Name = "Carol", Email = "carol@email.com" }
        };

        context.Clients.AddRange(clients);

        // Seed de Products
        var products = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Produto A", Description = "Descrição do Produto A"},
            new Product { Id = Guid.NewGuid(), Name = "Produto B", Description = "Descrição do Produto B"},
            new Product { Id = Guid.NewGuid(), Name = "Produto C", Description = "Descrição do Produto C"}
        };

        context.Products.AddRange(products);
        
        // Seed de Sales
        var sales = new List<Sale>
        {
            new Sale { Id = Guid.NewGuid(), ClientId = clients[0].Id, ProductId = products[0].Id, Quantity = 2},
            new Sale { Id = Guid.NewGuid(), ClientId = clients[1].Id, ProductId = products[1].Id, Quantity = 1},
            new Sale { Id = Guid.NewGuid(), ClientId = clients[2].Id, ProductId = products[2].Id, Quantity = 5}
        };

        context.Sales.AddRange(sales);

        context.SaveChanges();
    }
}
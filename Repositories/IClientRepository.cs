using FarmaApi.Models;
using System.Collections.Generic;
using System;

namespace FarmaApi.Repositories;

public interface IClientRepository
{
    List<Client> GetAll();
    
    Client GetById(Guid id);
    void Add(Client client);
    void SaveChanges();
}
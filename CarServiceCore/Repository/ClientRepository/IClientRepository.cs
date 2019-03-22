using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.ClientRepository
{
    public interface IClientRepository
    {
        List<Client> GetClients();
        
        void AddClient(Client client);

        bool ClientExists(Client client);

        void DeleteClient(int clientId);

        void UpdateClient(Client client);

        Client GetClient(int clientIc);

        List<Client> PartialSearchClients(string firstName, string lastName);

        List<Automobil> GetAutosOfClient(Client client);
       
    }
}
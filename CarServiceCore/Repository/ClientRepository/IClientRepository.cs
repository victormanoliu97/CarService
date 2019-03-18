using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.ClientRepository
{
    public interface IClientRepository
    {
        List<Client> GetClients();
        
        void AddClient(Client client);

        bool ClientExists(Client client);

        void DeleteClient(Client client);

        void UpdateClient(Client client);

        Client GetClient(Client client);

        List<Client> PartialSearchClients(Client client);
    }
}
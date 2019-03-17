using System.Collections.Generic;
using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Utils.Transformer;

namespace CarServiceCore.Repository.ClientRepository
{
    public class ClientRepository : IClientRepository
    {
        private readonly Entities _applicationContext;

        public ClientRepository(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }
        
        public List<Client> GetClients()
        {
            return _applicationContext.Clients.ToList();
        }

        public void AddClient(Client client)
        {
            _applicationContext.Clients.Add(client);
            _applicationContext.SaveChanges();
        }

        public bool ClientExists(Client client)
        {
            if (client == null) return false;
            var foundClient = _applicationContext.Clients.FirstOrDefault(client1 => client1.ClientId == client.ClientId);
            return foundClient != null;
        }

        public void DeleteClient(Client client)
        {
            if (client == null) return;
            if (ClientExists(client))
            {
                _applicationContext.Clients.Remove(client);
                _applicationContext.SaveChanges();
            }
        }

        public void UpdateClient(Client client)
        {
            if (client == null) return;
            if (ClientExists(client))
            {
                var clonedClient = client;
                ClientTransformer.MergeClientEntities(clonedClient, client);
            }

            _applicationContext.SaveChanges();
        }

        public Client GetClient(Client client)
        {
            if (client == null) return null;
            var foundClient = _applicationContext.Clients.FirstOrDefault(client1 => client1.ClientId == client.ClientId);
            return foundClient;
        }
    }
}
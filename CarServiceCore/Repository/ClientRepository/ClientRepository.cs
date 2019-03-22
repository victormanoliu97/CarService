using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
            if (ClientExists(client)) return;
            _applicationContext.Clients.Add(client);
            _applicationContext.SaveChanges();
        }

        public bool ClientExists(Client client)
        {
            if (client == null) return false;
            var foundClient = _applicationContext.Clients.FirstOrDefault(client1 => client1.ClientId == client.ClientId);
            return foundClient != null;
        }

        public void DeleteClient(int clientId)
        {
            if (clientId == null) return;
            var client = _applicationContext.Clients.FirstOrDefault(c => c.ClientId == clientId);
            if (ClientExists(client))
            {
                var queryGetAutosForClient = from auto in _applicationContext.Automobils
                    where auto.ClientId == client.ClientId
                    select auto;

                foreach (var auto in queryGetAutosForClient.ToList())
                {
                    foreach (var autoOrder in auto.Comandas)
                    {
                        _applicationContext.Comandas.Remove(autoOrder);
                    }

                    foreach (var autoOrderDetail in auto.DetaliiComandas)
                    {
                        _applicationContext.DetaliiComandas.Remove(autoOrderDetail);
                    }

                    _applicationContext.Automobils.Remove(auto);
                }

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

        public Client GetClient(int clientIc)
        {
            if (clientIc == null) return null;
            var foundClient = _applicationContext.Clients.FirstOrDefault(client1 => client1.ClientId == clientIc);
            return foundClient;
        }

        public List<Client> PartialSearchClients(string firstName, string lastName)
        {
            if (firstName == null && lastName == null) return null;
            
            var queryByFirstName = _applicationContext.Clients.Where(c => c.Nume.Contains(firstName));
            var queryByLastName = _applicationContext.Clients.Where(c => c.Nume.Contains(lastName));

            if (queryByFirstName.Any())
            {
                return queryByFirstName.ToList();
            }
            
            return queryByLastName.Any() ? queryByLastName.ToList() : null;
        }

        public List<Automobil> GetAutosOfClient(Client client)
        {
            return client?.Automobils.ToList();
        }
    }
}
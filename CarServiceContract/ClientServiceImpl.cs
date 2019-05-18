using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;
using CarServiceCore.Repository.ClientRepository;

namespace CarServiceContract
{
    public class ClientServiceImpl : IClientService
    {
        private static Entities _applicationContext = new Entities();
        private readonly ClientRepository clientRepository = new ClientRepository(_applicationContext);

        public ClientServiceImpl()
        {
        }

        public ClientServiceImpl(ClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public List<Client> GetClients()
        {
            return clientRepository.GetClients();
        }

        public void AddClient(Client client)
        {
            clientRepository.AddClient(client);
        }

        public bool ClientExists(Client client)
        {
            return clientRepository.ClientExists(client);
        }

        public void DeleteClient(int clientId)
        {
            clientRepository.DeleteClient(clientId);
        }

        public void UpdateClient(Client client)
        {
            clientRepository.UpdateClient(client);
        }

        public Client GetClient(int clientIc)
        {
            return clientRepository.GetClient(clientIc);
        }

        public List<Client> PartialSearchClients(string firstName, string lastName)
        {
            return clientRepository.PartialSearchClients(firstName, lastName);
        }

        public List<Automobil> GetAutosOfClient(Client client)
        {
            return clientRepository.GetAutosOfClient(client);
        }
    }
}

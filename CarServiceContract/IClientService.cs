using CarServiceCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceContract
{
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        List<Client> GetClients();

        [OperationContract]
        void AddClient(Client client);

        [OperationContract]
        bool ClientExists(Client client);

        [OperationContract]
        void DeleteClient(int clientId);

        [OperationContract]
        void UpdateClient(Client client);

        [OperationContract]
        Client GetClient(int clientIc);

        [OperationContract]
        List<Client> PartialSearchClients(string firstName, string lastName);

        [OperationContract]
        List<Automobil> GetAutosOfClient(Client client);
    }
}

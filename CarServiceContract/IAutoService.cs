using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;

namespace CarServiceContract
{
    [ServiceContract]
    public interface IAutoService
    {
        [OperationContract]
        List<Automobil> GetAutosOfClient(Client client);

        [OperationContract]
        bool AutoExists(Automobil auto);

        [OperationContract]
        void AddAuto(Automobil auto);

        [OperationContract]
        void UpdateAuto(Automobil auto);

        [OperationContract]
        void DeleteAuto(int autoId);

        [OperationContract]
        List<Comanda> GetOrdersForCar(Automobil auto);

        [OperationContract]
        Automobil GetAuto(int autoId);
    }
}

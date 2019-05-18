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
    public interface IOrderService
    {
        [OperationContract]
        List<Comanda> GetOrdersOfClient(Client client);

        [OperationContract]
        void AddOrder(Comanda order);

        [OperationContract]
        void DeleteOrder(Comanda order);

        [OperationContract]
        void UpdateOrder(Comanda order);

        [OperationContract]
        bool OrderExists(Comanda order);

        [OperationContract]
        void SetStatusToOrder(Comanda order, string status);

        [OperationContract]
        List<Comanda> GetOrderWithStatus(Comanda order, string status);

        [OperationContract]
        List<Operatie> GetOperationsForOrder(Comanda order);

        [OperationContract]
        List<Imagine> GetImagesForOrder(Comanda order);

        [OperationContract]
        List<Mecanic> GetMechanicsForOrder(Comanda order);

        [OperationContract]
        List<Comanda> GetOrdersBetweenDates(DateTime fromDate, DateTime toDate);

        [OperationContract]
        void AddOrderDetailsForOrder(DetaliiComanda orderDetail);
    }
}

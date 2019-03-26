using System;
using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        List<Comanda> GetOrdersOfClient(Client client);
        
        void AddOrder(Comanda order);

        void DeleteOrder(Comanda order);

        void UpdateOrder(Comanda order);

        bool OrderExists(Comanda order);

        void SetStatusToOrder(Comanda order, string status);

        List<Comanda> GetOrderWithStatus(Comanda order, string status);

        List<Operatie> GetOperationsForOrder(Comanda order);

        List<Imagine> GetImagesForOrder(Comanda order);

        List<Mecanic> GetMechanicsForOrder(Comanda order);

        List<Comanda> GetOrdersBetweenDates(DateTime fromDate, DateTime toDate);

        void AddOrderDetailsForOrder(DetaliiComanda orderDetail);
    }
}
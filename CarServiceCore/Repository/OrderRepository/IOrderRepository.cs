using System.Collections.Generic;
using CarServiceCore.Context;
using CarServiceCore.Model;

namespace CarServiceCore.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        List<Comanda> GetOrdersOfClient(Client client);
        
        void AddOrder(Comanda order, DetaliiComanda orderDetails);

        void DeleteOrder(Comanda order);

        void UpdateOrder(Comanda order);

        
    }
}
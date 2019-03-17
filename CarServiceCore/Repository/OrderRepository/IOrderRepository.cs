using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        List<Comanda> GetOrders();
    }
}
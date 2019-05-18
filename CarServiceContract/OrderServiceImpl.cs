using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;
using CarServiceCore.Repository.OrderRepository;

namespace CarServiceContract
{
    public class OrderServiceImpl : IOrderService
    {
        private static Entities _applicationContext = new Entities();
        private readonly OrderRepository orderRepository = new OrderRepository(_applicationContext);

        public OrderServiceImpl()
        {

        }

        public List<Comanda> GetOrdersOfClient(Client client)
        {
            return orderRepository.GetOrdersOfClient(client);
        }

        public void AddOrder(Comanda order)
        {
            orderRepository.AddOrder(order);
        }

        public void DeleteOrder(Comanda order)
        {
            orderRepository.DeleteOrder(order);
        }

        public void UpdateOrder(Comanda order)
        {
            orderRepository.UpdateOrder(order);
        }

        public bool OrderExists(Comanda order)
        {
            return orderRepository.OrderExists(order);
        }

        public void SetStatusToOrder(Comanda order, string status)
        {
            orderRepository.SetStatusToOrder(order, status);
        }

        public List<Comanda> GetOrderWithStatus(Comanda order, string status)
        {
            return orderRepository.GetOrderWithStatus(order, status);
        }

        public List<Operatie> GetOperationsForOrder(Comanda order)
        {
            return orderRepository.GetOperationsForOrder(order);
        }

        public List<Imagine> GetImagesForOrder(Comanda order)
        {
            return orderRepository.GetImagesForOrder(order);
        }

        public List<Mecanic> GetMechanicsForOrder(Comanda order)
        {
            return orderRepository.GetMechanicsForOrder(order);
        }

        public List<Comanda> GetOrdersBetweenDates(DateTime fromDate, DateTime toDate)
        {
            return orderRepository.GetOrdersBetweenDates(fromDate, toDate);
        }

        public void AddOrderDetailsForOrder(DetaliiComanda orderDetail)
        {
            orderRepository.AddOrderDetailsForOrder(orderDetail);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Model;
using CarServiceCore.Utils.Transformer;

namespace CarServiceCore.Repository.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Entities _applicationContext;

        public OrderRepository(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public List<Comanda> GetOrdersOfClient(Client client)
        {
            if (client == null) return null;
            var query = from order in _applicationContext.Comandas
                where order.ClientId == client.ClientId
                select order;

            return query.Any() ? query.ToList() : null;
        }

        public void AddOrder(Comanda order)
        {
            if (order == null) return;
            if (OrderExists(order)) return;
            var orderToAdd = new Comanda
            {
                ClientId = order.ClientId,
                AutoId = order.AutoId,
                StareComanda = order.StareComanda == null ? OrderStatusEnum.WaitingOrder.ElementAt(0).Value : order.StareComanda,
                DataSystem = DateTime.Now,
                DataProgramare = order.DataProgramare,
                DataFinalizare = order.DataFinalizare == null ? DateTime.Now.AddDays(1) : order.DataFinalizare,
                Descriere = order.Descriere,
                KmBord = order.KmBord == null ? 0 : order.KmBord,
                ValoarePiese = order.ValoarePiese == null ? 0 : order.ValoarePiese
            };
            _applicationContext.Comandas.Add(orderToAdd);
            _applicationContext.SaveChanges();
        }

        public void DeleteOrder(Comanda order)
        {
            if (order == null) return;
            if (!OrderExists(order)) return;
            
            var queryGetOrderDetailsForOrder = from o in _applicationContext.DetaliiComandas
                where o.ComandaId == order.ComandaId
                select o;
            if (!queryGetOrderDetailsForOrder.Any()) return;
            
            _applicationContext.Comandas.Remove(order);
            foreach (var orderDetail in queryGetOrderDetailsForOrder)
            {
                _applicationContext.DetaliiComandas.Remove(orderDetail);
            }
            _applicationContext.SaveChanges();
        }

        public void UpdateOrder(Comanda order)
        {
            if (order == null) return;
            var foundOrder = _applicationContext.Comandas.FirstOrDefault(o => o.ComandaId == order.ComandaId);
            if (foundOrder == null) return;
            OrderTransformer.MergeOrderEntities(foundOrder, order);
            _applicationContext.SaveChanges();
        }

        public bool OrderExists(Comanda order)
        {
            if (order == null) return false;
            var foundOrder = _applicationContext.Comandas.FirstOrDefault(o => o.ComandaId == order.ComandaId);
            return foundOrder != null;
        }

        public void SetStatusToOrder(Comanda order, string status)
        {
            if (order == null && status == null) return;
            var foundOrder = _applicationContext.Comandas.FirstOrDefault(o => o.ComandaId == order.ComandaId);
            if (foundOrder != null) order.StareComanda = status;
            _applicationContext.Comandas.AddOrUpdate(order);
            _applicationContext.SaveChanges();
        }

        public List<Comanda> GetOrderWithStatus(Comanda order, string status)
        {
            if (order == null && status == null) return null;
            var query = from o in _applicationContext.Comandas
                where o.ComandaId == order.ComandaId
                select o;

            return query.Any() ? query.ToList() : null;
        }

        public List<Operatie> GetOperationsForOrder(Comanda order)
        {
            if (order == null) return null;
            if (!OrderExists(order)) return null;
            var queryGetOrderDetailsForOrder = from o in _applicationContext.DetaliiComandas
                where o.ComandaId == order.ComandaId
                select o;
            if (!queryGetOrderDetailsForOrder.Any()) return null;

            List<Operatie> operationsListForOrder = new List<Operatie>();
            foreach (var i in queryGetOrderDetailsForOrder.ToList())
            {
                operationsListForOrder.Add(i.Operatie);
            }

            return operationsListForOrder;
        }

        public List<Imagine> GetImagesForOrder(Comanda order)
        {
            if (order == null) return null;
            if (!OrderExists(order)) return null;
            var queryGetOrderDetailsForOrder = from o in _applicationContext.DetaliiComandas
                where o.ComandaId == order.ComandaId
                select o;
            if (!queryGetOrderDetailsForOrder.Any()) return null;
            
            var imageListForOrder = new List<Imagine>();
            foreach (var i in queryGetOrderDetailsForOrder.ToList())
            {
                imageListForOrder.Add(i.Imagine);
            }

            return imageListForOrder;
        }

        public List<Mecanic> GetMechanicsForOrder(Comanda order)
        {
            if (order == null) return null;
            if (!OrderExists(order)) return null;
            var queryGetOrderDetailsForOrder = from o in _applicationContext.DetaliiComandas
                where o.ComandaId == order.ComandaId
                select o;
            if (!queryGetOrderDetailsForOrder.Any()) return null;

            var orderMechanicsList = new List<Mecanic>();
            foreach (var i in queryGetOrderDetailsForOrder.ToList())
            {
                orderMechanicsList.Add(i.Mecanic);
            }

            return orderMechanicsList;
        }

        public List<Comanda> GetOrdersBetweenDates(DateTime fromDate, DateTime toDate)
        {
            var getOrderBetweenDatesQuery = from o in _applicationContext.Comandas
                where o.DataProgramare >= fromDate && o.DataFinalizare <= toDate
                select o;

            return getOrderBetweenDatesQuery.Any() ? getOrderBetweenDatesQuery.ToList() : null;
        }

        public void AddOrderDetailsForOrder(DetaliiComanda orderDetails)
        {
            var orderDetailsToAdd = new DetaliiComanda
            {
                ComandaId = orderDetails.ComandaId,
                AutoId = orderDetails.AutoId,
                MecanicId = orderDetails.MecanicId,
                OperatieId = orderDetails.OperatieId,
                ImagineId = orderDetails.ImagineId == null ? 0 : orderDetails.ImagineId
            };
            _applicationContext.DetaliiComandas.Add(orderDetailsToAdd);
            _applicationContext.SaveChanges();
        }
    }
}
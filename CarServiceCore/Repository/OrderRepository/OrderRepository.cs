using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.Sockets;
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

            return query.ToList();
        }

        public void AddOrder(Comanda order, DetaliiComanda orderDetails)
        {
            if (order != null)
            {
                var orderToAdd = new Comanda
                {
                    Client = order.Client,
                    ClientId = order.Client.ClientId,
                    Automobil = order.Automobil,
                    AutoId = order.Automobil.AutoId,
                    StareComanda = order.StareComanda == null ? OrderStatusEnum.WaitingOrder.ElementAt(0).Value : order.StareComanda,
                    DataSystem = DateTime.Now,
                    DataProgramare = order.DataProgramare,
                    Descriere = order.Descriere,
                    ValoarePiese = order.ValoarePiese == null ? 0 : order.ValoarePiese
                };
                var orderDetailsToAdd = new DetaliiComanda
                {
                    ComandaId = orderToAdd.DetaliiComandaId,
                    AutoId = orderToAdd.AutoId,
                    MecanicId = orderDetails.Mecanic?.MecanicId ?? 0,
                    OperatieId = orderDetails.Operatie?.OperatieId ?? 0,
                    ImagineId = orderDetails.Imagine?.ImagineId ?? 0
                };
                _applicationContext.Comandas.Add(orderToAdd);
                _applicationContext.DetaliiComandas.Add(orderDetailsToAdd);
                _applicationContext.SaveChanges();
            }
        }

        public void DeleteOrder(Comanda order)
        {
            if (order == null) return;
            _applicationContext.Comandas.Remove(order);

            var query = from o in _applicationContext.DetaliiComandas
                where o.DetaliiComandaId == order.DetaliiComandaId
                select o;

            List<DetaliiComanda> detailsOfOrder = query.ToList();
            foreach (var detailOrder in detailsOfOrder)
            {
                _applicationContext.DetaliiComandas.Remove(detailOrder);
            }

            _applicationContext.SaveChanges();
        }

        public void UpdateOrder(Comanda order)
        {
            if (order == null) return;
            var foundOrder = _applicationContext.Comandas.FirstOrDefault(o => o.ComandaId == order.ComandaId);
            OrderTransformer.MergeOrderEntities(foundOrder, order);
            _applicationContext.SaveChanges();
        }
    }
}
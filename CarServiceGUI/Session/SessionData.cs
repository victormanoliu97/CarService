using CarServiceCore.Context;
using CarServiceCore.Repository.AutoRepository;
using CarServiceCore.Repository.ChassisRepository;
using CarServiceCore.Repository.ClientRepository;
using CarServiceCore.Repository.MechanicRepository;
using CarServiceCore.Repository.OperationsRepository;
using CarServiceCore.Repository.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceGUI.Session
{
    public class SessionData
    {
        private static Entities _applicationContext = new Entities();
        public readonly ClientRepository clientRepository = new ClientRepository(_applicationContext);
        public readonly AutoRepository autoRepository = new AutoRepository(_applicationContext);
        public readonly ChassisRepository chassisRepository = new ChassisRepository(_applicationContext);
        public readonly OrderRepository orderRepository = new OrderRepository(_applicationContext);
        public readonly MechanicRepository mechanicRepository = new MechanicRepository(_applicationContext);
        public readonly OperationsRepository operationsRepository = new OperationsRepository(_applicationContext);
        public string Operation_Type { get; set; }
        public Client selectedClient { get; set; }
        public Automobil selectedAuto { get; set; }
        public Comanda selectedOrder { get; set; }
    }
}

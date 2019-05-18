using CarServiceCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceGUI.Session
{
    public class SessionData
    {
        public readonly ClientServiceClient clientRepository = new ClientServiceClient();
        public readonly AutoServiceClient autoRepository = new AutoServiceClient();
        public readonly ChassisServiceClient chassisRepository = new ChassisServiceClient();
        public readonly OrderServiceClient orderRepository = new OrderServiceClient();
        public readonly MechanicServiceClient mechanicRepository = new MechanicServiceClient();
        public readonly OperationServiceClient operationsRepository = new OperationServiceClient();
        public string Operation_Type { get; set; }
        public Client selectedClient { get; set; }
        public Automobil selectedAuto { get; set; }
        public Comanda selectedOrder { get; set; }
    }
}

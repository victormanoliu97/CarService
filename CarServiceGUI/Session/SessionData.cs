using CarServiceCore.Context;
using CarServiceCore.Repository.ClientRepository;
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
        public string Operation_Type { get; set; }
        public Client selectedClient { get; set; }
    }
}

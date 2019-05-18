using CarServiceContract;
using System;
using System.Diagnostics.Contracts;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace CarServiceHost
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            var clientHost = new ServiceHost(typeof(ClientServiceImpl),
                new Uri("http://localhost:8733/"));
            var autoHost = new ServiceHost(typeof(AutoServiceImpl),
                new Uri("http://localhost:8734/"));
            var chassisHost = new ServiceHost(typeof(ChassisServiceImpl),
                new Uri("http://localhost:8735/"));
            var orderHost = new ServiceHost(typeof(OrderServiceImpl),
                new Uri("http://localhost:8736/"));
            var mechanicHost = new ServiceHost(typeof(MechanicServiceImpl),
                new Uri("http://localhost:8737/"));
            var operationHost = new ServiceHost(typeof(OperationServiceImpl),
                new Uri("http://localhost:8738/"));

            clientHost.Open();
            autoHost.Open();
            chassisHost.Open();
            orderHost.Open();
            mechanicHost.Open();
            operationHost.Open();

            Console.ReadKey();

            clientHost.Close();
            autoHost.Close();
            orderHost.Close();
            mechanicHost.Close();
            operationHost.Close();
        }
    }
}
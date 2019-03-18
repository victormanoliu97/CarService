using CarServiceCore.Context;
using CarServiceCore.Repository.OrderRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTest.RepositoryTests
{
    [TestClass]
    public class OrderRepositoryTests
    {
        private static Entities CreateTestEntities()
        {
            return new Entities();
        }
        private static OrderRepository CreateTestClientRepository()
        {
            Entities applicationContext = CreateTestEntities();
            return new OrderRepository(applicationContext);
        }

        [TestMethod]
        private Comanda ReturnTestOrderEntity()
        {
            return new Comanda
            {
                AutoId = 2,
                ClientId = 4,
            };
        }
    }
}
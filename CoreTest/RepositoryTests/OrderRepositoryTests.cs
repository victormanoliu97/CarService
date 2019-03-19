using System;
using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Repository.OrderRepository;
using CarServiceCore.Utils.Transformer;
using FluentAssertions;
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
        private static OrderRepository CreateTestOrderRepository()
        {
            Entities applicationContext = CreateTestEntities();
            return new OrderRepository(applicationContext);
        }

        
        private Comanda ReturnTestOrderEntity()
        {
            return new Comanda
            {
                AutoId = 1,
                ClientId = 1,
                StareComanda = null,
                DataProgramare = new DateTime(2019, 03, 18),
                DataFinalizare = new DateTime(2019, 03, 20),
                Descriere = "Revizie",
                ValoarePiese = 200
            };
        }

        private DetaliiComanda ReturnTestOrderDetailsEntity()
        {
            return new DetaliiComanda
            {
                MecanicId = 2,
                OperatieId = 1,
                ImagineId = 2,
                ComandaId = 1,
                AutoId = 1
            };
        }

        [TestMethod]
        public void WhenOrderAdded_ItShouldAddSucessfully()
        {
            var testOrder = ReturnTestOrderEntity();
            var testOrderRepository = CreateTestOrderRepository();
            testOrderRepository.AddOrder(testOrder);
            CreateTestEntities().Comandas.Count().Should().BeGreaterOrEqualTo(0);
        }

        [TestMethod]
        public void WhenOrderDetailsAddeForOrder_ItShouldAddSucessfully()
        {
            var testOrderDetails = ReturnTestOrderDetailsEntity();
            var testOrderRepository = CreateTestOrderRepository();
            testOrderRepository.AddOrderDetailsForOrder(testOrderDetails);
            CreateTestEntities().DetaliiComandas.Count().Should().BeGreaterOrEqualTo(0);
        }

        [TestMethod]
        public void WhenMechanicsExistsForOrder_ItShouldReturnThem()
        {
            var testOrder = ReturnTestOrderEntity();
            testOrder.ComandaId = 1;
            var testOrderRepository = CreateTestOrderRepository();
            testOrderRepository.GetMechanicsForOrder(testOrder).Count.Should().Be(2);
        }
    }
}
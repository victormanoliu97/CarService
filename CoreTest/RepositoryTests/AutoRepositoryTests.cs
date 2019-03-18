using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Repository.AutoRepository;
using CarServiceCore.Utils.Transformer;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTest.RepositoryTests
{
    [TestClass]
    public class AutoRepositoryTests
    {
        private static Entities CreateTestEntities()
        {
            return new Entities();
        }
        
        private static AutoRepository CreateAutoRepository()
        {
            Entities applicationContext = CreateTestEntities();
            return new AutoRepository(applicationContext);
        }

        private Automobil CreateTestAutoEntity()
        {
            return new Automobil
            {
                AutoId = 2,
                ClientId = 4,
                NumarAuto = "B666BAD",
                SasiuId = 1,
                SerieSasiu = "XCXZZX"
            };
        }

        [TestMethod]
        public void WhenAutoAdded_AddAuto_ItShouldAddSuccessfully()
        {
            Automobil testAuto = CreateTestAutoEntity();
            AutoRepository testAutoRepository = CreateAutoRepository();
            testAutoRepository.AddAuto(testAuto);
            CreateTestEntities().Automobils.Count().Should().BeGreaterOrEqualTo(0);
        }

        [TestMethod]
        public void WhenAutoExists_AutoExists_ItShouldReturnTrue()
        {
            Automobil testAuto = CreateTestAutoEntity();
            AutoRepository testAutoRepository = CreateAutoRepository();
            testAutoRepository.AutoExists(testAuto).Should().BeTrue();
        }

        [TestMethod]
        public void WhenAutoExists_DeleteAuto_ItShouldReturnSuccessfully()
        {
            Entities applicationContext = CreateTestEntities();
            AutoRepository testAutoRepository = new AutoRepository(applicationContext);
            int testAutoId = 1;
            Automobil testAuto = applicationContext.Automobils.FirstOrDefault(a => a.AutoId == testAutoId);
            testAutoRepository.DeleteAuto(testAuto);
            applicationContext.Automobils.FirstOrDefault(a => a.AutoId == testAutoId).Should().BeNull();
        }

        [TestMethod]
        public void WhenAutoExists_UpdateAuto_ItShouldUpdateSuccessfully()
        {
            Entities applicationContext = CreateTestEntities();
            AutoRepository testAutoRepository = new AutoRepository(applicationContext);
            int testAutoId = 2;
            Automobil testAuto = applicationContext.Automobils.FirstOrDefault(a => a.AutoId == testAutoId);
            testAuto.NumarAuto = "Upd";
            testAutoRepository.UpdateAuto(testAuto);
            applicationContext.Automobils.FirstOrDefault(a => a.AutoId == testAutoId)?.NumarAuto.Should().Be("Upd");
        }
    }
}
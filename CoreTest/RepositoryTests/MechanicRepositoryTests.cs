using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Repository.MechanicRepository;
using CarServiceCore.Utils.Transformer;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTest.RepositoryTests
{
    [TestClass]
    public class MechanicRepositoryTests
    {
        private static Entities CreateTestEntities()
        {
            return new Entities();
        }

        private static MechanicRepository CreateTestMechanicRepository()
        {
            Entities applicationContext = CreateTestEntities();
            return new MechanicRepository(applicationContext);
        }

        private Mecanic CreateTestMechanicEntity()
        {
            return new Mecanic
            {
                Nume = "Gigel",
                Prenume = "Gigelescu"
            };
        }
        
        [TestMethod]
        public void WhenMechanicAdded_AddMechanic_ItShouldAddSuccessfully()
        {
            Mecanic testMechanic = CreateTestMechanicEntity();
            MechanicRepository testMechanicRepository = CreateTestMechanicRepository();
            testMechanicRepository.AddMechanic(testMechanic);
            CreateTestEntities().Mecanics.FirstOrDefault(m => m.MecanicId == testMechanic.MecanicId).Should().NotBeNull();
        }

        [TestMethod]
        public void WhenMechanicExists_MechanicExists_ItShouldReturnTrue()
        {
            Mecanic testMechanic = CreateTestMechanicEntity();
            MechanicRepository testMechanicRepository = CreateTestMechanicRepository();
            testMechanicRepository.MechanicExists(testMechanic).Should().BeTrue();
        }

        [TestMethod]
        public void WhenMechanicExists_DeleteMechanic_ItShouldDeleteSuccessfully()
        {
            Entities applicationContext = CreateTestEntities();
            MechanicRepository testMechanicRepository = new MechanicRepository(applicationContext);
            int testMechanicId = 1;
            Mecanic testMechanic = applicationContext.Mecanics.FirstOrDefault(m => m.MecanicId == testMechanicId);
            testMechanicRepository.DeleteMechanic(testMechanicId);
            applicationContext.Mecanics.FirstOrDefault(m => m.MecanicId == testMechanicId).Should().BeNull();
        }

        [TestMethod]
        public void WhenClientExists_UpdateMechanic_ItShouldUpdateSuccessfully()
        {
            Entities applicationContext = CreateTestEntities();
            MechanicRepository testMechanicRepository = new MechanicRepository(applicationContext);
            int testMechanicId = 3;
            Mecanic testMechanic = applicationContext.Mecanics.FirstOrDefault(m => m.MecanicId == testMechanicId);
            testMechanic.Nume = "Marinel";
            testMechanicRepository.UpdateMechanic(testMechanic);
            applicationContext.Mecanics.FirstOrDefault(m => m.MecanicId == testMechanicId)?.Nume.Should().Be("Marinel");
        }

        [TestMethod]
        public void WhenMechanicsWithCloseNamesExists_PartialMechanicSearch_ItShouldReturnResults()
        {
            Mecanic testMechanic = CreateTestMechanicEntity();
            MechanicRepository testMechanicRepository = CreateTestMechanicRepository();
            testMechanicRepository.PartialMechanicsSearch(testMechanic).Count.Should().BeGreaterThan(1);
        }
    }
}
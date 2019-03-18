using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Repository.ClientRepository;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTest.RepositoryTests
{
    [TestClass]
    public class ClientRepositoryTests
    {
        private static Entities CreateTestEntities()
        {
            return new Entities();
        }
        private static ClientRepository CreateTestClientRepository()
        {
            Entities applicationContext = CreateTestEntities();
            return new ClientRepository(applicationContext);
        }

        private Client CreateTestClientEntity()
        {
            return new Client
            {
                Nume = "Popescu",
                Prenume = "Ion",
                Email = "ion.popescu@gmail.com",
                Judet = "Iasi",
                Localitate = "Iasi",
                Adresa = "Tudor",
                Telefon = "0752094300"
            };
        }
        
        [TestMethod]
        public void WhenClientAdded_AddClient_ItShouldAddSuccessfully()
        {
            Client testClient = CreateTestClientEntity();
            ClientRepository testClientRepository = CreateTestClientRepository();
            testClientRepository.AddClient(testClient);
            CreateTestEntities().Clients.Count().Should().BeGreaterOrEqualTo(0);
        }

        [TestMethod]
        public void WhenClientExists_ClientExists_ItShouldReturnTrue()
        {
            Client testClient = CreateTestClientEntity();
            ClientRepository testClientRepository = CreateTestClientRepository();
            testClientRepository.ClientExists(testClient).Should().BeTrue();
        }

        [TestMethod]
        public void WhenClientDoesntExists_ClientExists_ItShouldReturnFalse()
        {
            Client testClient = CreateTestClientEntity();
            ClientRepository testClientRepository = CreateTestClientRepository();
            testClient.Nume = "Don't_Exist";
            testClientRepository.ClientExists(testClient).Should().BeFalse();
        }

        [TestMethod]
        public void WhenClientExists_DeleteClient_ItShouldReturnSuccessfully()
        {
            Entities applicationContext = CreateTestEntities();
            ClientRepository clientRepository = new ClientRepository(applicationContext);
            int testClientId = 2;
            Client testClient = applicationContext.Clients.FirstOrDefault(c => c.ClientId == testClientId);
            clientRepository.DeleteClient(testClient);
            applicationContext.Clients.FirstOrDefault(c => c.ClientId == testClientId).Should().BeNull();
        }

        [TestMethod]
        public void WhenClientExists_UpdateClient_ItShouldUpdateClientSuccessfully()
        {
            Entities applicationContext = CreateTestEntities();
            ClientRepository clientRepository = new ClientRepository(applicationContext);
            int testClientId = 2;
            Client testClient = applicationContext.Clients.FirstOrDefault(c => c.ClientId == testClientId);
            testClient.Nume = "Updated";
            clientRepository.UpdateClient(testClient);
            applicationContext.Clients.FirstOrDefault(c => c.ClientId == testClientId)?.Nume.Should().Be("Updated");
        }

        [TestMethod]        
        public void WhenClientsWithCloseFirstNamesExists_PartialClientSearch_ItShouldReturnResults()
        {
            Client testClient = CreateTestClientEntity();
            ClientRepository testClientRepository = CreateTestClientRepository();
            testClientRepository.PartialSearchClients(testClient).Count.Should().BeGreaterThan(1);
        }
    }
}
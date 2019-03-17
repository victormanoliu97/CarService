using CarServiceCore.Context;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreTesting.Testing
{
    [TestClass]
    public class PlsWork
    {
        [TestMethod]
        public void PlsWork_Test()
        {
            Entities applicationContext = new Entities();
            Client client = new Client();
            client.Nume = "Popescu";
            client.Prenume = "Ion";
            client.Email = "ion.popescu@gmail.com";
            client.Judet = "Iasi";
            client.Localitate = "Iasi";
            client.Adresa = "Tudor";
            client.Telefon = "0752094300";
            applicationContext.Clients.Add(client);
            applicationContext.SaveChanges();
            applicationContext.Clients.ToList().Count.Should().BeGreaterThan(0);

        }
    }
}

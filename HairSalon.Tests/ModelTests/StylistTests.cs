using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests : IDisposable
    {
        public void Dispose()
        {
            Stylist.ClearAll();
        }

        [TestMethod]
        public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
        {
            Stylist newStylist = new Stylist("test stylist");
            Assert.AreEqual(typeof(Stylist), newStylist.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "Test Stylist";
            Stylist newStylist = new Stylist(name);

            //Act
            string result = newStylist.Name;

            //Assert
            Assert.AreEqual(name, result);
        }
        [TestMethod]
        public void GetId_ReturnsStylistId_Int()
        {
            //Arrange
            string name = "Test Stylist";
            Stylist newStylist = new Stylist(name);

            //Act
            int result = newStylist.Id;

            //Assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void AddClient_AssociatesClientWithStylist_ClientList()
        {
            //Arrange
            string description = "Walk the dog.";
            Client newClient = new Client(description);
            List<Client> newList = new List<Client> { newClient };
            string name = "Work";
            Stylist newStylist = new Stylist(name);
            newStylist.AddClient(newClient);

            //Act
            List<Client> result = newStylist.Clients;

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}
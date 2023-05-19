using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HairSalon.Models;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTests : IDisposable
    {
        public void Dispose()
        {
            Client.ClearAll();
        }

        [TestMethod]
        public void ClientConstructor_CreatesInstanceOfClient_Client()
        {
            Client newClient = new Client("Ada");
            Assert.AreEqual(typeof(Client), newClient.GetType());
        }
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Ada";

            //Act
            Client newClient = new Client(description);
            string result = newClient.Description;

            //Assert
            Assert.AreEqual(description, result);
        }
        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string description = "Ada";
            Client newClient = new Client(description);

            //Act
            string updatedDescription = "Eve";
            newClient.Description = updatedDescription;
            string result = newClient.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_ClientList()
        {
            // Arrange
            List<Client> newList = new List<Client> { };

            // Act
            List<Client> result = Client.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetAll_ReturnsClients_ClientList()
        {
            //Arrange
            string description01 = "Ada";
            string description02 = "Eve";
            Client newClient1 = new Client(description01);
            Client newClient2 = new Client(description02);
            List<Client> newList = new List<Client> { newClient1, newClient2 };

            //Act
            List<Client> result = Client.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}
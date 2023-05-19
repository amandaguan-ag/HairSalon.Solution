using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HairSalon.Models;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTests
    {
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
            string updatedDescription = "Do the dishes";
            newClient.Description = updatedDescription;
            string result = newClient.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }

    }
}
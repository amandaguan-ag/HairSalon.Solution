using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests
    {
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
    }
}
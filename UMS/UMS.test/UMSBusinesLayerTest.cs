using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMSBusinesLayer;

namespace UMS.test
{
    [TestClass]
    public class UMSBusinesLayerTest
    {
        [TestMethod]
        public void ReturnRightsCodeTestWhenRightsIdIs0()
        {
            // Arrange
            Rights rights = new Rights(0);

            string expected = "READONLY";

            // Act
            string actual = rights.RightsCode;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnRightsCodeTestWhenRightsIdIs1()
        {
            // Arrange
            Rights rights = new Rights(1);

            string expected = "APROVE/REJECT";

            // Act
            string actual = rights.RightsCode;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnRightsCodeTestWhenRightsIdIs2()
        {
            // Arrange
            Rights rights = new Rights(2);

            string expected = "FULLACCESS";

            // Act
            string actual = rights.RightsCode;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnRightsCodeTestWhenRightsIdIsNegative()
        {
            // Arrange
            Rights rights = new Rights(-1);

            string expected = "READONLY";

            // Act
            string actual = rights.RightsCode;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnRightsCodeTestWhenRightsIdIsGreaterThan2()
        {
            // Arrange
            Rights rights = new Rights(3);

            string expected = "READONLY";

            // Act
            string actual = rights.RightsCode;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

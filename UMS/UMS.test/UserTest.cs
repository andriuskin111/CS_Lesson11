using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMSBusinesLayer;

namespace UMS.test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestingGetRights()
        {
            // Arrange
            User user = new User(1, new Rights(0), "Vasia");

            string expected = "READONLY";

            // Act
            string actual = user.GetRightsCode();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingChangeRights()
        {
            // Arrange
            User user = new User(1, new Rights(0), "Vasia");

            string expected = "APROVE/REJECT";

            // Act
            user.ChangeRights(new Rights(1));
            string actual = user.GetRightsCode();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

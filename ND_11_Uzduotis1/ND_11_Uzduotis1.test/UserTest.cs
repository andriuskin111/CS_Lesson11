using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinesLogicLevel;


namespace ND_11_Uzduotis1.test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestGetAge()
        {
            // Arrange
            User user = new User("Andrius", "Geniusas", new DateTime(1977, 03, 22));
            int expected = 43;

            // Act
            int actual = user.GetAge();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetAgeWhenBirthDateGreaterThanDateTimeNow()
        {
            // Arrange
            User user = new User("Andrius", "Geniusas", new DateTime(2077, 03, 22));
            int expected = -67;

            // Act
            int actual = user.GetAge();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

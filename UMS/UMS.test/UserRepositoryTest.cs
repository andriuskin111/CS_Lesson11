using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UMSBusinesLayer;

namespace UMS.test
{
    [TestClass]
    public class UserRepositoryTest
    {
        [TestMethod]
        public void TestingUserRetrieve()
        {
            // Arrange
            UserRepoository userRepoository = new UserRepoository();           
            string expected = "Katia";

            // Act
            User user = userRepoository.Retrieve(2);
            string actual = user.UserName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

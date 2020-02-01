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

        [TestMethod]
        public void TestingUserListRetrieve()
        {
            // Arrange
            UserRepoository userRepoository = new UserRepoository();
            int expected = 5;

            // Act
            List<User> userListRetrieved = userRepoository.Retrieve();
            int actual = userListRetrieved.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingUserAdd()
        {
            // Arrange
            UserRepoository userRepoository = new UserRepoository();           
            string expected = "Vasia";

            // Act
            userRepoository.AddUser(6, "Vasia", 1);
            User user = userRepoository.Retrieve(6);
            string actual = user.UserName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingUserAddWithMatchUserId()
        {
            // Arrange
            UserRepoository userRepoository = new UserRepoository();
            string expected = "Vasia";

            // Act
            userRepoository.AddUser(1, "Gena", 1);
            User user = userRepoository.Retrieve(1);
            string actual = user.UserName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingUserDelete()
        {
            // Arrange
            UserRepoository userRepoository = new UserRepoository();
            User expected = null;

            // Act
            userRepoository.DeleteUser(3);
            User actual = userRepoository.Retrieve(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

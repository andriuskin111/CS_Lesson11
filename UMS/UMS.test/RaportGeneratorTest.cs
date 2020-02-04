using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UMSBusinesLayer;

namespace UMS.test
{
    [TestClass]
    public class RaportGeneratorTest
    {
        [TestMethod]
        public void TestGenerateRaportItemList()
        {
            // Arrange
            UserRepoository userRepoository = new UserRepoository();
            List<User> userListRetrieved = userRepoository.Retrieve();
            List<RaportItem> userRaportItemList = new List<RaportItem>();
            RaportGenerator raportGenerator = new RaportGenerator(userListRetrieved);

            userRaportItemList = raportGenerator.GenerateRaport();
            int expected = userListRetrieved.Count;

            // Act
            int actual = userRaportItemList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

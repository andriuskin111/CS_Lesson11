using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UMSBusinesLayer;

namespace UMS.test
{
    [TestClass]
    public class ReportItemTest
    {
        [TestMethod]
        public void TestingConvertIntToString()
        {
            // Arrange
            RaportItem raportItem = new RaportItem(2, "Name", "FULLACCESS");
            string expected = "2";

            // Act
            string actual = raportItem.UserId;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

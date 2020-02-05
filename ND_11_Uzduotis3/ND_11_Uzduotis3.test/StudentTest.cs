using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLayer;

namespace ND_11_Uzduotis3.test
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestMarkAverage()
        {
            // Arrange
            Student student = new Student(1, "Vytas");

            student.markList.Add(8);
            student.markList.Add(10);
            student.markList.Add(9);
            student.markList.Add(7);

            double expected = 8.5;

            // Act
            double actual = student.GetMarkAverage();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMarkAverageWhenMarkListEmpty()
        {
            // Arrange
            Student student = new Student(1, "Vytas");

            double expected = 0;

            // Act
            double actual = student.GetMarkAverage();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMarkAverageWhenInMarkListIsOneMark()
        {
            // Arrange
            Student student = new Student(1, "Vytas");

            student.markList.Add(8);

            double expected = 8;

            // Act
            double actual = student.GetMarkAverage();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

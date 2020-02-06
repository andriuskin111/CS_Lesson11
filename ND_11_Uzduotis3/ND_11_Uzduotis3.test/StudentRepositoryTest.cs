using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LogicLayer;

namespace ND_11_Uzduotis3.test
{
    [TestClass]
    public class StudentRepositoryTest
    {
        [TestMethod]
        public void TestRetrieve()
        {
            // Arrange
            StudentRepository studentRepository = new StudentRepository(); 

            int expected = 5;

            // Act
            int actual = studentRepository.Retrieve().Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRetrieveWithId()
        {
            // Arrange
            StudentRepository studentRepository = new StudentRepository();
            Student student = studentRepository.Retrieve(2);

            string expected = "Petia";

            // Act
            string actual = student.StudentName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

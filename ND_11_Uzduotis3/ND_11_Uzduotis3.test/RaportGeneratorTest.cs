using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLayer;

namespace ND_11_Uzduotis3.test
{
    [TestClass]
    public class RaportGeneratorTest
    {
        [TestMethod]
        public void TestRaportGenerator()
        {
            // Arrange
            StudentRepository studentRepository = new StudentRepository();
            RaportGenerator raportGenerator = new RaportGenerator(studentRepository);

            string expected = "Student Id: 1, Name: Vasia" + Environment.NewLine +
                "Student Id: 2, Name: Petia" + Environment.NewLine +
                "Student Id: 3, Name: Liolik" + Environment.NewLine +
                "Student Id: 4, Name: Bolik" + Environment.NewLine +
                "Student Id: 5, Name: Egle" + Environment.NewLine;

            // Act
            string actual = raportGenerator.GenerateStudentRaport();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

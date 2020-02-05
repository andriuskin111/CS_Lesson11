using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLevel;

namespace ND_11_uzduotis2.test
{
    [TestClass]
    public class LibraryBookTest
    {
        [TestMethod]
        public void CheckOrDelayIfBookReaderWasLate()
        {
            // Arrange
            LibraryBook book = new LibraryBook(1, "Roneta", 30);

            book.ReaderName = "Petia";
            book.DateOfPickUp = new DateTime(2020, 01, 01);

            // Act
            bool actual = book.CheckOrDelay();

            // Assert
            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void CheckOrDelayIfBookReaderNotLate()
        {
            // Arrange
            LibraryBook book = new LibraryBook(1, "Roneta", 30);

            book.ReaderName = "Petia";
            book.DateOfPickUp = new DateTime(2020, 01, 20);

            // Act
            bool actual = book.CheckOrDelay();

            // Assert
            Assert.IsFalse(actual);

        }
    }
}

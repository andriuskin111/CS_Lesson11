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
            LibraryBook book = new LibraryBook(1, "Roneta", 30, 0.34m);

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
            LibraryBook book = new LibraryBook(1, "Roneta", 30, 0.34m);

            book.DateOfPickUp = new DateTime(2020, 01, 20);

            // Act
            bool actual = book.CheckOrDelay();

            // Assert
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void CheckDefaultInterestIfBookReaderWasLate()
        {
            // Arrange
            LibraryBook book = new LibraryBook(1, "Roneta", 30, 0.34m);

            book.DateOfPickUp = new DateTime(2019, 12, 28);

            decimal expected = 3.4m;

            // Act
            decimal actual = book.GetDefaultInterest();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckDefaultInterestIfBookReaderNotLate()
        {
            // Arrange
            LibraryBook book = new LibraryBook(1, "Roneta", 30, 0.34m);

            book.DateOfPickUp = new DateTime(2020, 01, 20);

            decimal expected = 0m;

            // Act
            decimal actual = book.GetDefaultInterest();

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}

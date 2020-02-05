using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel;

namespace ND_11_uzduotis2
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book = new LibraryBook(1, "Roneta", 30);

            book.ReaderName = "Petia";
            book.DateOfPickUp = new DateTime(2020, 01, 20);

            Console.WriteLine($"Book Id: {book.BookId}, " +
                $"Book Name: {book.BookName}, " +
                $"Reader Name: {book.ReaderName}, " +
                $"Reader was late = {book.CheckOrDelay()}");

            Console.ReadLine();
        }
    }
}

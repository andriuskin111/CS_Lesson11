using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLevel
{
    public class LibraryBook
    {
        public int BookId { get; private set; }
        public string BookName { get; private set; }
        public int DaysToReturn { get; private set; }
        public string ReaderName { get; set; }
        public DateTime DateOfPickUp { get; set; }

        public LibraryBook(int bookId, string bookName, int daysToReturn)
        {
            BookId = bookId;
            BookName = bookName;
            DaysToReturn = daysToReturn;
        }

        public bool CheckOrDelay()
        {
            bool delay;
            double readingDays = (DateTime.Now - DateOfPickUp).TotalDays;

            if(readingDays > DaysToReturn)
            {
                delay = true;
            }
            else
            {
                delay = false;
            }


            return delay;
        }
    }
}

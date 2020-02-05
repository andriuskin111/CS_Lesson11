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
        public decimal DefaultInterest { get; private set; }

        public LibraryBook(int bookId, string bookName, int daysToReturn, decimal defaultInterest)
        {
            BookId = bookId;
            BookName = bookName;
            DaysToReturn = daysToReturn;
            DefaultInterest = defaultInterest;
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

        public decimal GetDefaultInterest()
        {
            if(CheckOrDelay() == false)
            {
                return  0;
            }
            else
            {
                decimal defaultInterestTotal = (Convert.ToInt32((DateTime.Now - DateOfPickUp).TotalDays) - DaysToReturn) * DefaultInterest;

                return defaultInterestTotal;
            }
        }
    }
}

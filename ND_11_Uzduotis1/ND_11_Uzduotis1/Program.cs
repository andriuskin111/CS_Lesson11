using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesLogicLevel;


namespace ND_11_Uzduotis1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Andrius", "Geniusas", new DateTime(1977, 03, 22));

            Console.WriteLine($"First Name: {user.FirstName}, Last Name: {user.LastName}, Age: {user.GetAge()}");

            Console.ReadLine();
        }
    }
}

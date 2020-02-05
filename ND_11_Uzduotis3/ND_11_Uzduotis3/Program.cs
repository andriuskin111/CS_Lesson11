using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;

namespace ND_11_Uzduotis3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Vytas");

            student.markList.Add(8);
            student.markList.Add(10);
            student.markList.Add(9);
            student.markList.Add(7);

            Console.Write($"Student Id: {student.markList}, Name: {student.StudentName}, Marks: ");

            foreach (var item in student.markList)
            {
                Console.Write($"{item},");
            }

            Console.WriteLine($"\nMarks Average: {student.GetMarkAverage()}");

            Console.ReadLine();
        }
    }
}

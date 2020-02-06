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
            StudentRepository studentRepository = new StudentRepository();
            List<Student> studentList;

            studentList = studentRepository.Retrieve();           

            foreach (var student in studentList)
            {
                Console.WriteLine($"Student Id: {student.StudentId}, " +
                    $"Name: {student.StudentName}, " +
                    $"Olympics Winner: {student.OlympicsWinner}");
            }

            RaportGenerator raportGenerator = new RaportGenerator(studentRepository);
            string studentsRaport = raportGenerator.GenerateStudentRaport();

            Console.WriteLine(studentsRaport);

            Console.ReadLine();
        }
    }
}

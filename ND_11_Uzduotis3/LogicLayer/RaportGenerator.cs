using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class RaportGenerator
    {
        private StudentRepository _studentRepository;
        public RaportGenerator(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public string GenerateStudentRaport()
        {
            string result = "";
            List<Student> allStudents = _studentRepository.Retrieve();

            foreach (var student in allStudents)
            {
                result += "Student Id: " + student.StudentId + ", Name: " + student.StudentName + Environment.NewLine;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class StudentRepository
    {
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>();
            _students.Add(new Student(1, "Vasia", false));
            _students.Add(new Student(2, "Petia", false));
            _students.Add(new Student(3, "Liolik", false));
            _students.Add(new Student(4, "Bolik", false));
            _students.Add(new Student(5, "Egle", true));
        }

        public Student Retrieve(int studentId)
        {
            foreach (var student in _students)
            {
                if(studentId == student.StudentId)
                {
                    return student;
                }
            }
            return null;
        }

        public List<Student> Retrieve()
        {
            return _students;
        }
    }
}

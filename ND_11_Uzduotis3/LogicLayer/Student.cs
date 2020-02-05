using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Student
    {
        public int StudentId { get; private set; }
        public string StudentName { get; private set; }
        public List<int> markList;

        public Student(int studentId, string studentName)
        {
            StudentId = studentId;
            StudentName = studentName;
            markList = new List<int>();    
        }

        public double GetMarkAverage()
        {
            if(markList.Count < 1)
            {
                return 0;
            }
            else
            {
                double markSum = 0;

                for (int i = 0; i < markList.Count; i++)
                {
                    markSum += markList.ElementAt(i);
                }

                return markSum / markList.Count;
            }
            
        }
    }
}

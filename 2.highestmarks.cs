using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.highestmarks
{
    class Student
    {

        string student_Name;
        int student_marks;

        public override string ToString()
        {
            return " " + student_Name + " " +
                          student_marks;
        }
        static void Main(string[] args)
        {

            List<Student> student = new List<Student>()
            {
              new Student{ student_Name = "Anila",student_marks = 78 },
              new Student{ student_Name = "sravanthi",student_marks = 88 },
              new Student{ student_Name = "Gopi",student_marks = 79 },
              
            };

            IEnumerable<Student> result = from s in student
            let total = student.Sum(marks => marks.student_marks)
            let average = total / 5
            where s.student_marks > average

            select s;

            Console.WriteLine("Highest-marks");
            foreach (Student x in result)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }

}

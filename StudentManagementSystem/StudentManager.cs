using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class StudentManager
    {
        public List<Student> Students = new List<Student>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student.Name + " " + student.Age);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Query_returns_an_Anonymous_Type
{

    public class Program
    {
        public static void Main()
        {
            IList<Student> studentList = new List<Student>() {
                            new Student() { StudentID = 1, StudentName = "John", age = 18 },
                            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
                            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
                            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
                            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
                         };

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName };

            foreach (var stud in students)
                Console.WriteLine(stud.Id + "-" + stud.Name);
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }
}






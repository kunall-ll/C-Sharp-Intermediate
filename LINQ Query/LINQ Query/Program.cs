﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query
{
    class Program
    {
        public static void Main()
        {
            // Student collection
            // Specify the data source.
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21, StandardID = 1 }
        };
            // Define the query expression.
            var studentNames = studentList.Where(s => s.Age >= 18)
                                  .Where(st => st.StandardID > 0)
                                  .Select(s => s.StudentName);

            // Execute the query
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }


        }

        public class Student
        {

            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public int StandardID { get; set; }
        }
    }
}

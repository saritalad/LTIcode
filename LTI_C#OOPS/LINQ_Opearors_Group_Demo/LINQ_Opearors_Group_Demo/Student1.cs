using System;
using System.Collections.Generic;
using System.Text;
// Assignment  :write class Batch with BatchId,BatchName , Trainers LIst for every batch
namespace LINQ_Opearors_Group_Demo
{
    public class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student1> GetStudents()
        {
            return new List<Student1>()
            {
                new Student1(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Java", "C++"} },
                new Student1(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Student1(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"} },
                new Student1(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }
    }
}

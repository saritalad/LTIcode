using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Opearors_Group_Demo
{
    public class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public List<string> Technology { get; set; }
        public static List<Employee1> GetEmployees()
        {
            List<Employee1> Employee1s = new List<Employee1>()
            {
                new Employee1 {ID = 101, Name = "Preety", Gender = "Female", Salary = 60000,
                              Technology = new List<string>() {"C#", "Jave", "C++"} },
                new Employee1 {ID = 102, Name = "Priyanka", Gender = "Female", Salary = 50000,
                              Technology =new List<string>() { "WCF", "SQL Server", "C#" } },
                new Employee1 {ID = 103, Name = "Hina", Gender = "Female", Salary = 40000,
                              Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                new Employee1 {ID = 104, Name = "Anurag", Gender = "Male", Salary = 450000},
                new Employee1 {ID = 105, Name = "Sambit", Gender = "Male", Salary = 550000},
                new Employee1 {ID = 106, Name = "Sushanta", Gender = "Male", Salary = 700000,
                             Technology =new List<string>() { "ADO.NET", "C#", "LINQ" }}
            };
            return Employee1s;
        }
    }
}
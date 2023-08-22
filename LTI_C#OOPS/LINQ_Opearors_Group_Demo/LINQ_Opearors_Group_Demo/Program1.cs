using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Opearors_Group_Demo
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Using Query Syntax
            List<Employee> basicQuery = (from emp in Employee.GetEmployees() where emp.ID> 103
                                         select emp).ToList();
            foreach (Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("==========================================");
            //Using Method Syntax
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();
            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.ReadKey();
        }
    }
}

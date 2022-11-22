using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Opearors_Group_Demo
{
    class Program3
    {
      /*  static void Main(string[] args)
        {
            //Query Syntax
            IEnumerable<Employee> selectQuery = (from emp in Employee.GetEmployees()
                                                 select new Employee()
                                                 {
                                                     FirstName = emp.FirstName,
                                                     LastName = emp.LastName,
                                                     Salary = emp.Salary
                                                 });

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }

            //Method Syntax
            List<Employee> selectMethod = Employee.GetEmployees().
                                          Select(emp => new Employee()
                                          {
                                              FirstName = emp.FirstName,
                                              LastName = emp.LastName,
                                              Salary = emp.Salary
                                          }).ToList();
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }
            Console.ReadKey();
        }*/
    }
}

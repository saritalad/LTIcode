using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.EmpServices
{
    public static class EmpService
    {
        public static List<Employee> employeeList { get; }
        static EmpService()
        {
            employeeList = new List<Employee>()
            {
                new Employee{ Id=1001,Name="Bill",Department="IT"},
                   new Employee{ Id=1002,Name="Jill",Department="Accounts"},
                      new Employee{ Id=1003,Name="Gill",Department="IT"},
            };
        }

        public static int nextId = 1004;
            public static void   Add( Employee newemp)
            {
            newemp.Id = nextId;
            employeeList.Add(newemp);
            nextId++;
            }
        public static void Update(Employee modifiedobj)
        {
            int objeIndex = employeeList.FindIndex(emp => emp.Id == modifiedobj.Id);
            if (objeIndex == -1)
                return;
            else

                employeeList[objeIndex] = modifiedobj;

        }
        

        public static List<Employee>GetAll()
        {
            return employeeList;
        }

        public static Employee Getemp(int id)
        {            return employeeList.FirstOrDefault(emp => emp.Id == id);
        }

        public static void Delete(int id)
        {
            Employee emp = Getemp(id);
            if (emp is null)
                return;
            else
                employeeList.Remove(emp);
               

        }


    }
}

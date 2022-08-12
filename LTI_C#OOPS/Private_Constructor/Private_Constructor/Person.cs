using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMSConcepts
{
    class Person
    {
        long contact;
        string firstname,lastname;
        int age;
        public Person()
        {
            contact = 9898987665;
            firstname = "Bill";
            lastname = "James";
            age = 50;
            Console.WriteLine("Person Constructor Called ");
        }

              ~Person()
          {
              Console.WriteLine("Person Destructor Called ");   }   }
    
    class Employee : Person
    {
        int salary;

         public Employee ()
        {   
            salary = 50000;
             Console.WriteLine("Employee Constructor Called ");
        }
        ~Employee()
        {
            Console.WriteLine("Employee Destructor Called ");   }  }
        class Manager : Employee
    {
        int saleqty;
        int commision;
        public Manager()
        {
            saleqty = 100;
            commision = 1000;
            Console.WriteLine("Manager Constructor Called ");
        }
        ~Manager()
        {
            Console.WriteLine("Manager Destructor Called ");
        }

    }





}

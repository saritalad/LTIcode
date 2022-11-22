using MVC_INMemoryDB_IMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_INMemoryDB_IMP.INMSERVICES
{
    public static class CustomerService
    {
        public static List<Customer> CustomersList { get; }
      static CustomerService()
        {
            CustomersList = new List<Customer>
            {
                new Customer {
                    CustomerID = 1001,
                    Name = "Karthik",
                    Address = "Chennai",
                    DOB = Convert.ToDateTime("2000-11-02"),
                    PAN_Number = "BQMPS6580E"
                },
                new Customer {
                    CustomerID = 1002,
                    Name = "Megala",
                    Address = "Chennai",
                    DOB = Convert.ToDateTime("2000-11-02"),
                    PAN_Number = "BQMPS6580F"
                },
                new Customer
                {
                    CustomerID = 1003,
                    Name = "Nikhil Reddy",
                    Address = "Hyderabad",
                    DOB = Convert.ToDateTime("2000-11-02"),
                    PAN_Number = "BQMPS6580G"
                },
                new Customer
                {
                    CustomerID = 1004,
                    Name = "Sivani Josyula",
                    Address = "Hyderabad",
                    DOB = Convert.ToDateTime("2000-11-02"),
                    PAN_Number = "BQMPS6580I"
                },
            };

        }

        static int nextId = 1005;
        public static void Add(Customer NewCustomerobj)
        {

            NewCustomerobj.CustomerID = nextId;
            CustomersList.Add(NewCustomerobj);
            nextId++;
        }
        public static List<Customer >GetAll()
        {
            return CustomersList;

       }
        public static Customer GetCustomer(int GivenId)
        {
            return CustomersList.FirstOrDefault(cust => cust.CustomerID == GivenId);

                    }

        public static void Update(Customer modifiedcustomerobj)
        {

            int objectIndexInsideTheList = CustomersList.FindIndex(cust => cust.CustomerID == modifiedcustomerobj.CustomerID);
            if (objectIndexInsideTheList is -1)
                return;
            else
                CustomersList[objectIndexInsideTheList] = modifiedcustomerobj;

        
        }

        public static void Delete(int CustId)
        {

            var customer = GetCustomer(CustId);
            if (customer is null)
                return;
            else
                CustomersList.Remove(customer);
        }

    }
}

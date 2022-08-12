using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamdaExpressionsOnList
{

    class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public Person(string ssn, string name, string addr, int age)
        {
            SSN = ssn;
            Name = name;
            Address = addr;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();

            listPersonsInCity.Add(new Person("203456876", "John",    "12 Main Street, Newyork, NY",      15));
            listPersonsInCity.Add(new Person("203456877", "SAM",     "13 Main Ct, Newyork, NY",          25));
            listPersonsInCity.Add(new Person("203456878", "Elan",    "14 Main Street, Newyork, NY",      35));
            listPersonsInCity.Add(new Person("203456879", "Smith",   "12 Main Street, Newyork, NY",      45));
            listPersonsInCity.Add(new Person("203456880", "SAM",     "345 Main Ave, Dayton, OH",         55));
            listPersonsInCity.Add(new Person("203456881", "Sue",     "32 Cranbrook Rd, Newyork, NY",     65));
            listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY",        65));
            listPersonsInCity.Add(new Person("203456883", "Mac",     "126 Province Ave, Baltimore, NY",  85));
            listPersonsInCity.Add(new Person("203456884", "SAM",     "126 Province Ave, Baltimore, NY",  95));

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine(" Retrieving Top 2 aged persons from the list who are older than 60 years\n");
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine(" Name : " + person.Name + " \t\tAge: " + person.Age);
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\n Checking whether any person is teen-ager or not...");
            if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine(" Yes, we have some teen-agers in the list");
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\nCheking whether all the persons are older than 10 years or not...");
            if ( listPersonsInCity.All(e => (e.Age > 10)))
            {
                Console.WriteLine(" Yes, all the persons older than 10 years");
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\n Getting Average of all the person's age...");
            double avgAge = listPersonsInCity.Average(e => e.Age);
            Console.WriteLine(" The average of all the person's age is: "+ avgAge);

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\n Checking whether a person having name 'SAM' exists or not...");
           if (listPersonsInCity.Exists(e => e.Name == "SAM"))
            {
                Console.WriteLine(" Yes, A person having name  'SAM' exists in our list");
            }

           Console.WriteLine("\n-----------------------------------------------------------------------------");
           Console.WriteLine("\n Checking the index position of a person having name 'Smith' ...");
           int indexForSmith = listPersonsInCity.FindIndex(e => e.Name == "Smith");
           Console.WriteLine(" In the list, The index position of a person having name 'Smith' is : " + indexForSmith);


           Console.WriteLine("\n-----------------------------------------------------------------------------");
           Console.WriteLine("\n Getting the name of the most aged person in the list ...");
           Person p = listPersonsInCity.First(m=> m.Age == (listPersonsInCity.Max(e => e.Age)));
           Console.WriteLine(" The most aged person in our list is: "+ p.Name +" whose age is: "+ p.Age);

           Console.WriteLine("\n-----------------------------------------------------------------------------");
           Console.WriteLine("\n Getting Sum of all the person's age...");
           int sumOfAges = listPersonsInCity.Sum(e => e.Age);
           Console.WriteLine(" The sum of all the persons's age = "+ sumOfAges);

           Console.WriteLine("\n-----------------------------------------------------------------------------");
           Console.WriteLine("\n Skipping every person whose age is less than 60 years...");
           foreach (Person pers in listPersonsInCity.SkipWhile(e => e.Age < 60))
           {
               Console.WriteLine(" Name : "+ pers.Name + " \t\tAge: "+ pers.Age);
           }

           Console.WriteLine("\n-----------------------------------------------------------------------------");
           Console.WriteLine(" Displaying the persons until we find a person with name starts with other than 'S'");
           foreach (Person pers in listPersonsInCity.TakeWhile(e => e.Name.StartsWith("J")))
           {
               Console.WriteLine(" Name : " + pers.Name + " \t\tAge: " + pers.Age);
           }

           Console.WriteLine("\n-----------------------------------------------------------------------------");
           Console.WriteLine("\n Checking all the persons have SSN or not ...");
           if(listPersonsInCity.TrueForAll(e => e.SSN != null))
           {
               Console.WriteLine(" No person is found without SSN");
           }

           Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\n Removing all the persons record from list that have “SAM” name");
            listPersonsInCity.RemoveAll(e => (e.Name == "SAM"));
            if (listPersonsInCity.TrueForAll(e => e.Name != "SAM"))
            {
                Console.WriteLine(" No person is found with 'SAM' name in current list");
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\n Finding the person whose SSN = 203456876 in the list");
            Person oPerson = listPersonsInCity.Find(e => (e.SSN == "203456876"));
            Console.WriteLine(" The person having SSN '203456876' is : " + oPerson.Name + " \t\tAge: " + oPerson.Age);
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.Read();
        }
    }
}

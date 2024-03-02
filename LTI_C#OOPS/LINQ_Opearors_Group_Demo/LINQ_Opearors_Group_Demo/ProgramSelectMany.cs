using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Opearors_Group_Demo
{
    class ProgramSelectMany
    {
        static void Main(string[] args)
        {   // method syntax of SelectMany
            List<string> nameList = new List<string>() { "Pranaya", "Kumar" };
            IEnumerable<char> methodSyntax = nameList.SelectMany(x => x);
            foreach (char c in methodSyntax)
            {
                Console.Write(c + " ");
            }
            //Query Syntax of SelectMany
            Console.WriteLine("\n.........................................\n");
            IEnumerable<char> querySyntax = from str in nameList
                                            from ch in str
                                            select ch;
            foreach (char c in querySyntax)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine("\n....................Query Syntax Selectmany     .........................\n");
            var selectMnyQuery = from s in Student1.GetStudents().SelectMany(p => p.Programming)
                                 select s;
            foreach (string s in selectMnyQuery)
            { Console.WriteLine("Programming Languages " + s); }

            Console.WriteLine("\n .....................  Method Syntax SelectMany ........................\n");
            List<string> languages = Student1.GetStudents().SelectMany(p => p.Programming).Distinct().ToList();

            foreach (string s in languages)
            { Console.WriteLine("Programming Languages " + s); }



            Console.ReadKey();

        }
    }
}

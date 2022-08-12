using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMSConcepts
{
    class Student
    {
        int rollno;
        string name;
        //private constructor 
        Student()
        {
            Console.WriteLine("This is private construcor");
        }
        //public constructor
        public Student(int r, string nm)
        {
            rollno = r;
            name = nm;
            Console.WriteLine("This is public  construcor");
        }
    }
}

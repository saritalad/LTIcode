using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMSConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
          
            TypeScripter T = new TypeScripter();
            Console.WriteLine("static variable price ="+TypeScripter.Price );// initialized to zero 
            Console.WriteLine("non static variable Pages =" +T.Pages);// initialized to default value zero
            TypeScripter t1 = new TypeScripter();
            Console.ReadKey();
        }
    }      
}
 
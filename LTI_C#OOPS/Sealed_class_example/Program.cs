using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sealed_class_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Weight w = new Weight(5, 300);
            //myclass1 d = new myclass1(2, 2, 200);
            Console.WriteLine(w);
           // Console.WriteLine(d.ToString());
        }
    }
}

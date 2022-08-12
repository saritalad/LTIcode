using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(3);
            Square s2 = new Square(4);

            bool val = s1.Equals(s2);
            if (val == true)
                Console.WriteLine("s1 equals to s2");
            else
                Console.WriteLine("s1 not equals to s2");
        }
    }
}

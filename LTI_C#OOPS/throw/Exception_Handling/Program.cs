using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = 3,z;
            if (x / y != 0)
                throw new myException("number is not divisible by 5");
           
        }
    }
}

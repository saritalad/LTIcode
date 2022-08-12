using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace throw_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if ((num < 1) && (num > 7))
                throw (new ArgumentException(num + "'is not a valid format'(enter valid format)"));

            Console.ReadKey();

        }
    }
}

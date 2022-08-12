using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackTrace
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                fun1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                Console.WriteLine("Program ends.........");
            }
            Console.ReadLine();
        }

        public static void fun1()
        {
            fun2();
        }
        public static void fun2()
        {
            int x = 25, y = 0, z;
            z = x / y;
                    }


    }
}

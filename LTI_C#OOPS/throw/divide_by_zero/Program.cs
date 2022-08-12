using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 +----------------------------------------------------------------------+
 | Objective: Demonstrate simple exception demo of divide_by_zero_      |
 |            exception                                                 |   
 |                                                                      |
 +----------------------------------------------------------------------+
 */
namespace divide_by_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.WriteLine("Program Starts Here.....");
            try
            {
                a = 100 / b;
            }
            //one try block can have multiple catch blocks
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Exception Handled Here...");
            }
            Console.WriteLine("Remaining Program....");
            Console.ReadLine();
        }
    }
}

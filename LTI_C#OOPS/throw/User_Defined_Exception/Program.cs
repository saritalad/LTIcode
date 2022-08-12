using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 +----------------------------------------------------------------------+
 | Objective: Demonstrate user defined exception                        |                                 
 +----------------------------------------------------------------------+
 */

namespace User_Defined_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack s1 = new CStack(3);
            s1.push(10);
            s1.push(20);
            s1.push(30);
            
            //Uncomment this to show appropriate Allocationexception
            try
            {
                s1.push(40);
            }
            catch (AllocationException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine(s1.pop());
            Console.WriteLine(s1.pop());
            Console.WriteLine(s1.pop());

            //Uncomment this to show appropriate Allocationexception
            //try
            //{
            //    Console.WriteLine(s1.pop());
            //}
            //catch (AllocationException ae)
            //{
            //    Console.WriteLine(ae.Message);
            //}
            Console.ReadLine(); 
        }
    }
}

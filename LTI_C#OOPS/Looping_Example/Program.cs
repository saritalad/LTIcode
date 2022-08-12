using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // repeatition of same statements no of times 

            //  Console.WriteLine("enter n to display 1 to n numbers and their sum");
            //  n = Convert.ToInt32(Console.ReadLine());

            //// string name;
            //  //Console.WriteLine("Enter your name ");
            //  //name = Console.ReadLine();
            //  while(i<=n)
            //  {
            //      Console.Write(i+" ");
            //      sum += i;//  sum = sum +i
            //      i++;

            //  }
            //  Console.WriteLine("Sum of 1- " + n +" = "+sum);
            //  
            int i = 10, sum = 0;
            do
            {
                Console.Write(i + " ");
               // sum += i;//  sum = sum +i
                i++;


            } while (i <= 5);
          //  Console.WriteLine("Sum of 1- 5"+ " = " + sum);
          // for loop
          for(i=1;i<=5;i++)
            {
                Console.Write(i + " ");

            }




            Console.ReadKey();


        }
    }
}

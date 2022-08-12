using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 int x = 100, y;
                Console.WriteLine("enter y ");
                y = Convert.ToInt32(Console.ReadLine());
                if (y % 5 != 0)
                    throw new MyException("Not multiple of 5");
                else
                    Console.WriteLine("x/y =" + x / y);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //int[] myarray = new int[5];
            //try
            //{
            //    Console.WriteLine("Pls enter 5 numbers");
            //    for (int i = 0; i < 10; i++)
            //    {
            //        //if (i == 4)
            //        //    throw new Exception("Invalid argument");
            //        myarray[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //}

            //catch (System.IndexOutOfRangeException)
            //{
            //    Console.WriteLine("\nNo more numbers than 5");
            //}
            //catch (System.FormatException)
            //{
            //    Console.WriteLine("\nDo not press space bar give one number on each line");
            //}
        }

    }
}

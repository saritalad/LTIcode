using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace try_catch_example
{
    class Program
    {
        class myexception : DivideByZeroException
        {

            public myexception(string str)
                : base(str)
            {
            }
        }


        static void Main(string[] args)
        {   //{
            //    int[] myarry = new int[3];

            //    try
            //    {
            //        for (int i = 0; i < 5; i++)
            //        {
            //            myarry[i] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    catch (System.Exception)
            //    {
            //        Console.WriteLine("Out of bound Array");

            //    }
            //    finally
            //    {
            //        Console.WriteLine("End of P");
            //        Console.ReadLine();
            //    }
  //int v =0,y=1;
  //          try
  //          {
                
  //               y = Convert.ToInt32 (Console.ReadLine());
  //               v = 25 / y;
  //          }
  //          catch (Exception ex)
  //          {
  //              //Console.WriteLine("HelpLink = {0}", ex.HelpLink);
  //              Console.WriteLine("Message = {0}", ex.Message);
  //              //Console.WriteLine("Source = {0}", ex.Source);
  //              //Console.WriteLine("StackTrace = {0}", ex.StackTrace);
  //              //Console.WriteLine("TargetSite = {0}", ex.TargetSite);
  //          }

  //          finally
  //          {
  //              Console.WriteLine("End of P value ={0}",v);
  //              Console.ReadLine();
  //          }

            int x=25,y,z;

            try
            {
                y = Convert.ToInt32(Console.ReadLine());
                if (y < 1)
                    throw new myexception ("U can not divide by zero");
                else
                    z = x / y;
                Console.WriteLine(" ans = {0}", z);
            }

            catch (myexception  ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program ends");
            }
            Console.ReadLine();
        }


    }
}

     

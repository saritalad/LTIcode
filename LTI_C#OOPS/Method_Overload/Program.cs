using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            int answer1 = m.Add(40, 50);
            float answer2 = m.Add(40, 56.6f);
            int answer3 = m.Add(100, 200, 300);
            Console.WriteLine(" answer 1 =" + answer1 
                + "\n answer 2 =" + answer2 + "\n answer 3 =" + answer3);

            int radius = 7;
            int length = 10, breadth = 5;
            float Ar_circle;
            int Area_Rect;
            Ar_circle = Area(radius);
            Area_Rect = Area(length, breadth);
        
        }
        //overloaded static functions Area()
      public static  float  Area(int r)
        {
            return (float )(Math .PI *r*r);
        }

       public static  int  Area(int l,int b)
      {
          return (l * b);
       }


    }
}

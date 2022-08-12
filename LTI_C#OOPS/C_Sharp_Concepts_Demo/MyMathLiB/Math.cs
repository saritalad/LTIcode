using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLiB
{
    public static  class Math
    {

        public static int add(int a,int b)
        {

            return a + b;
        }

        public static int subtract(int a, int b)
        {
            if (a > b)

                return a - b;
            else
                return b - a;
        }
        public static int multiply(int a, int b)
        {
                            return a * b;
      
        }
        public static int divide(int a, int b)
        {if (a > b)

                return a / b;
            else
                return b / a;
        }
    }
}

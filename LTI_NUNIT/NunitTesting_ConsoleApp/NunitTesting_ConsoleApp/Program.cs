using NUnit.Framework;
using System;

namespace NunitTesting_ConsoleApp
{[TestFixture]
    class Program
    {
        static void Main()
        {
            int expected = 5;
            int numerator = 20;
            int denominator = 4;
            int actual = Divide(numerator, denominator);
             Assert.AreEqual(expected, actual);

        }

        [Test]
        public static int Divide(int a,int b)
        {

            return a / b;
        }


    }
}

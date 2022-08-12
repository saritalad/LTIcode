
using NUnit.Framework;
using System;
using NUITDEmo;
namespace NunitDemo.test
{[TestFixture]
    public class CalculatorTest
    {   [Test,Order(2)]
     
        public void Test_Addition_Valid_Integers()
        {
            var calc = new NUITDEmo.Calculator();
            int result = calc.Addition(7, 8);
           
            Assert.AreEqual(15, result);
        }
        [Test,Order(1)]
        public void Test_Subtraction()
        {
            var calc = new NUITDEmo.Calculator();
         
            Assert.Throws<ArgumentException>(() => calc.Subtraction(3, 4));

        }
      
      
    }
}

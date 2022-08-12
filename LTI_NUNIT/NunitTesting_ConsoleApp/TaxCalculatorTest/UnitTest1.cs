using NUnit.Framework;
using TaxCalculatorDemo;
namespace TaxCalculatorTest
{
    public class Tests
    {
       

        [Test]
        public void Test1()
        {
            TaxCalculator obj = new TaxCalculator(1000, 12);
            //action 
            int expected = 120;
            int actual = obj.GetTax();
            Assert.AreEqual(expected,actual);
        }




    }
}
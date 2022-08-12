using NUnit.Framework;

namespace NunutTestProject_Core_Demo
{
    [TestFixture]
    public class Tests
    {
       
        [Test]
        [TestCase(15, 35, 50)]
        [TestCase(10, 45, 55)]
        [TestCase(20, 50, 60)]
        public void AddMethodTest(int num1, int num2, int expected)
        {
            Calculator add = new Calculator();
            int result = add.Add(num1, num2);
            Assert.AreEqual(expected,result);
        }

        [Test]
        [TestCase(30,10,20)]
        [TestCase(45,10,35)]
        public void SubMethodTest(int num1,int num2, int expected)
        {
            Calculator obj = new Calculator();
            int result = obj.Sub(num1, num2);
            Assert.AreEqual(expected, result);
        }




        [Test]
       
        [MaxTime(1000)]
        public void AddMethodTest1()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(15, 65);
            Assert.That(result, Is.EqualTo(80));
        }
    }
}
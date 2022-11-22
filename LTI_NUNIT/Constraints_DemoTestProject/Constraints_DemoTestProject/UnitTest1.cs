using NUnit.Framework;

namespace Constraints_DemoTestProject
{[TestFixture]
    public class Tests
    {
        MathOperations obj = null;
        [SetUp]
        public void Setup()
        {
            obj = new MathOperations();
        }
        [TearDown]
        public void Clear()
        {
            obj = null;
        }

        [Test]
        public void Test1()
        {// arrange
            int a = 10, b = 20 ,expected=30;
            //act
       int     actual = obj.Add(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Ignore("not interested ")]
        [Test]
        public void Test2()
        {// arrange
            int a = 10, b = 20, expected = 30;
            //act
            int actual = obj.Sub(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
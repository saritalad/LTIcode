using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> first = new List<string>();
            first.Add("a");
           // first.Add("b");
          //  first.Add("c");
            List<string> second = new List<string>();
            second.Add("a");
            CollectionAssert.DoesNotContain(first, "x");
          //  CollectionAssert.AreEqual(first, second);
        }
    }
}

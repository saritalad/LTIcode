using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject2
{[TestClass]
    class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> str1 = new List<string>();
            str1.Add(null);
            str1.Add("a");
            str1.Add("b");
            CollectionAssert.AllItemsAreNotNull(str1);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject2
{[TestClass]
    class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            int quantity = 100;
            decimal price = 2.5m;
            decimal totalexpected = 251;
            decimal actual = quantity * price;
            Assert.AreEqual(totalexpected, actual);
        }

    }
}

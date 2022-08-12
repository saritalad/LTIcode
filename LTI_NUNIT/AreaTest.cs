using NUnit.Framework;
using MyAreas;
using System.Collections.Generic;

namespace TestProject1
{
    public class AreaTest
    {
        Areas areas = null;
        [SetUp]
        public void Init()
        {
            areas = new Areas();
        }
        [TearDown]
        public void CloseUp()
        {
            areas = null;
        }
        [Test]
        public void CircleTest()
        {
            // Areas areas = new Areas();
            float expvalue = 78;
            float actvalue = 0;
            actvalue = areas.Circle(5);
            Assert.AreEqual(expvalue, actvalue, 1, "Values not matching");
        }
        [Test]
        public void RectangleTest()
        {
            //arrange
            //Areas areas = new Areas();
            int expvalue = 400;
            int actvalue = 0;
            //act
            actvalue = areas.Rectangle(20, 20);
            //Assert
            Assert.AreEqual(expvalue, actvalue, "Wrong Values");
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void LoginTest()
        {
            string expresult = "user name or password is null !";
            string actresult = null;
            actresult = areas.Login("", "");
            Assert.AreEqual(expresult, actresult, "Messsages not same");
        }
        [Test]
        public void Login_Admin_Success_Message()
        {
            string expresult = "Welcome Admin";
            string actresult = areas.Login("Admin", "admin");
            Assert.AreEqual(expresult, actresult, "Welcome message not correct");
        }
        [Test]
        public void Login_Admin_Message_Contains_Welcome_OnSuccess()
        {
            string actresult = areas.Login("Admin", "admin");
            StringAssert.Contains("Welcome", actresult, "Message does not contain Welcome");
        }
        [Test]
        public void GetNames_Unique()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreUnique(names, "Names not Unique");

        }
        [Test]
        public void GetNames_Contains_Null()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreNotNull(names, "Collections contains null values");
        }
        [TestCase(20, 30, ExpectedResult = 600)]
        [TestCase(10, 20, ExpectedResult = 600)]
        [TestCase(40, 30, ExpectedResult = 1200)]
        //[TestCase(67483934859643628400266,10,)]
        public int Test2(int l, int b)
        {
            int actresult = areas.Rectangle(l, b);
            return actresult;

        }
    }
}
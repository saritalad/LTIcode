using NUnit.Framework;
using TestingDemo;
using System.Collections.Generic;
namespace TestAreas
{
    public class Tests
    {
        Areas areas = null;
        [SetUp]
        public void Setup()
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
        {//arrange
            float expected = 78;
            float actual = 0.0f;
            //Act
            actual = areas.Circle(5);
            //Assert
            Assert.AreEqual(expected, actual, 1, "Values are not matching");
        }
        [Test]
        public void Rectangle()
        {
            int expected = 400;
            int actual = 0;
            actual = areas.Rectangle(20, 20);
            Assert.AreEqual(expected, actual, 0, "Wrong value");
        }
//  test 1 for empty string
       [Test]
       public void LoginTest()
        {
            string expected = "user or pwd is null";
            string actual = null;
            actual = areas.Login("", "");

            Assert.AreEqual(expected, actual, "Messages not same ");
        }
// test 2 for correct admin 
        [Test]
        public void Login_Admin_Success_Message()
        {
            string expresult = "Welcome Admin";
            string actresult = areas.Login("Admin", "admin");
            Assert.AreEqual(expresult, actresult, "Welcome message not correct");
        }

        // test 3 for incorrect entry 

        [Test]
        public void Login_Admin_Message_Contains_Welcome_OnSuccess()
        {
            string actresult = areas.Login("Admin", "admin");
            StringAssert.Contains("Weldone", actresult, "Message does not contain Welcome");
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



    }
    }

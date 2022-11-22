using NUnit.Framework;

namespace LogInTestExample
{
    public class Tests
    {
        LoginClass obj;

        [SetUp]
        public void Setup()
        {
            obj = new LoginClass();
        }
        [TearDown]
        public void Destroy()
        {
            obj = null;
        }
        // test case 1 for empty  user and password
        [Test]
        public void LoginTestForEmpty()
        {// A arrange 
            string expected = "user or pwd is null";
            string actual = null;
            actual = obj.Login("","");
            //assert

            Assert.AreEqual(expected, actual, "Message not same");
        }
        // test case 2  for correct user and password 
        [Test]
        public void LoginTestForCorrectLogIn()
        {
            string expected = "Welcome Admin";
           var actual = obj.Login("Admin", "admin");
            //Assert
            Assert.AreEqual(expected, actual, "welcome message not correct");
            Assert.That(actual, Is.EqualTo("Welcome Admin"));
        }

        // test case 3 for incorrect login credentials

        // test3 for incorrect login
        [Test]
        public void LoginForTestIncorrectLogin()
        {
            string actual = obj.Login("Admin", "admin");
            StringAssert.Contains("Hello!", actual, "Message does not contain welcome");
           
        }


        [Test]
        public void DoesNotEndWith()
        {
            StringAssert.DoesNotEndWith("x", "abc");
        }
        [Test]
        public void EndsWith()
        {
            StringAssert.EndsWith("abc", "abc");
            StringAssert.EndsWith("abc", "123abc");
            StringAssert.StartsWith("ABC", "abc");
        }
        [Test]
        public void CaseInsensitiveCompare()
        {
            StringAssert.AreEqualIgnoringCase("name", "NAME");
        }



        public void ThatExample()
        {

            var sentence = "The good, the bad and the ugly";

            Assert.That(sentence, Is.Not.Null.And.Not.Empty);
            Assert.That(sentence, Is.EqualTo("The good, the bad and the ugly"));

            Assert.That(sentence, Does.StartWith("The good"));
            Assert.That(sentence, Does.Contain("the bad"));
            Assert.That(sentence, Does.EndWith("The ugly").IgnoreCase);

            // A second method of testing substring
            Assert.That(sentence, Contains.Substring("the bad"));
        }



    }
}
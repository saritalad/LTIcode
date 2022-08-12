using NUnit.Framework;
using Library_For_CollectionTest;
using System.Collections.Generic;

namespace Test_Collection_Assert
{
    public class Tests
    {
        CollectionDemo obj = null;
        
        [SetUp]
        public void Start()
        {
            obj= new CollectionDemo();
        }
        [TearDown]
        public void CloseUp()
        {
            obj = null;
        }

        [Test]
        public void GetNames_Unique()
        {
           
            List<string> names = obj.GetNames();
            CollectionAssert.AllItemsAreUnique(names, "Names not Unique");

        }
        [Test]
        public void GetNames_Contains_Null()
        {
            List<string> names = obj.GetNames();
            CollectionAssert.AllItemsAreNotNull(names, "Collections contains null values");
        }



    }


}
        
  
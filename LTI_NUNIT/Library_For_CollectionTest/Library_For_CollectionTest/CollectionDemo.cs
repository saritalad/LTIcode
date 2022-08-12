using System;
using System.Collections.Generic;

namespace Library_For_CollectionTest
{
    public class CollectionDemo
    {
       public List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add(null);
            names.Add("Raj");
            names.Add("Bob");
            names.Add("Ali");
            names.Add("Raj");
            return names;
        }
    }
}

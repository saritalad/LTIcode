using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMSConcepts
{
    class TypeScripter
    {
        int pages;

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        string name;
        static int price;

        public static int Price
        {
            get { return TypeScripter.price; }
            set { TypeScripter.price = value; }
        }
        // Non -Static Constructor
        public TypeScripter()
        {
            Console.WriteLine("This is a non static Constructor ");
        }

        static TypeScripter()
        {
            Console.WriteLine("This is a static Constructor ");
        }
    }

}
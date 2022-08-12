using System;
using System.Collections.Generic;
namespace NUnit_Test_Area_CollectionAssert
{
    public class MyAreas
    {
        public int Rectangle(int lenght, int breadth)
        {
            return lenght * breadth;
        }
        public float Circle(int radius)
        {
            return (float)Math.PI * radius * radius;
        }
        public string Login(string user, string pwd)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            { return "user or pwd is null"; }
            else if (user == "Admin" && pwd == "admin")
            { return "Welcome Admin"; }
            else
                return "Invalid user and pwd";
        }
        public List<string> Names()
        {
            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add(null);
            names.Add("Raj");
            names.Add("Bob");
            names.Add("Ali");
            return names;
        }
    }
}

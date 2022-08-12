using System;
using System.Collections.Generic;

namespace TestingDemo
{
    public class Areas
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

        public List<string>GetNames()
        {
            List<string> names = new List<string>()
            {
                "Akash","Kishor",null,"Amol","Raj"

            };
            return names;
        }
    }
}

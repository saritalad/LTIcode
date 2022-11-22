using System;
using System.Collections.Generic;
using System.Text;

namespace LogInTestExample
{
    class LoginClass
    {
        public string Login(string user, string pwd)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            { return "user or password is null"; }

            else if (user == "Admin" && pwd == "admin")

            { return "Welcome Admin"; }

            else

                return "Invalid user and pwd";
        }

    }
}

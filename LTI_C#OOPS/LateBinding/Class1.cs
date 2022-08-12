using System;
using System.Collections.Generic;
using System.Text;

namespace LateBinding
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=true,Inherited=true)]
    public class BookAtrribute:Attribute 
    {
        private string author, publisher, date;
        public BookAtrribute(string b, string p, string d)
        {
            this.author = b;
            this.publisher = p;
            this.date = d;
        }
        public string _author
        {
            get
            {
                return author;
            }
        }
        public string _publisher
        {
            get
            {
                return publisher;
            }
        }
        public string _date
        {
            get
            {
                return date;
            }
        }
    }
}

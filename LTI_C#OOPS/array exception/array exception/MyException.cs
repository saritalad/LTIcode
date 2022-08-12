using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array_exception
{
  class MyException:ApplicationException
    {
       
     public    MyException(string msg)
            : base(msg)
        {
        }
    }
}

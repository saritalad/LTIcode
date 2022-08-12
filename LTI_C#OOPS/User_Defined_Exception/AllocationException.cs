using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace User_Defined_Exception
{
    class AllocationException:ApplicationException
    {
        public AllocationException(string msg):base(msg)//passing message to the base class constructor
        {
        }
    }
}

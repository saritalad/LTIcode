using System;
using System.Collections.Generic;

using System.Text;

namespace Exception_Handling
{
    class myException:ApplicationException
    {
        public myException(string msg)
            : base(msg)
        { }
    }
}

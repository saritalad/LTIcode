using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sealed_class_example
{
  sealed  class Weight
  {
      int gm, kg;
      public Weight(int g,int k)
      {
          gm = g;
          kg = k;
  }
      public override string ToString()
      {
          return kg+"\t"+gm;
      }


    }
}

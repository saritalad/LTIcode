using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Example_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch HCLBatch = new Batch();
            int n = 101;
            Console.WriteLine(HCLBatch[n]);
            Console.WriteLine(" Id of Ruta is "+ HCLBatch["RUTA"]);
         //   HCLBatch[105] = "Smita";
            Console.WriteLine(HCLBatch[105]);

        }


    }
}

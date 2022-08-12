using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections ;

namespace Throw_use_for_data
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create new exception.
                var ex = new DivideByZeroException("Message");
                // Set the data dictionary.
                ex.Data["Time"] = DateTime.Now;
                ex.Data["Flag"] = true;
                // Throw it!
                throw ex;
            }
            catch (Exception ex)
            {
                // Display the exception's data dictionary.
                foreach (DictionaryEntry pair in ex.Data)
                {
                    Console.WriteLine("{0} = {1}", pair.Key, pair.Value);
                }
                Console.ReadLine();
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO ;

namespace LMSConcepts
{
    class FileReading:IDisposable
    {
        StreamReader reader;
        bool disposed;
        public FileReading()
        {
            reader = new StreamReader("s.txt");

        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (reader != null)
                {
                    reader.Dispose();
                    disposed = true;
                }

            }
        }
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multidimArray
{
    class Program
    {
        static void Main(string[] args)
        {string inputstr;
            int[,] temps = new int[3, 2];
            int i,j;
            for (i = 0; i <3; i++)
            {

                for ( j = 0; j < 2; j++)
                {
                    inputstr=Console .ReadLine();
                    temps [i,j]=Convert.ToInt32 (inputstr );

                
                }     
                }

            for (i = 0; i < 3; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    
                  Console.WriteLine ("Item={0}",  temps[i, j] );


                }
                Console.WriteLine("\n");

            }






            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {

            char[][] chararray = new char[3][];
            chararray[0] = new char[2];
            chararray[0][0] = 'S';
            chararray[0][1] = 'A';
            chararray[1] = new char[3];
            chararray[1][0] = 'R';
            chararray[1][1] = 'I';
            chararray[1][2] = 'T';
            chararray[2] = new char[1];
            chararray[2][0] = 'A';

            for (int i = 0; i < chararray.Length; i++)
            {
                Char[] innerArray = chararray[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(Convert.ToChar(Convert.ToInt32(innerArray[a]) + 32) + " ");
                }
            }

            //for (int i = 0; i < chararray.Length; i++)
            //{
            //    Char[] innerArray = chararray[i];
            //    foreach (char c in innerArray)
            //    {
            //        Console.Write(Convert.ToChar(Convert.ToInt32(c) + 32) + " ");
            //    }

            //}                        




            // Create a new array in the jagged array, and assign it.
            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[0][0] = 1;
            jagged[0][1] = 2;

            //// Set second row, initialized to zero.
            jagged[1] = new int[1];

            //// Set third row, using array initializer.
            jagged[2] = new int[3] { 3, 4, 5 };

            //// Print out all elements in the jagged array.
            for (int i = 0; i < jagged.Length; i++)
            {
                int[] innerArray = jagged[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }




        }
    }
}

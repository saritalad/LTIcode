using System;
using System.Linq;

namespace LINQ_Opearors_Group_Demo
{
    class Program
    {
     /*   static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var query = numbers.ToLookup(i => i % 2);
            //foreach (IGrouping<int, int> group in query)
            //{
            //    Console.WriteLine("Key: {0}", group.Key);
            //    foreach (int number in group)
            //    {
            //        Console.WriteLine(number);
            //    }

            //Using Method Syntax
            var GroupByMS = Student.GetStudents().ToLookup(s => s.Branch);
            //Using Query Syntax
            var GroupByQS = (from std in Student.GetStudents()
                             select std).ToLookup(x => x.Branch);
            //It will iterate through each group
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group
                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
                }
            }

            Console.Read();




        }*/
        }
    }

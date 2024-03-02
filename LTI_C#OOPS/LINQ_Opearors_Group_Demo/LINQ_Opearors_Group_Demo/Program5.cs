using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Opearors_Group_Demo
{
    class Program5
    {
        //static void Main(string[] args)
        //{
            //Using Method Syntax
            //List<string> MethodSyntax = Student1.GetStudents()
            //                            .SelectMany(std => std.Programming)
            //                            .Distinct()
            //                            .ToList();
            ////Using Query Syntax LINQ 
            //IEnumerable<string> QuerySyntax = (from std in Student1.GetStudents()
            //                                   from program in std.Programming
            //                                   select program).Distinct().ToList();
        
            
            //Printing the values
            //foreach (string program in QuerySyntax)
            //{
            //    Console.WriteLine(program);
            //}

        //    var QuerySyntax = (from std in Student1.GetStudents()
        //                       from program in std.Programming
        //                       select new
        //                       {
        //                           StudentName = std.Name,
        //                           ProgramName = program
        //                       }).ToList();
        //    //Printing the values
        //    foreach (var item in QuerySyntax)
        //    {
        //        Console.WriteLine(item.StudentName + " => " + item.ProgramName);
        //    }




        //    Console.ReadKey();
        //}




    }





}

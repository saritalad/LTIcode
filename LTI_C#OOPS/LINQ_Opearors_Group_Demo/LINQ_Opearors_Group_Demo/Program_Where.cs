//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace LINQ_Opearors_Group_Demo
//{
//    class Program_Where
//    {
//        static void Main(string[] args)
//        {
//            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           
//            var data = from num in intList 
//                       where num > 5
//                       select num;// linq query 

//            //Method Syntax Where(), Single()
//            IEnumerable<int> filteredData = intList.Where(num => num > 5);// method 



//            Console.WriteLine("Numbers greater than 5");
//            Console.WriteLine("\n................................\n");
//            foreach (int number in filteredData)
//            {
//                Console.WriteLine(number);
//            }

//            Console.WriteLine("\n............... example of Female students using Where extension methods..........\n");
//            List<Student> studlist = Student.GetStudents().Where(s => s.Gender == "Female").ToList();

//            foreach (Student s in studlist)
//                Console.WriteLine(s.Name + "  " + s.Gender);


//            Console.WriteLine($"Total number of Girls={studlist.Count}");// string interpolation



//            Console.WriteLine("\n............... example of  using First Or Default extension methods    for student with age >23..........\n");
//         var agedata = Student.GetStudents().First(s => s.Age >23);

//          //  foreach (Student s in agedata)
//                Console.WriteLine(agedata.Name+" "+agedata.Age);
//            Console.ReadKey();
//        }
//    }
//}

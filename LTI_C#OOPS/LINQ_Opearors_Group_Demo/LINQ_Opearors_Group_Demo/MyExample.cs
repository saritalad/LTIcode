using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Opearors_Group_Demo
{
    class MyExample
    {
        static void Main(string[] args)
        {
            var result = from s in Student.GetStudents()
                        where s.Age>20
                         select s;

            foreach(var stud in result)
                Console.WriteLine(stud.Name+ " "+stud.Age);

            var LResult = Student.GetStudents().FirstOrDefault(s => s.Name.Length > 8);
            Console.WriteLine("-----------------------------------------------");
            foreach (var stud in result)
                Console.WriteLine(stud.Name + " " + stud.Age);
            Console.WriteLine("--------------------------------------------------");

            var Result2 = Student1.GetStudents().SelectMany(s => s.Programming);
            foreach(string p in Result2)
                Console.WriteLine(p);

           Student name = Student.GetStudents().FirstOrDefault(s => s.Name == "Tina");
            Console.WriteLine("NAme :"+name.Name);
            List<Student> mystudents = Student.GetStudents();
            mystudents.Add(new Student() { ID = 122, Name = "xxxx", Age = 21, Branch = "IT", Gender = "female" });
            int j = mystudents.FindIndex(s => s.Name == "Tina");
            mystudents.RemoveAt(j);
            //  int k = Student.GetStudents().FindIndex(s => s.Name == "Tina");//
            Console.WriteLine("....................");
           foreach(var S in mystudents)
            {
                Console.WriteLine(S.Name);
            }
            Student sin = Student.GetStudents().SingleOrDefault(s => s.Name == "Tinaa");
            Console.WriteLine(sin.Name);
        }
    }
}

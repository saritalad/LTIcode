using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Opearors_Group_Demo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> students= new List<Student>()
        {
            new Student { ID = 1001, Name = "Preety", Gender = "Female",
                                        Branch = "CSE", Age = 20 },
            new Student { ID = 1002, Name = "Anurag", Gender = "Male",
                                        Branch = "ETC", Age = 21  },
            new Student { ID = 1003, Name = "Pranaya", Gender = "Male",
                                        Branch = "CSE", Age = 23  },
            new Student { ID = 1004, Name = "Anurag", Gender = "Male",
                                        Branch = "CSE", Age = 20  },
            new Student { ID = 1005, Name = "Hina", Gender = "Female",
                                        Branch = "ETC", Age = 20 },
            new Student { ID = 1006, Name = "Priyanka", Gender = "Female",
                                        Branch = "CSE", Age = 25 },
            new Student { ID = 1007, Name = "santosh", Gender = "Male",
                                        Branch = "CSE", Age = 22  },
            new Student { ID = 1008, Name = "Tina", Gender = "Female",
                                        Branch = "CSE", Age = 24  },
            new Student { ID = 1009, Name = "Celina", Gender = "Female",
                                        Branch = "ETC", Age = 22 },
            new Student { ID = 1010, Name = "Sambit", Gender = "Male",
                                        Branch = "ETC", Age = 21 }
        };
                        return students;
        }


      
    }
}
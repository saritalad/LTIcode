using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq; // LinkList
namespace Indexer_Example_Student
{
    class Batch
    {
        
        List<Student> StudentList;

        
        public Batch()
        {
          
            StudentList = new List<Student>();
            StudentList.Add(new Student() { Id = 101, Name="Seema",Gender="Female" });
            StudentList.Add(new Student() { Id = 102, Name = "Satish",Gender="Male" });
            StudentList.Add(new Student() { Id = 103, Name = "Manas",Gender ="Male" });
            StudentList.Add(new Student() { Id = 104, Name = "Ruta", Gender="Female"});
            StudentList.Add(new Student() { Id = 105, Name = "Rupa",Gender="Female" });
        }
        // indexer with get Id and send Name of student

        public string this[int id]
        {
          //  x=>x.value lambda expression 
            get
            {
                return StudentList.FirstOrDefault(x =>x.Id == id).Name;

            }
            set
            {

                StudentList.FirstOrDefault(x => x.Id == id).Name = value;
            }

        }
        public int this[string nm]
        {
            get
            {
                return  StudentList.FirstOrDefault(x => x.Name.ToLower ()  == nm.ToLower()).Id;

            }
            


        }







    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_PartialView_Demo.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Display(Name = "Student Date of Birth")]
        public string StudentDOB { get; set; }

        [Display(Name = "Student Phone Number")]
        public string StudentPhoneNum { get; set; }

        [Display(Name = "Student Address")]
        public string studentAddress { get; set; }
        public virtual Course Course { get; set; }
    }
    public class Course
    {
        public int ID { get; set; }
        public string CourseDescription { get; set; }
        public List<Student> Students { get; set; }
    }
}

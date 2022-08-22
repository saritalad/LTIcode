using Microsoft.AspNetCore.Mvc;
using MYMVC_TagHelper_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_TagHelper_Demo.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();

        public StudentController()
        {
            //listStudents = new List<Student>()
            //{
            //   new Student() { StudentId = 101, Name = "James", Branch = Branch.CSE, Gender = Gender.Male, Address = "A1-2018", Email = "James@g.com" },
            //   new Student() { StudentId = 102, Name = "Priyanka", Branch = Branch.ETC, Gender = Gender.Female, Address = "A1-2019", Email = "Priyanka@g.com" },
            //   new Student() { StudentId = 103, Name = "David", Branch = Branch.CSE, Gender = Gender.Male, Address = "A1-2020", Email = "David@g.com" }
            //};
        }
        //public ViewResult Index()
        //{
        //    return View(listStudents);
        //}
        public ViewResult Details(int Id)
        {
            var studentDetails = listStudents.FirstOrDefault(std => std.StudentId == Id);
            return View(studentDetails);
        }
        public ActionResult Create()
        {
            Student student = new Student
            {
                AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList()
            };
            return View(student);
        }
    }
}

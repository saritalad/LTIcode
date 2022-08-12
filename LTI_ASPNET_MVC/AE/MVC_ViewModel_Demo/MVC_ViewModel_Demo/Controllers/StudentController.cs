using Microsoft.AspNetCore.Mvc;
using MVC_ViewModel_Demo.Models;
using MVC_ViewModel_Demo.Viewmodels;

namespace MVC_ViewModel_Demo.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };
            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };
            //Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student{Id=1,Name="Amita"},
            new Student{Id=2,Name="Swati"},
            new Student {Id=3,Name="Vinod"}
        };

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, students);
        }
        //public HttpResponseMessage Get(int id)
        //{
        //    var stud = students.FirstOrDefault(s => s.Id == id);

        //    if (stud != null)
        //        return Request.CreateResponse(HttpStatusCode.OK, stud);
        //    else

        //        return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found");



        //}
        public IHttpActionResult Get(int id)
        {
            var stud = students.FirstOrDefault(s => s.Id == id);
            if (stud == null)
                return Content(HttpStatusCode.NotFound, "Student not found");
            // return NotFound();  this statement will not show student not found so use content(code, "msg   ")
            else
                return Ok(stud);


        }




    }
}

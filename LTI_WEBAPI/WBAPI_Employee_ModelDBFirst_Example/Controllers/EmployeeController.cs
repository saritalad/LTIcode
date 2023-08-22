using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBAPI_Employee_ModelDBFirst_Example.Models;

namespace WBAPI_Employee_ModelDBFirst_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        public IEnumerable<Employee>Get()
        {// select * from employees
            // da.Fill(ds);
            return _context.Employees.ToList();

        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            // select * from employees where Employeee.Id= id
            var data= _context.Employees.FirstOrDefault(e => e.id == id);
            if (data == null)
                return NotFound();
            else
            return Ok(data);
        }


        [HttpPost]
        public ActionResult Post(Employee newemp)
        {// insert into employees  values ("bill","IT");
           
            _context.Employees.Add(newemp);
            // new row is added in dataset   dt.newrow();
            _context.SaveChanges();
                  //  return Ok();
           return CreatedAtAction("Get", new { id = newemp.id }, newemp);

        }
        [NonAction]// actionverbs get, put, post, delete  ,patch 
        public void CalculateSalary()
        {


        }
       
        //http://localhost:3700/api/Employee/UpdateEmployee/9
        [HttpPut("{id}")]
        [Route("UpdateEmployee/{id}")]
        public ActionResult UpdateEmployee(int id,Employee modifiedemp)
        {
           
            var emp = _context.Employees.FirstOrDefault(emp => emp.id == id);
            // select * from employees where Id= id
            
            if (emp != null)
            {
                // cust.verified=true;
                emp.firstname = modifiedemp.firstname;
                emp.department = modifiedemp.department;
                
                //update customers set verified= true where Id=id;
         // update employees set name=modifiedemp.name,Department=modifiedemp.department where id=id
                _context.SaveChanges();
                  return Ok();
            }
            else
            {
                        return NotFound();

                    }

        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
            {

            var emp = _context.Employees.FirstOrDefault(em => em.id == id);
            if (emp == null)
                return NotFound();
            else
            {
                _context.Employees.Remove(emp);
                    _context.SaveChanges();
                return Ok();
            }

        }

    }
}

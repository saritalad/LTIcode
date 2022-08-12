using Microsoft.AspNetCore.Mvc;
using MVCApp2_EF_DB_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp2_EF_DB_First.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController(CompanyDBContext context)
        {
            _context = context;
        }

        public CompanyDBContext _context { get; }

        public ActionResult Index()
        {
            var employees = _context.employees.ToList();
            return View(employees);
        }

        public ActionResult Details(int? id)
        {
            if (id == null || id < 0)
                return BadRequest();
            var emp = _context.employees.FirstOrDefault(s => s.Id == id);
            if (emp == null)

                return NotFound();
            else
                return View(emp);
        }

        public ActionResult Create()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee newemp)
        {
            try
            {
                if (ModelState.IsValid)

                    _context.employees.Add(newemp);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));


            }
            catch
            {
                return View();
            }

        }

        public ActionResult  Edit(int? id)
        {
            if (id == null || id < 0)
                return BadRequest();
            var emp = _context.employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound();
            else

                return View(emp);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee modifiedemp)
        {
            if (!ModelState.IsValid)
                return View(modifiedemp);
            _context.employees.Update(modifiedemp);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int? id)
        {
            if (id == null || id < 0)
                return BadRequest();
            var student = _context.employees.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();
            _context.employees.Remove(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }




    }
}

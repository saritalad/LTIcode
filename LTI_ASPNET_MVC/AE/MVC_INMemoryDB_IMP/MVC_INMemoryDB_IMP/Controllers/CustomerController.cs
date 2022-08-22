using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Added...
using MVC_INMemoryDB_IMP.Models;
using MVC_INMemoryDB_IMP.INMSERVICES; //In Memory Service
namespace MVC_INMemoryDB_IMP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController1
        public ActionResult Index()
        {
            List<Customer> customers = CustomerService.GetAll();
            int count = customers.Count();
            ViewBag.totalcustomers = count;
            return View(CustomerService.GetAll());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(CustomerService.GetCustomer(id));
        }

        // GET: CustomerController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer NewCustomerObjectPostedByUser)
        {
            try
            {
                CustomerService.Add(NewCustomerObjectPostedByUser);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
      
       
        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(CustomerService.GetCustomer(id));
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer ModifiedCustomerObjectByUser)
        {
            try
            {
                CustomerService.Update(ModifiedCustomerObjectByUser);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(CustomerService.GetCustomer(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                CustomerService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

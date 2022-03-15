using CRUD_EFW.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_EFW.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext DbContext;
        public CustomerController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public IActionResult Index()
        {
            List<Customer> Cust = DbContext.Customers.ToList();
            return View(Cust);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer cust)
        {
            if (ModelState.IsValid)
            {
                DbContext.Customers.Add(cust);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(cust);
            }
        }
        public IActionResult Delete(int id)
        {
            var cust = DbContext.Customers.SingleOrDefault(e => e.Id == id);
            if (cust != null)
            {
                DbContext.Customers.Remove(cust);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
       
        public IActionResult Edit(int id)
        {
            var cust = DbContext.Customers.SingleOrDefault(e => e.Id == id);
            return View(cust);
        }
        [HttpPost]
        public IActionResult Edit(Customer cust)
        {
            DbContext.Customers.Update(cust);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

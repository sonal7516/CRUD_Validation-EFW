using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_EFW.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_EFW.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext DbContext;
        public EmployeeController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public IActionResult Index()
        {
            List<Department> departments = DbContext.Departments.ToList();
            return View(departments);
        }
        public IActionResult EmployeeList(int Id)
        {
            List<Employee> Employees = DbContext.employees.Where(e => e.Department.Id==Id).ToList();
            return View(Employees);
        }
        
    }
}

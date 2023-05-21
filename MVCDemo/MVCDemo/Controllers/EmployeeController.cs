using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;


namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Home
        public ActionResult Index(int departmentID)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List <Employee>  employee = employeeContext.Employees.Where(emp=>emp.DepartmentID== departmentID).ToList();
            return View(employee);


             
        }   
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp=> emp.EmployeeID == id);
            return View(employee);  

            

        }
    }
}
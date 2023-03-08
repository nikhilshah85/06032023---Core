using Microsoft.AspNetCore.Mvc;
using MVCEmployeeManagement.Models;

namespace MVCEmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {

        EmployeeModel eObj = new EmployeeModel(); //this is old way, not recommeneded, use Dependency Injection instead


        public IActionResult EmployeeList()
        {
            ViewBag.employees = eObj.GetAllEmployees();
            return View();
        }

        //this will give the page with text box and button
        public IActionResult SearchEmployee()
        {
            ViewBag.isEmpSeach = false;
            ViewBag.errMessage = "";
            return View();
        }

        [HttpPost]
        public IActionResult SearchEmployee(int employeeNo)
        {
            try
            {
                ViewBag.employee = eObj.SearchById(employeeNo);
                ViewBag.isEmpSeach = true;
                ViewBag.errMessage = "";
            }
            catch (Exception ex)
            {
                ViewBag.isEmpSeach = false;
                ViewBag.errMessage = ex.Message;                
            }
            return View();
        }

        [HttpGet] // this is anyways by default, so if u do not mention this, things will still work
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost] //this is mandatory
        public IActionResult AddEmployee(EmployeeModel newEmp)
        {
            ViewBag.addResult = eObj.AddEmployee(newEmp);
            // return View();
          return  RedirectToAction("EmployeeList");
        }


        public IActionResult FilterByDesigantion()
        {
            ViewBag.filtered = false;
            return View();
        }

        [HttpPost]
        public IActionResult FilterByDesigantion(string edesignation)
        {
            var employees = eObj.FilterByDesignation(edesignation);
            ViewBag.filtered = true;
            return View();
        }

    }
}










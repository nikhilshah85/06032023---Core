using Microsoft.AspNetCore.Mvc;
using DI_Demo.Models;
namespace DI_Demo.Controllers
{
    public class EmployeeController : Controller
    {

        //this is not expected, use DI instead
        //Employee empObj = new Employee();

        Employee empObj;

                                 //framework will inject the reference of object created 
        public EmployeeController(Employee empObjREF)
        {
            empObj = empObjREF;
        }


        public IActionResult DisplayEmployee()
        {
            ViewBag.empList = empObj.GetAllEmployees(); //to execute the method u need object
            return View();
        }



    }
}

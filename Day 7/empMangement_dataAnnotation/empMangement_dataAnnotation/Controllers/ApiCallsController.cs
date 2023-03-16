using Microsoft.AspNetCore.Mvc;

namespace empMangement_dataAnnotation.Controllers
{
    public class ApiCallsController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}

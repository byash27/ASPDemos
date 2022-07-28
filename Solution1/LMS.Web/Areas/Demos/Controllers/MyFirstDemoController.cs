using Microsoft.AspNetCore.Mvc;

namespace LMS.Web.Areas.Demos.Controllers
{
    public class MyFirstDemoController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}

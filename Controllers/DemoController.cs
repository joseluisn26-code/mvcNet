using Microsoft.AspNetCore.Mvc;

namespace Mvcproducto.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello from the controller Demo!";
            return View();
        }
    }
}
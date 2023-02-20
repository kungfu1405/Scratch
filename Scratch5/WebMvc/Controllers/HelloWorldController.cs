using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

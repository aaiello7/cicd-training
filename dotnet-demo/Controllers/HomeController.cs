using Microsoft.AspNetCore.Mvc;

namespace DotnetDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("<html><body><h1>Welcome to the CI/CD training course</h1></body></html>", "text/html");
        }
    }
}

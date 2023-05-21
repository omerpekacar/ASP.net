using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class departController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

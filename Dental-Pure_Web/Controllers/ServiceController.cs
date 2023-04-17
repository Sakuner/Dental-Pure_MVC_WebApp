using Microsoft.AspNetCore.Mvc;

namespace Dental_Pure_Web.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

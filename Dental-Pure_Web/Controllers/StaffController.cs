using Dental_Pure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Dental_Pure_Web.Controllers
{
    public class StaffController : Controller
    {
        private readonly AppDbContext _db;
        public StaffController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

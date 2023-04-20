using Dental_Pure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Dental_Pure_Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly AppDbContext _db;
        public ReservationController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

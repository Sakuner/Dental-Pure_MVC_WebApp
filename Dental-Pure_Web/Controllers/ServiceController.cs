using Dental_Pure.DataAccess;
using Dental_Pure.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dental_Pure_Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _db;
        public ServiceController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ServiceModel> objServiceList = _db.Services.ToList();
            return View(objServiceList);
        }
    }
}

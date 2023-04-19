using Dental_Pure.DataAccess;
using Dental_Pure.Entities;
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

        //TODO - improve UI for staff photos
        public IActionResult Index()
        {

            List<StaffModel> objStaffList = _db.StaffEmployee.ToList();
            return View(objStaffList);
        }
    }
}

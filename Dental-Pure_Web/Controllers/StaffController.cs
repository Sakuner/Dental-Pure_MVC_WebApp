using Dental_Pure.DataAccess;
using Dental_Pure.Domain.Repository.IRepository;
using Dental_Pure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dental_Pure_Web.Controllers
{
    public class StaffController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        public StaffController(AppDbContext db, IUnitOfWork unitOfWork)
        {
            _db = db;
            _unitOfWork = unitOfWork;
        }

        //TODO - improve UI for staff photos
        [HttpGet]
        public IActionResult Index()
        {

            List<StaffModel> objStaffList = _db.StaffEmployee.ToList();
            return View(objStaffList);
        }


        [Authorize(Roles = rolesUtility.Role_Admin)]
        [HttpGet]
        public IActionResult ModifyStaff()
        {
            //TODO
            TempData["success"] = "Staff member added successfully";
            return View();
        }
    }
}

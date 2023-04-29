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
        private readonly IWebHostEnvironment _hostEnvironment;
        public StaffController(AppDbContext db, IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _db = db;
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

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
            var StaffList = _unitOfWork.Staff.GetAll();
            return View(StaffList);
            
            
        }

        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStaff(StaffModel obj, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(wwwRootPath, @"images\staff");
                var extension = Path.GetExtension(file.FileName);

                using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    file.CopyTo(fileStreams);
                }
                obj.PhotoUrl = @"\images\staff\" + fileName + extension;

                _unitOfWork.Staff.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Staff member added successfully!";
                return RedirectToAction("ModifyStaff");
            }
            
            return View(obj);
        }
        public IActionResult DeleteStaff(int? id)
        {
            var obj = _unitOfWork.Staff.GetFirstOrDefault(u => u.Id == id);
            _unitOfWork.Staff.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Removing successfull";
            return RedirectToAction("ModifyStaff");
        }
    }
}

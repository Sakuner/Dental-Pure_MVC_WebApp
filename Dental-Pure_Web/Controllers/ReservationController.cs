﻿using Dental_Pure.DataAccess;
using Dental_Pure.Domain.Repository.IRepository;
using Dental_Pure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dental_Pure_Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        public ReservationController(AppDbContext db, IUnitOfWork unitOfWork)
        {
            _db = db;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index(int? id)
        {
            var vm = new ReservationVM();
            vm.StaffList = _unitOfWork.Staff.GetAll().Select(i => new SelectListItem { Text = i.Name,
            Value=i.Id.ToString()});
            return View(vm);
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ReservationVM obj, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Reservation.Add(obj.Reservation);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            //TODO implement button "remind me", add date validation
            return View(obj);
        }
    }
}

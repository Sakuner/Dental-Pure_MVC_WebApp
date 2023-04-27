﻿using Dental_Pure.DataAccess;
using Dental_Pure.Domain.Repository.IRepository;
using Dental_Pure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dental_Pure_Web.Controllers
{
    //[Authorize]
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


        [Authorize(Roles = rolesUtility.Role_Admin + "," + rolesUtility.Role_Employee)]
        [HttpGet]
        public IActionResult BookingList()
        {
            //List<ReservationModel> reservationList = _db.Reservations.ToList();
            var reservationList =  _unitOfWork.Reservation.GetAll(includeProperties:"AssignedDoctor");
            return View(reservationList);
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ReservationVM obj, IFormFile? file)
        {
            //validation to avoid situation where 2 people have a reservation for the same time with the same staff member
            var reservationFromDb = _unitOfWork.Reservation.GetFirstOrDefault(u => u.ReservationDate == obj.Reservation.ReservationDate);
            if (reservationFromDb != null)
            {
                if (obj.Reservation.AssignedDoctorId == reservationFromDb.AssignedDoctorId)
                {
                    ModelState.AddModelError("Reservation.ReservationDate", "You can't choose this date for this doctor");
                }
            }
            
            if (ModelState.IsValid)
            {
                _unitOfWork.Reservation.Add(obj.Reservation);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            //TODO implement visual validation for user side 
            return View(obj);
        }
    }
}

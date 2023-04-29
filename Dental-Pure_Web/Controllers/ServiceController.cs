using Dental_Pure.DataAccess;
using Dental_Pure.Domain.Repository.IRepository;
using Dental_Pure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dental_Pure_Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        public ServiceController(AppDbContext db, IUnitOfWork unitOfWork)
        {
            _db = db;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<ServiceModel> objServiceList = _unitOfWork.Service.GetAll().ToList();
            return View(objServiceList);
        }

        [Authorize(Roles = rolesUtility.Role_Admin)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ModifyPricing(int? id, string? price)
        {
            var ServiceFromDb = _unitOfWork.Service.GetFirstOrDefault(u => u.Id == id);
            ServiceFromDb.Price = Convert.ToDouble(price);
            _unitOfWork.Service.Update(ServiceFromDb);
            _unitOfWork.Save();
            TempData["success"] = "Price change successfull";
            return RedirectToAction("Index");
        }
    }
}

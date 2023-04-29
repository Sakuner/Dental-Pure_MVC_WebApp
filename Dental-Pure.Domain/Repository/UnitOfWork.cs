using Dental_Pure.DataAccess;
using Dental_Pure.Domain.Repository.IRepository;

namespace Dental_Pure.Domain.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Reservation = new ReservationRepository(_db);
            Staff = new StaffRepository(_db);
            Service = new ServiceRepository(_db);
        }
        public IStaffRepository Staff { get; private set; }

        public IReservationRepository Reservation { get; private set; }
        public IServiceRepository Service { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
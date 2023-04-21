using Dental_Pure.DataAccess;
using Dental_Pure.Domain.Repository.IRepository;
using Dental_Pure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Pure.Domain.Repository
{
    public class ReservationRepository : Repository<ReservationModel>, IReservationRepository 
    {
        private AppDbContext _db;
        public ReservationRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}

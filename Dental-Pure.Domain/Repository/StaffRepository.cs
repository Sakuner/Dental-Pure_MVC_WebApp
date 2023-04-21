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
    public class StaffRepository : Repository<StaffModel>, IStaffRepository
    {
        private AppDbContext _db;
        public StaffRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}

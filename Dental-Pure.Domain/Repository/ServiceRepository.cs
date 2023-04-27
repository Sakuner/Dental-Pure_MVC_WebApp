using Dental_Pure.DataAccess;
using Dental_Pure.Domain.Repository.IRepository;
using Dental_Pure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Pure.Domain.Repository
{
    public class ServiceRepository : Repository<ServiceModel>, IServiceRepository
    {
        private AppDbContext _db;
        public ServiceRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}

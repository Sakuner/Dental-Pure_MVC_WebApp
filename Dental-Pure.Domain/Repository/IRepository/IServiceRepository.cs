﻿using Dental_Pure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Pure.Domain.Repository.IRepository
{
    public interface IServiceRepository : IRepository<ServiceModel>
    {
        void Update(ServiceModel service);
    }
}

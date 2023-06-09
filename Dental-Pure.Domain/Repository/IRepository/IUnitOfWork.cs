﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Pure.Domain.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IStaffRepository Staff { get; }
        IReservationRepository Reservation { get; }
        IServiceRepository Service { get; }
        void Save();
    }
}

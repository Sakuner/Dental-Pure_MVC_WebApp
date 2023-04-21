using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Pure.Entities
{
    public class ReservationVM
    {
        public ReservationModel Reservation { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> StaffList { get; set; }
    }
}

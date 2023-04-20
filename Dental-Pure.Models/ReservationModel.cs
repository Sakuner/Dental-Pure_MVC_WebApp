﻿using System.ComponentModel.DataAnnotations;

namespace Dental_Pure.Entities
{
    public class ReservationModel
    {
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public StaffModel AssignedDoctor { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}

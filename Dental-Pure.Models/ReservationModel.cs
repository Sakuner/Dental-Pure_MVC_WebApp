using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        // TODO   test it properly 
        [DisplayName("Assigned doctor")]
        [Required]
        public int AssignedDoctorId { get; set; }
        [ValidateNever]
        public StaffModel AssignedDoctor { get; set; }
        [Required]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
    }
}

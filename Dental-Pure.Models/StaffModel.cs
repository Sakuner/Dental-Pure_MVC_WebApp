using System.ComponentModel.DataAnnotations;

namespace Dental_Pure.Entities
{
    public class StaffModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string PhotoUrl { get; set; }
    }
}

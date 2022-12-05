using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name="Number of Days")]
        [Required]
        [Range(1,50, ErrorMessage = "Invalid Number")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation Period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}
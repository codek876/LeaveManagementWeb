using LeaveManagementNet6.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementNet6.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Display(Name = "Start Date")]
        [Required]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Leave Name")]
        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes  { get; set; }

        [Display(Name = "Request Comments")]
        public string? RequestedComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date must be before the End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }

            if (RequestedComments?.Length > 250)
            {
                yield return new ValidationResult("Comments are too long", new[] { nameof(RequestedComments) });
            }
        }
    }
}

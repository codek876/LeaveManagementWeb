using LeaveManagementNet6.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementNet6.Data
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; } 
        public string? RequestedComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string RequestedEmployeeId  { get; set; }
    }
}

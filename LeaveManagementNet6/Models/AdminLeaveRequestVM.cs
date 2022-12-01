using LeaveManagementNet6.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementNet6.Models
{
    public class AdminLeaveRequestVM
    {
        [Display(Name = "Nunber of Request")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Request")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Request")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Request")]
        public int RejectedRequests { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}

using LeaveManagementNet6.Data;

namespace LeaveManagementNet6.Models
{
    public class EmployeeLeaveRequestVM
    {
        public EmployeeLeaveRequestVM(List<LeaveAllocationVM> leaveAllocations, List<LeaveRequestVM> leaveRequests)
        {
            LeaveAllocations = leaveAllocations;
            LeaveRequests = leaveRequests;
        }

        public List<LeaveAllocationVM> LeaveAllocations;

        public List<LeaveRequestVM> LeaveRequests;
    }
}

namespace LeaveManagement.Common.Models
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

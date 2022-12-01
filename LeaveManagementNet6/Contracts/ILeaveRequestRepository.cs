using LeaveManagementNet6.Data;
using LeaveManagementNet6.Models;
using Microsoft.CodeAnalysis;

namespace LeaveManagementNet6.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelLeaveRequest(int leaveRequestId);
        Task<AdminLeaveRequestVM> GetAdminLeaveRequestList();
    }
}

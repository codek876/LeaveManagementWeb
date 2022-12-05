using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using Microsoft.CodeAnalysis;

namespace LeaveManagement.BusinessLogic.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequestVM>> GetAllAsync(string employeeId);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelLeaveRequest(int leaveRequestId);
        Task<AdminLeaveRequestVM> GetAdminLeaveRequestList();
    }
}

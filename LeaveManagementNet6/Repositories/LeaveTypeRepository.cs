using LeaveManagementNet6.Contracts;
using LeaveManagementNet6.Data;

namespace LeaveManagementNet6.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

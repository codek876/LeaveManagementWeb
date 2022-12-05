using LeaveManagement.BusinessLogic.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.BusinessLogic.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

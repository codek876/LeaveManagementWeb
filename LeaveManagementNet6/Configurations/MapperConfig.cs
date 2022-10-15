using AutoMapper;
using LeaveManagementNet6.Data;
using LeaveManagementNet6.Models;

namespace LeaveManagementNet6.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}

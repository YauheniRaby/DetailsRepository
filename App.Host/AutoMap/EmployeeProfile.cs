using AppData.Model;
using AppServices.DTOs;
using AutoMapper;

namespace AppHost.AutoMap
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, ShortEmployeeDTO>().ReverseMap();
            CreateMap<FullEmployeeDTO, Employee>()
                .ForMember(dest => dest.Details, opt => opt.Ignore())
                .ForMember(dest => dest.IsRemove, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<EmployeeWithCountDetails, EmployeeWithCountDetailsDTO>();           
        }
    }
}
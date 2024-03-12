using AccountManagementWebApp.EntityLayer.Concrete;
using AccountManagementWebApp.WebUI.DTOs.AccountDTO;
using AccountManagementWebApp.WebUI.DTOs.EmployeeDTO;
using AutoMapper;

namespace AccountManagementWebApp.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultEmployeeDTO, Employee>().ReverseMap();
            CreateMap<UpdateEmployeeDTO, Employee>().ReverseMap();
            CreateMap<CreateEmployeeDTO, Employee>().ReverseMap();

            CreateMap<RegisterUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();
        }
    }
}

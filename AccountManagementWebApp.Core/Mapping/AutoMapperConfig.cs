using AccountManagementWebApp.Core.DTOs.EmployeeDTO;
using AccountManagementWebApp.EntityLayer.Concrete;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementWebApp.Core.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<EmployeeResultDTO, Employee>().ReverseMap();
            CreateMap<EmployeeAddDTO, Employee>().ReverseMap();
            CreateMap<EmployeeUpdateDTO, Employee>().ReverseMap();
        }
    }
}

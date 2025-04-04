﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Demo.BusinessLogic.DataTransferObject.EmployeeDtos;
using Demo.DataAccess.Models.EmployeeModel;

namespace Demo.BusinessLogic.Profiles
{
    public class MappingProfiles:Profile
    {
       public MappingProfiles() 
        {

            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.EmpGender, Options => Options.MapFrom(src => src.Gender))
                .ForMember(dest => dest.EmpType, Options => Options.MapFrom(src => src.EmployeeType));
            CreateMap<Employee, EmploeeDetailsDto>()
                 .ForMember(dest => dest.Gender, Options => Options.MapFrom(src => src.Gender))
                .ForMember(dest => dest.EmployeeType, Options => Options.MapFrom(src => src.EmployeeType))
                 .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => DateOnly.FromDateTime(src.HiringDate)));
            CreateMap<CreatedEmployeeDto, Employee>()
                 .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => src.HiringDate.ToDateTime(TimeOnly.MinValue)));
            CreateMap<UpdatedEmployeeDto, Employee>()
                 .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => src.HiringDate.ToDateTime(TimeOnly.MinValue)));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Azure;
using Demo.BusinessLogic.DataTransferObject.EmployeeDtos;
using Demo.BusinessLogic.Services.Interfaces;
using Demo.DataAccess.Models.EmployeeModel;
using Demo.DataAccess.Models.Shared.Enums;
using Demo.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo.BusinessLogic.Services.Classes
{
    public class EmployeeService(IEmployeeRepository _employeeRepository,IMapper _mapper) : IEmployeeServices
    {
        public int CreatedEmployee(CreatedEmployeeDto employeeDto)
        {
            var employee=_mapper.Map<CreatedEmployeeDto,Employee>(employeeDto);
            return _employeeRepository.Add(employee);
        }

        public bool DeleteEmployee(int id)
        {
            var employee=_employeeRepository.GetById(id);
            if(employee is null) return false;
            else
            {
                employee.IsDeleted = true;
                return _employeeRepository.Update(employee) >0?true:false;
            }
          
        }

        public IEnumerable<EmployeeDto> GetAllEmployees(bool WithTracking)
        {
            var Employees=_employeeRepository.GetAll(WithTracking);
            var employeesDto = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(Employees);
            return employeesDto;
        }

        public EmploeeDetailsDto? GetEmploeebyId(int id)
        {
            var employee=_employeeRepository.GetById(id);
           return employee is null?null : _mapper.Map<Employee,EmploeeDetailsDto>(employee);


        }

        public int UpdateEmployee(UpdatedEmployeeDto employeeDto)
        {
           return _employeeRepository.Update(_mapper.Map<UpdatedEmployeeDto, Employee>(employeeDto));
        }
    }
}

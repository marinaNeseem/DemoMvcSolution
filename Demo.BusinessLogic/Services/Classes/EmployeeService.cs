using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Demo.BusinessLogic.DataTransferObject.EmployeeDtos;
using Demo.BusinessLogic.Services.Interfaces;
using Demo.DataAccess.Models.EmployeeModel;
using Demo.DataAccess.Models.Shared.Enums;
using Demo.DataAccess.Repositories.Interfaces;

namespace Demo.BusinessLogic.Services.Classes
{
    public class EmployeeService(IEmployeeRepository _employeeRepository) : IEmployeeServices
    {
        public int CreatedEmployee(CreatedEmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetAllEmployees(bool WithTracking)
        {
            var Employee=_employeeRepository.GetAll(WithTracking);
            var employeeDto = Employee.Select(Emp => new EmployeeDto()
            {
                Id=Emp.Id,
                Name=Emp.Name,
                Age=Emp.Age,
                Email=Emp.Email,
                IsActive=Emp.IsActive,
                Salary=Emp.Salary,
                EmployeeType=Emp.EmployeeType.ToString(),
                Gender=Emp.Gender.ToString(),

            });
            return employeeDto;
        }

        public EmploeeDetailsDto? GetEmploeebyId(int id)
        {
            var employee=_employeeRepository.GetById(id);
           return employee is null?null : new EmploeeDetailsDto()
           {
               Id = employee.Id,
               Name = employee.Name,
               Age = employee.Age,
               Email = employee.Email,
               IsActive = employee.IsActive,
               Salary = employee.Salary,
               EmployeeType = employee.EmployeeType.ToString(),
               Gender = employee.Gender.ToString(),
               Address = employee.Address,
               HiringDate = DateOnly.FromDateTime(employee.HiringDate),
               PhoneNumber = employee.PhoneNumber,
               CreatedBy = 1,
               CreatedOn = employee.CreatedOn,
               LastModifiedBy = 1,
               LastModifiedOn = employee.LastModifaiedOn,

           };


        }

        public int UpdateEmployee(UpdatedEmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }
    }
}

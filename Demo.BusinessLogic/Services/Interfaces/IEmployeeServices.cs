using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BusinessLogic.DataTransferObject.EmployeeDtos;

namespace Demo.BusinessLogic.Services.Interfaces
{
    public interface IEmployeeServices
    {
        IEnumerable<EmployeeDto> GetAllEmployees(bool WithTracking=false);
        EmploeeDetailsDto ?GetEmploeebyId(int id);
        int  CreatedEmployee(CreatedEmployeeDto employeeDto);
        int UpdateEmployee(UpdatedEmployeeDto employeeDto);
        bool DeleteEmployee(int id);
    }
}

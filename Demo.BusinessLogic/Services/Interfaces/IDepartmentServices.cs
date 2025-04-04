using Demo.BusinessLogic.DataTransferObject.DepartmentDto;

namespace Demo.BusinessLogic.Services.Interfaces
{
    public interface IDepartmentServices
    {
        int AddDepartment(CreatedDepartmentDto departmentDto);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetialsDto? GetDepartmentById(int id);
        int UpdatedDepartment(UpdatedDepartmentDto departmentDto);
    }
}
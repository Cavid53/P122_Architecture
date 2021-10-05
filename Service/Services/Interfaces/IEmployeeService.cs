using Service.DTOs;
using System.Collections.Generic;

namespace Service.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetAllEmployees();
        EmployeeDTO GetEmployeeById(int id);
    }
}

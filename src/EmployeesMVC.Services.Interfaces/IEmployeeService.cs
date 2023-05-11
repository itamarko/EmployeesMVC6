using EmployeesMVC.DataModel;
using EmployeesMVC.DataModel.Employee;

namespace EmployeesMVC.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<CommandResponse<IEnumerable<Employee>>> GetEmployees();
    }
}
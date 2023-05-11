using AutoMapper;
using EmployeesMVC.Services.Interfaces;
using EmployeesMVC6.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMVC6.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var employeesResponse = await _employeeService.GetEmployees();
            if (employeesResponse.Status != "success")
            {
                return NotFound();
            }

            IEnumerable<EmployeeViewModel> employees = _mapper.Map<IEnumerable<EmployeeViewModel>>(employeesResponse.Data);
            return View(employees);
        }
    }
}

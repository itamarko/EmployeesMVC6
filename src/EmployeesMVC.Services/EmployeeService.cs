using EmployeesMVC.DataModel;
using EmployeesMVC.DataModel.Employee;
using EmployeesMVC.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace EmployeesMVC.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _employeeRestService;

        public EmployeeService(IConfiguration configuration)
        {
            _config = configuration;
            _employeeRestService = new HttpClient();
            string url = _config.GetSection("ExternalServices").GetSection("EmployeeAPI").Value;
            _employeeRestService.BaseAddress = new Uri(url);
        }
        public async Task<CommandResponse<IEnumerable<Employee>>> GetEmployees()
        {
            var result = new CommandResponse<IEnumerable<Employee>>();

            try
            {
                var response = await _employeeRestService.GetAsync("employees");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<CommandResponse<IEnumerable<Employee>>>(content);
                }
            }
            catch(Exception ex)
            {
                result.Status = "Error";
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
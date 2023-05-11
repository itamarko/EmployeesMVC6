using AutoMapper;
using EmployeesMVC.DataModel.Employee;

namespace EmployeesMVC6.Models.Mapper
{
    public class Model2ViewModel : Profile
    {
        public Model2ViewModel()
        {
            this.CreateMap<Employee, EmployeeViewModel>()
                .ForMember(e => e.Name, evm => evm.MapFrom(c => c.Employee_name))
                .ForMember(e => e.ProfileImage, evm => evm.MapFrom(c => c.Profile_image))
                .ForMember(e => e.Salary, evm => evm.MapFrom(c => c.Employee_salary))
                .ForMember(e => e.Age, evm => evm.MapFrom(c => c.Employee_age));
        }
    }
}

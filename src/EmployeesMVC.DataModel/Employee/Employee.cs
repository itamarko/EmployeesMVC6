using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesMVC.DataModel.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Employee_name { get; set; }
        public decimal Employee_salary { get; set; }
        public int Employee_age { get; set; }
        public string Profile_image { get; set; }
    }
}

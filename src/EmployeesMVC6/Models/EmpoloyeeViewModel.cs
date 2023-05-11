namespace EmployeesMVC6.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public int YearOfBirth { get { return DateTime.Now.Year - Age; } }
        public string ProfileImage { get; set; }
    }
}

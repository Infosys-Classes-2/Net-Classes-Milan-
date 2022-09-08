namespace Hrm.Web.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime JoinDate { get; set; }
        public int Level { get; set; }
        // 1 employee have 1 Department, 1 Department will have many Employees
        public string Department { get; set; }

        // 1 employee has Only one Designation, One Designation can be of Many Employees
        public string Designation { get; set; } 
    }
}

using LeaveManagement.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.DataAccessLayer
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfJoining { get; set; }        
        public string Designation { get; set; }
        public int? PriorExperience { get; set; }
        public string Email { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public int CountryId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public Country Country { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public ICollection<EmployeeEducation> EmployeeEducations { get; set; }
        

    }
}

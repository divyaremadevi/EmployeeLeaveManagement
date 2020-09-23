using System.Collections.Generic;

namespace LeaveManagement.DataAccessLayer.Entities
{
    public class EducationType
    {
        public int EduId { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeeEducation> EmployeeEducations { get; set; }
    }
}

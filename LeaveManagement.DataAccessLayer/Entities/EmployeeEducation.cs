using System;

namespace LeaveManagement.DataAccessLayer.Entities
{
    public class EmployeeEducation
    {
        public int EmpEduId { get; set; }
        public int EmpId { get; set; }
        public int EducationTypeId { get; set; }
        public string Institution { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Employee Employee { get; set; }
        public EducationType EducationType { get; set; }
    }
}

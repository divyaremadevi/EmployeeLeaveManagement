using LeaveManagement.DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagement.DataAccessLayer.Seed
{
    public static class EducationTypeSeed
    {
        public static void Seed(EmployeeDbContext context)
        {
            if (!context.EducationTypes.Any())
            {
                var educationTypes = new List<EducationType>
                {
                    new EducationType{Name = "Secondary (10th)"},
                    new EducationType{Name = "Higher Secondary"},
                    new EducationType{Name = "Degree"},
                    new EducationType{Name = "Diploma" },
                    new EducationType{Name = "Post Graduation" },
                    new EducationType{Name = "Certification Courses" }
                };
                context.EducationTypes.AddRange(educationTypes);
                context.SaveChanges();
            }
        }
    }
}

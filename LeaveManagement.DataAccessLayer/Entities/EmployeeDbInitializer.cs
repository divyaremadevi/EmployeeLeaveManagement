using LeaveManagement.DataAccessLayer.Seed;
using System.Data.Entity;

namespace LeaveManagement.DataAccessLayer.Entities
{
    public class EmployeeDbInitializer : CreateDatabaseIfNotExists<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            CountrySeed.Seed(context);
            base.Seed(context);
        }
    }
}

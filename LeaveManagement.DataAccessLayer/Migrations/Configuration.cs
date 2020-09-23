namespace LeaveManagement.DataAccessLayer.Migrations
{
    using LeaveManagement.DataAccessLayer.Seed;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LeaveManagement.DataAccessLayer.Entities.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LeaveManagement.DataAccessLayer.Entities.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            CountrySeed.Seed(context);
            EducationTypeSeed.Seed(context);
        }
    }
}

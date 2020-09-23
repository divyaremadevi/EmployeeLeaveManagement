using LeaveManagement.DataAccessLayer.Entities.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace LeaveManagement.DataAccessLayer.Entities
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("name=EmployeeDbConnectionString")
        {
            Database.SetInitializer<EmployeeDbContext>(new CreateDatabaseIfNotExists<EmployeeDbContext>());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfig());
            modelBuilder.Configurations.Add(new CountryConfig());
            modelBuilder.Configurations.Add(new EducationTypeConfig());
            modelBuilder.Configurations.Add(new EmployeeEducationConfig());
            modelBuilder.Configurations.Add(new ProjectConfig());
            modelBuilder.Configurations.Add(new EmployeeProjectConfig());
        }
    }
}

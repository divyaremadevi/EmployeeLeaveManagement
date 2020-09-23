using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.DataAccessLayer.Entities.EntityConfig
{
    public class EmployeeProjectConfig : EntityTypeConfiguration<EmployeeProject>
    {
        public EmployeeProjectConfig() : base()
        {
            this.ToTable("EmployeeProject");

            // Primary Key
            this.HasKey<int>(ep => ep.EmpProId);

            // Properties
            this.Property(ep => ep.EmpProId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Relationships                  
            this.HasRequired(ep => ep.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(ep => ep.EmpId);

            this.HasRequired(ep => ep.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(ep => ep.ProjectId);
        }
    }
}

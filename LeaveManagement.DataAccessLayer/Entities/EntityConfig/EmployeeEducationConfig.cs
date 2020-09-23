using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.DataAccessLayer.Entities.EntityConfig
{
    public class EmployeeEducationConfig : EntityTypeConfiguration<EmployeeEducation>
    {
        public EmployeeEducationConfig() : base()
        {
            this.ToTable("EmployeeEducation");

            // Primary Key
            this.HasKey<int>(ee => ee.EmpEduId);

            // Properties
            this.Property(ee => ee.EmpEduId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(ee => ee.Institution)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            this.Property(ee => ee.FromDate)
                .HasColumnType("date");

            this.Property(ee => ee.ToDate)
                .HasColumnType("date");


            // Relationships                  
            this.HasRequired(ee => ee.Employee)
                .WithMany(e => e.EmployeeEducations)
                .HasForeignKey(ee => ee.EmpId);

            this.HasRequired(ee => ee.EducationType)
                .WithMany(c => c.EmployeeEducations)
                .HasForeignKey(ee => ee.EducationTypeId);
        }
    }
}

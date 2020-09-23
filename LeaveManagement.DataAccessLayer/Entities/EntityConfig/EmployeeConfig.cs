using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.DataAccessLayer.Entities.EntityConfig
{
    public class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig() : base()
        {
            this.ToTable("Employee");

            // Primary Key
            this.HasKey<int>(e => e.EmployeeId);

            // Properties
            this.Property(e => e.EmployeeId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            this.Property(e => e.LastName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            this.Property(e => e.DateOfJoining)
                .HasColumnType("date");
            this.Property(e => e.Designation)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            this.Property(e => e.PriorExperience);
            this.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            this.Property(e => e.CurrentAddress)
                .HasColumnType("nvarchar")
                .HasMaxLength(250);
            this.Property(e => e.PermanentAddress)
                .HasColumnType("nvarchar")
                .HasMaxLength(250);
            this.Property(e => e.DateOfBirth)
                .HasColumnName("DOB")
                .HasColumnType("date");
            this.Property(e => e.Gender)
                .HasColumnType("nvarchar")
                .HasMaxLength(25);
            this.Property(e => e.MaritalStatus)
                .HasColumnType("nvarchar")
                .HasMaxLength(25);

            // Relationships
            this.HasRequired(e => e.Country)
                .WithMany(c => c.Employees)
                .HasForeignKey(e => e.CountryId);
        }
    }
}

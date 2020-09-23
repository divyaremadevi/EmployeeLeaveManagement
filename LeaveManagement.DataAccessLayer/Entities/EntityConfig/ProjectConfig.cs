using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.DataAccessLayer.Entities.EntityConfig
{
    public class ProjectConfig : EntityTypeConfiguration<Project>
    {
        public ProjectConfig() : base()
        {
            this.ToTable("Project");

            // Primary Key
            this.HasKey<int>(p => p.ProjectId);

            // Properties
            this.Property(p => p.ProjectId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.ProjectName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            this.Property(p => p.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(250);
        }
    }
}

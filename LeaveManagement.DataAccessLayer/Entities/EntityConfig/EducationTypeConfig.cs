using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.DataAccessLayer.Entities.EntityConfig
{
    public class EducationTypeConfig : EntityTypeConfiguration<EducationType>
    {
        public EducationTypeConfig() : base()
        {
            this.ToTable("EducationType");

            // Primary Key
            this.HasKey<int>(c => c.EduId);

            // Properties
            this.Property(c => c.EduId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
        }
    }

}

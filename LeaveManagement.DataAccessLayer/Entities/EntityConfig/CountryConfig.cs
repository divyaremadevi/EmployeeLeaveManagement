using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LeaveManagement.DataAccessLayer.Entities.EntityConfig
{
    public class CountryConfig : EntityTypeConfiguration<Country>
    {
        public CountryConfig():base()
        {
            this.ToTable("Country");

            // Primary Key
            this.HasKey<int>(c => c.CountryId);

            // Properties
            this.Property(c => c.CountryId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.CountryName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
        }
    }
}

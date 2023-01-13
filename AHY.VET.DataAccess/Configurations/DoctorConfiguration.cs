using AHY.VET.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AHY.VET.DataAccess.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);


            //builder.Property(x => x.Surname).HasColumnName("Soyadı");
            builder.Property(x=>x.Surname).IsRequired(false);


            builder.HasOne(x => x.Branch).WithMany(x => x.Doctors).HasForeignKey(x => x.BranchId);
        }
    }
}

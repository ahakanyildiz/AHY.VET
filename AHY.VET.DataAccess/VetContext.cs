using AHY.VET.DataAccess.Configurations;
using AHY.VET.Entities;
using Microsoft.EntityFrameworkCore;

namespace AHY.VET.DataAccess
{
    public class VetContext : DbContext
    {
        public VetContext(DbContextOptions<VetContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BranchConfiguration());
            builder.ApplyConfiguration(new DoctorConfiguration());
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Doctor> Doctors { get; set; } // Entityler Tekil - Veritabanındaki Tablolar Çoğul
    }
}

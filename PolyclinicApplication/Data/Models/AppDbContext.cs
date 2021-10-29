using Microsoft.EntityFrameworkCore;

namespace PolyclinicApplication.Data.Models
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<MedicalInsurance> MedicalInsurances { get; set; }

        public DbSet<MedicineCard> MedicineCards { get; set; }

        public DbSet<Passport> Passports { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Reception> Receptions { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Specialization> Specializations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB; Database=PolyclinicDB; Trusted_Connection=True");
        }
    }
}

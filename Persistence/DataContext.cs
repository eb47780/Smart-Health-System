using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public partial class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Vitals> Vitals {get; set;}

        public DbSet<Appointments> Appointments { get; set;}
        public DbSet<Allergy> Allergies { get; set;}
        public DbSet<WaterIntake> WaterIntakes { get; set;}
        public DbSet<Weight> Weights { get; set;}
        public DbSet<Height> Heights { get; set;}
        public DbSet<LabResult> LabResults { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // builder.Entity<DoctorPatient> (x=>x.HasKey( xx=> new {xx.DoctorId, xx.PatientId}));

            builder.Entity<Doctor>()
            .HasMany(x=>x.Patients)
            .WithOne(x=>x.doctor);


            builder.Entity<Patient>()
            .HasMany(x=>x.LabResults)
            .WithOne(x=>x.patient);

            builder.Entity<Patient>()
            .HasMany(x=>x.Prescriptions)
            .WithOne(x=>x.patient);

            builder.Entity<Doctor>()
            .HasMany(x=>x.Prescribed)
            .WithOne(x=>x.doctor);


            builder.Entity<Patient>()
            .HasMany(x=>x.Allergies)
            .WithOne(x=>x.patient);

            builder.Entity<Doctor>()
            .HasMany(x=>x.postingAllergies)
            .WithOne(x=>x.doctor);

             builder.Entity<Doctor>()
            .HasMany(x=>x.PostingResults)
            .WithOne(x=>x.doctor);

            builder.Entity<Patient>()
            .HasMany(x => x.Height)
            .WithOne(x => x.patient);

             builder.Entity<Patient>()
            .HasMany(x => x.Weight)
            .WithOne(x => x.patient);

            builder.Entity<Patient>()
            .HasMany(x => x.WaterIntake)
            .WithOne(x => x.patient);

            
            builder.Entity<Patient>()
            .HasMany(x => x.Vitals)
            .WithOne(x => x.patient);


            

        
        }

    }
}
using HospitalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace HospitalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

          modelBuilder.Entity<HospitalKlinik>().HasKey(x => new {x.HospitalsId,x.KliniksId });

            modelBuilder.Entity<County>().HasOne(c => c.City).WithMany(c => c.Counties).HasForeignKey(x => x.CityId);
            modelBuilder.Entity<Hospital>().HasOne(c => c.County).WithMany(c => c.Hospitals).HasForeignKey(x => x.CountyId);
            modelBuilder.Entity<Doctor>().HasOne(d => d.Hospital).WithMany(h => h.Doctors).HasForeignKey(x => x.HospitalId);
            modelBuilder.Entity<WorkingHour>().HasOne(d => d.Doctor).WithMany(w => w.Hours).HasForeignKey(d => d.DoctorId);
            modelBuilder.Entity<Doctor>().HasOne(x => x.Klinik).WithMany(d => d.Doctors).HasForeignKey(k => k.KlinikId);

            
            modelBuilder.Entity<HospitalKlinik>().HasOne(h => h.Hospital).WithMany(x => x.HospitalKliniks).HasForeignKey(x=>x.HospitalsId);
            modelBuilder.Entity<HospitalKlinik>().HasOne(k => k.Klinik).WithMany(x => x.HospitalKliniks).HasForeignKey(x => x.KliniksId);

            //modelBuilder.Entity<Randevu>().HasOne(r => r.Doctor).WithMany(x => x.Randevus).HasForeignKey(x => x.DoktorId);
            //modelBuilder.Entity<Randevu>().HasOne(x => x.User).WithMany(x => x.Randevus).HasForeignKey(x => x.UserId);
            
           
        }

        
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<WorkingHour> WorkHours { get; set; }
        public DbSet<Klinik> Kliniks { get; set; }
        public DbSet<HospitalKlinik> HospitalKliniks { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
       
    }
}


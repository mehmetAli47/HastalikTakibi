using HastalikTakibi.DAL.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace HastalikTakibi.DAL
{
    public class HastlikTakipDbContext :DbContext
    {

        public HastlikTakipDbContext(DbContextOptions<HastlikTakipDbContext> options) : base(options) { 
           
        }

        public HastlikTakipDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiseaseCategory>()
          .HasOne<Disease>(s => s.Disease)
          .WithMany(g => g.DiseaseCategory)
          .HasForeignKey(s => s.DisaeaseId);

            modelBuilder.Entity<DiseaseView>().ToView("disease_vw");
            modelBuilder.Entity<PatientInformationView>().ToView("patientinformation_vm");
            modelBuilder.Entity<PatientExisting>().ToView("patients");
            modelBuilder.Entity<PatientRecovery>().ToView("patients_recovery");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Disease> Disease { get; set; }
        public DbSet<DiseaseView> DiseaseView { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DiseaseCategory> DiseaseCategory { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<PatientInformation> PatientInformation { get; set; }
        public DbSet<PatientInformationView> PatientInformationView { get; set; }
        public DbSet<PatientExisting> PatientExistings { get; set; }
        public DbSet<PatientRecovery> PatientRecoveries { get; set; }

    }
}

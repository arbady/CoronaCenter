using Microsoft.EntityFrameworkCore;
using System;
using CoronaCenter.Model.Entities;
using CoronaCenter.Model.FluentAPI;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CoronaCenter.DataBase.DataSet;
using System.Linq;

namespace CoronaCenter.DataBase
{
    public class DataContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<UserProfile> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<MedicalStaff> MedicalStaffs { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }

        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Console.WriteLine(options);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=LAPTOP-VIA3UD35; database=CoronaCenterDB; Trusted_Connection=true");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuration
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CenterConfiguration());
            modelBuilder.ApplyConfiguration(new UserProfileConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new MakerConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalStaffConfiguration());
            modelBuilder.ApplyConfiguration(new VaccineConfiguration());
            modelBuilder.ApplyConfiguration(new LotConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new VaccinationConfiguration());

            //DataSet
            modelBuilder.ApplyConfiguration(new AddressDataSet());
            modelBuilder.ApplyConfiguration(new CenterDataSet());
            modelBuilder.ApplyConfiguration(new UserDataSet());
            modelBuilder.ApplyConfiguration(new PatientDataSet());
            modelBuilder.ApplyConfiguration(new MakerDataSet());
            modelBuilder.ApplyConfiguration(new ScheduleDataSet());
            modelBuilder.ApplyConfiguration(new StaffDataSet());
            modelBuilder.ApplyConfiguration(new MedicalStaffDataSet());
            modelBuilder.ApplyConfiguration(new WarehouseDataSet());
            modelBuilder.ApplyConfiguration(new VaccineDataSet());
            modelBuilder.ApplyConfiguration(new LotDataSet());
            modelBuilder.ApplyConfiguration(new AppointmentDataSet());
            modelBuilder.ApplyConfiguration(new VaccinationDataSet());

            //this.Centers.Find(1).Vaccines.Append(this.Vaccines.Find(1));
            //this.Centers.Find(1).Vaccines.Append(this.Vaccines.Find(2));
            //this.SaveChanges();
            modelBuilder.Entity("CenterVaccine").HasData(new { CentersId = 1, VaccinesId = 1 });
            modelBuilder.Entity("CenterVaccine").HasData(new { CentersId = 1, VaccinesId = 2 });
        }
    }
}

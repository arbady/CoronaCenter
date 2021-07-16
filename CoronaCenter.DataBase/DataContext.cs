using CoronaCenter.DataBase;
using CoronaCenter.DataBase.DataSet;
using CoronaCenter.DataBase.Entities;
using CoronaCenter.DataBase.FluentAPI;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoronaCenter.DataBase
{
    public class DataContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Lot_Out> Lot_Outs { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Medical_Staff> Medical_Staffs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<UserProfile> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuration
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CalendarConfiguration());
            modelBuilder.ApplyConfiguration(new CenterConfiguation());
            modelBuilder.ApplyConfiguration(new LotConfiguration());
            //modelBuilder.ApplyConfiguration(new Lot_OutConfiguration());
            modelBuilder.ApplyConfiguration(new MakerConfiguration());
            modelBuilder.ApplyConfiguration(new Medical_StaffConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            modelBuilder.ApplyConfiguration(new VaccinationConfiguration());
            modelBuilder.ApplyConfiguration(new VaccineConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new UserProfileConfiguration());

            //DataSet
            //modelBuilder.ApplyConfiguration(new DataSetUser());
        }
    }
}

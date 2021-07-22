using Microsoft.EntityFrameworkCore;
using System;
using CoronaCenter.Model.Entities;
using CoronaCenter.Model.FluentAPI;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CoronaCenter.DataBase.DataSet;

namespace CoronaCenter.DataBase
{
    public class DataContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment> Calendars { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<LotOut> Lot_Outs { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<MedicalStaff> Medical_Staffs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<UserProfile> Users { get; set; }

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
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new CenterConfiguation());
            //modelBuilder.ApplyConfiguration(new Lot_OutConfiguration());
            modelBuilder.ApplyConfiguration(new MakerConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalStaffConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            modelBuilder.ApplyConfiguration(new VaccinationConfiguration());
            modelBuilder.ApplyConfiguration(new VaccineConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new LotConfiguration());
            modelBuilder.ApplyConfiguration(new UserProfileConfiguration());

            //DataSet
            modelBuilder.ApplyConfiguration(new DataSetStaff());
            //modelBuilder.ApplyConfiguration(new DataSetAddress());
            modelBuilder.ApplyConfiguration(new DataSetWarehouse());

            //modelBuilder.ApplyConfiguration(new DataSetUser());

            //UserProfile user_1 = new ()
            //{
            //    Id = 1,
            //    FirstName = "Samuel",
            //    LastName = "Legrain",
            //    Email = "samuel.legrain@bstorm.be",
            //    Salt = Guid.NewGuid().ToString()
            //};
            //user_1.Password = PasswordHasher.Hashing<UserProfile>(user_1, "test1234=", u => u.Salt);
            //modelBuilder.Entity<UserProfile>().HasData(user_1);

        }
    }
}

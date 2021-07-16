﻿// <auto-generated />
using System;
using CoronaCenter.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoronaCenter.DataBase.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210716154605_CreationDB")]
    partial class CreationDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CenterVaccine", b =>
                {
                    b.Property<int>("CentersId")
                        .HasColumnType("int");

                    b.Property<int>("VaccinesId")
                        .HasColumnType("int");

                    b.HasKey("CentersId", "VaccinesId");

                    b.HasIndex("VaccinesId");

                    b.ToTable("CenterVaccine");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("Province")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateVacc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("HoursVacc")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("VaccineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("PatientId");

                    b.HasIndex("VaccineId");

                    b.ToTable("Appointment");

                    b.HasCheckConstraint("DateVacc", "[DateVacc] >= GetDate()");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Center", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("ResponsibleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("ResponsibleId")
                        .IsUnique();

                    b.ToTable("Center");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Lot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateIn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("VaccineId")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("VaccineId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Lot");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Lot_Out", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("LotId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LotId");

                    b.ToTable("Lot_Outs");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Maker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Maker");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Medical_Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InamiNumber")
                        .IsRequired()
                        .HasColumnType("CHAR(11)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InamiNumber")
                        .IsUnique();

                    b.HasIndex("StaffId");

                    b.ToTable("Medical_Staff");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("MedicalIndication")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("NISS")
                        .IsRequired()
                        .HasColumnType("CHAR(13)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("NISS")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CloseHours")
                        .HasColumnType("datetime2");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("DayNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("OpenHours")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("VARBINARY(32)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("CHAR(36)");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PatientId");

                    b.HasIndex("StaffId");

                    b.ToTable("UserProfile");

                    b.HasCheckConstraint("CK_Email", "Email LIKE '__%@__%.%'");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Vaccination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("LotId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalStaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("LotId");

                    b.HasIndex("MedicalStaffId");

                    b.ToTable("Vaccination");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MakerId")
                        .HasColumnType("int");

                    b.Property<int?>("MakerId1")
                        .HasColumnType("int");

                    b.Property<int>("MaxInterval")
                        .HasColumnType("int");

                    b.Property<int>("MinInterval")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.HasIndex("MakerId1");

                    b.ToTable("Vaccine");

                    b.HasCheckConstraint("CK_MinInterval", "MinInterval <= MaxInterval");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("CenterVaccine", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Center", null)
                        .WithMany()
                        .HasForeignKey("CentersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Vaccine", null)
                        .WithMany()
                        .HasForeignKey("VaccinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Appointment", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Center", "Center")
                        .WithMany("Appointments")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Vaccine", "Vaccine")
                        .WithMany("Appointments")
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");

                    b.Navigation("Patient");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Center", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Address", "Address")
                        .WithOne()
                        .HasForeignKey("CoronaCenter.DataBase.Entities.Center", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Staff", "Responsible")
                        .WithOne()
                        .HasForeignKey("CoronaCenter.DataBase.Entities.Center", "ResponsibleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Responsible");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Lot", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Center", "Center")
                        .WithMany("Lots")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Vaccine", "Vaccine")
                        .WithMany("Lots")
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Warehouse", "Warehouse")
                        .WithMany("Lots")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Center");

                    b.Navigation("Vaccine");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Lot_Out", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Lot", "Lot")
                        .WithMany("Lot_Outs")
                        .HasForeignKey("LotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lot");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Medical_Staff", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Staff", "Staff")
                        .WithMany("Medical_Staffs")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Patient", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Address", "Address")
                        .WithOne()
                        .HasForeignKey("CoronaCenter.DataBase.Entities.Patient", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.UserProfile", "User")
                        .WithOne()
                        .HasForeignKey("CoronaCenter.DataBase.Entities.Patient", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Schedule", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Center", "Center")
                        .WithMany("Schedules")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Staff", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Center", "Center")
                        .WithMany("Staffs")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.UserProfile", "User")
                        .WithOne()
                        .HasForeignKey("CoronaCenter.DataBase.Entities.Staff", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.UserProfile", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("CoronaCenter.DataBase.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");

                    b.Navigation("Patient");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Vaccination", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Appointment", "Appointment")
                        .WithMany("Vaccinations")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Lot", "Lot")
                        .WithMany("Vaccinations")
                        .HasForeignKey("LotId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Medical_Staff", "MedicalStaff")
                        .WithMany("Vaccinations")
                        .HasForeignKey("MedicalStaffId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Lot");

                    b.Navigation("MedicalStaff");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Vaccine", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Maker", "Maker")
                        .WithMany()
                        .HasForeignKey("MakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaCenter.DataBase.Entities.Maker", null)
                        .WithMany("Vaccines")
                        .HasForeignKey("MakerId1");

                    b.Navigation("Maker");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Warehouse", b =>
                {
                    b.HasOne("CoronaCenter.DataBase.Entities.Address", "Address")
                        .WithOne()
                        .HasForeignKey("CoronaCenter.DataBase.Entities.Warehouse", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Appointment", b =>
                {
                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Center", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Lots");

                    b.Navigation("Schedules");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Lot", b =>
                {
                    b.Navigation("Lot_Outs");

                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Maker", b =>
                {
                    b.Navigation("Vaccines");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Medical_Staff", b =>
                {
                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Staff", b =>
                {
                    b.Navigation("Medical_Staffs");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Vaccine", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Lots");
                });

            modelBuilder.Entity("CoronaCenter.DataBase.Entities.Warehouse", b =>
                {
                    b.Navigation("Lots");
                });
#pragma warning restore 612, 618
        }
    }
}

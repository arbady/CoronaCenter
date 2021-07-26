using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaCenter.DataBase.Migrations
{
    public partial class creationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Province = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouse_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MinInterval = table.Column<int>(type: "int", nullable: false),
                    MaxInterval = table.Column<int>(type: "int", nullable: false),
                    MakerId = table.Column<int>(type: "int", nullable: false),
                    MakerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccine", x => x.Id);
                    table.CheckConstraint("CK_MinInterval", "MinInterval <= MaxInterval");
                    table.ForeignKey(
                        name: "FK_Vaccine_Maker_MakerId",
                        column: x => x.MakerId,
                        principalTable: "Maker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccine_Maker_MakerId1",
                        column: x => x.MakerId1,
                        principalTable: "Maker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Center",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ResponsibleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Center_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CenterVaccine",
                columns: table => new
                {
                    CentersId = table.Column<int>(type: "int", nullable: false),
                    VaccinesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterVaccine", x => new { x.CentersId, x.VaccinesId });
                    table.ForeignKey(
                        name: "FK_CenterVaccine_Center_CentersId",
                        column: x => x.CentersId,
                        principalTable: "Center",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CenterVaccine_Vaccine_VaccinesId",
                        column: x => x.VaccinesId,
                        principalTable: "Vaccine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIn = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    VaccineId = table.Column<int>(type: "int", nullable: false),
                    CenterId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lot_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lot_Vaccine_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lot_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    OpenHours = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseHours = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayNumber = table.Column<int>(type: "int", nullable: false),
                    CenterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LotOut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotOut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotOut_Lot_LotId",
                        column: x => x.LotId,
                        principalTable: "Lot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NISS = table.Column<string>(type: "CHAR(13)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalIndication = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateVacc = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    HoursVacc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    CenterId = table.Column<int>(type: "int", nullable: false),
                    VaccineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.CheckConstraint("DateVacc", "[DateVacc] >= GetDate()");
                    table.ForeignKey(
                        name: "FK_Appointment_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Vaccine_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalStaffId = table.Column<int>(type: "int", nullable: false),
                    LotId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccination_Appointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccination_Lot_LotId",
                        column: x => x.LotId,
                        principalTable: "Lot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Risponsible = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CenterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InamiNumber = table.Column<string>(type: "CHAR(11)", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<byte[]>(type: "VARBINARY(32)", nullable: false),
                    Salt = table.Column<string>(type: "CHAR(36)", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.CheckConstraint("CK_Email", "Email LIKE '__%@__%.%'");
                    table.ForeignKey(
                        name: "FK_UserProfile_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProfile_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Number", "Province", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Rixensart", "10", 0, "Rue de la paix", 1040 },
                    { 12, "BoitsFort", "106c", 0, "Rue Grande", 1170 },
                    { 10, "Huy", "57", 2, "Rue Simone de Bondue", 4500 },
                    { 9, "Tournai", "13", 1, "Cité des anges", 7500 },
                    { 8, "Saint-Ghislain", "53", 1, "Cité des pétetites préelles", 7330 },
                    { 7, "Colfontaine", "14A", 1, "Cité de l'Abbaye", 7340 },
                    { 11, "Diant", "83", 4, "Impasse des maraichers", 5500 },
                    { 5, "Namur", "121", 4, "Rue du bonheur", 5000 },
                    { 4, "Liège", "1", 2, "Rue de la peur", 4000 },
                    { 3, "Charleroi", "5 Bis", 1, "Rue des Oiseaux", 6000 },
                    { 2, "Mons", "8", 1, "Rue de l'Espinette", 7000 },
                    { 6, "Frameries", "2/3", 1, "Clos des Ormes", 7080 }
                });

            migrationBuilder.InsertData(
                table: "Maker",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BioNTech" },
                    { 2, "Oxford" },
                    { 3, "Moderna" },
                    { 4, "Johnson & Johnson" }
                });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PatientId", "Salt", "StaffId" },
                values: new object[,]
                {
                    { 4, "badispace@gmail.com", "Steve", "Buanga", new byte[] { 49, 143, 216, 36, 231, 154, 110, 185, 177, 29, 7, 179, 254, 101, 69, 133, 202, 94, 34, 102, 125, 124, 118, 130, 189, 81, 18, 168, 125, 37, 253, 15 }, null, "28a82494-82c2-4af3-a361-108cfa92a473", null },
                    { 1, "arnoldmpoyi@yahoo.fr", "Arnold", "Mpoyi", new byte[] { 246, 160, 244, 210, 177, 53, 4, 62, 230, 188, 163, 102, 74, 208, 17, 196, 157, 140, 150, 249, 245, 231, 138, 97, 55, 131, 70, 103, 90, 204, 52, 55 }, null, "50a7117c-e1ff-4153-828b-20fff1211385", null },
                    { 2, "cocodeblock@gmail.com", "Corentin", "De Block", new byte[] { 135, 196, 248, 53, 211, 66, 104, 44, 53, 147, 225, 85, 231, 115, 51, 248, 82, 87, 105, 191, 37, 21, 132, 13, 208, 32, 26, 169, 47, 162, 250, 33 }, null, "10ca32d2-e9f9-49e8-bc18-bead773d9620", null },
                    { 3, "IsaSkou@yahoo.com", "Isabel", "Skou", new byte[] { 162, 227, 201, 2, 107, 82, 14, 208, 61, 101, 153, 57, 46, 90, 227, 50, 231, 193, 152, 105, 135, 8, 50, 41, 53, 46, 137, 168, 49, 202, 31, 137 }, null, "352b561f-59b6-4f24-a358-4cef6210ab15", null },
                    { 5, "tototata@gmail.com", "Toto", "Tata", new byte[] { 189, 195, 202, 76, 74, 90, 50, 92, 16, 80, 67, 59, 6, 184, 243, 41, 112, 21, 25, 29, 58, 157, 73, 41, 147, 178, 218, 191, 92, 48, 66, 33 }, null, "19320766-093a-491a-8741-13e94d6a62ce", null }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "AddressId", "DateOfBirth", "MedicalIndication", "NISS", "PhoneNumber", "UserId" },
                values: new object[] { 1, 1, new DateTime(1986, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "86043058162", "0466423930", 5 });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "CenterId", "Grade", "Risponsible", "UserId" },
                values: new object[,]
                {
                    { 1, null, 0, true, 1 },
                    { 2, null, 1, false, 2 },
                    { 3, null, 2, false, 3 },
                    { 4, null, 2, false, 4 }
                });

            migrationBuilder.InsertData(
                table: "Vaccine",
                columns: new[] { "Id", "MakerId", "MakerId1", "MaxInterval", "MinInterval", "Name" },
                values: new object[,]
                {
                    { 1, 1, null, 2, 1, "Pfizer" },
                    { 2, 2, null, 2, 1, "AstraZeneca" },
                    { 3, 3, null, 2, 1, "Moderna" },
                    { 4, 4, null, 2, 1, "Johnson & Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Entrepot Numero1" },
                    { 2, 6, "Entrepot Numero2" },
                    { 3, 7, "Entrepot Numero3" },
                    { 4, 8, "Entrepot Numero4" }
                });

            migrationBuilder.InsertData(
                table: "Center",
                columns: new[] { "Id", "AddressId", "Name", "ResponsibleId" },
                values: new object[,]
                {
                    { 1, 9, "CV Numero1", 1 },
                    { 2, 10, "CV Numero2", 2 },
                    { 3, 11, "CV Numero3", 3 },
                    { 4, 12, "CV Numero4", 4 }
                });

            migrationBuilder.InsertData(
                table: "Lot",
                columns: new[] { "Id", "CenterId", "DateIn", "Quantity", "VaccineId", "WarehouseId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000, 1, 1 },
                    { 2, 2, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, 2, 2 },
                    { 3, 3, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500, 3, 3 },
                    { 4, 4, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4200, 4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CenterId",
                table: "Appointment",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientId",
                table: "Appointment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_VaccineId",
                table: "Appointment",
                column: "VaccineId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_AddressId",
                table: "Center",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Center_ResponsibleId",
                table: "Center",
                column: "ResponsibleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CenterVaccine_VaccinesId",
                table: "CenterVaccine",
                column: "VaccinesId");

            migrationBuilder.CreateIndex(
                name: "IX_Lot_CenterId",
                table: "Lot",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Lot_VaccineId",
                table: "Lot",
                column: "VaccineId");

            migrationBuilder.CreateIndex(
                name: "IX_Lot_WarehouseId",
                table: "Lot",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_LotOut_LotId",
                table: "LotOut",
                column: "LotId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaff_InamiNumber",
                table: "MedicalStaff",
                column: "InamiNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaff_StaffId",
                table: "MedicalStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AddressId",
                table: "Patient",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_NISS",
                table: "Patient",
                column: "NISS",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UserId",
                table: "Patient",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_CenterId",
                table: "Schedule",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CenterId",
                table: "Staff",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_UserId",
                table: "Staff",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_Email",
                table: "UserProfile",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_PatientId",
                table: "UserProfile",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_StaffId",
                table: "UserProfile",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_AppointmentId",
                table: "Vaccination",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_LotId",
                table: "Vaccination",
                column: "LotId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_MedicalStaffId",
                table: "Vaccination",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccine_MakerId",
                table: "Vaccine",
                column: "MakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccine_MakerId1",
                table: "Vaccine",
                column: "MakerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_AddressId",
                table: "Warehouse",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Center_Staff_ResponsibleId",
                table: "Center",
                column: "ResponsibleId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_UserProfile_UserId",
                table: "Patient",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccination_MedicalStaff_MedicalStaffId",
                table: "Vaccination",
                column: "MedicalStaffId",
                principalTable: "MedicalStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_UserProfile_UserId",
                table: "Staff",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Center_CenterId",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_Patient_PatientId",
                table: "UserProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_Staff_StaffId",
                table: "UserProfile");

            migrationBuilder.DropTable(
                name: "CenterVaccine");

            migrationBuilder.DropTable(
                name: "LotOut");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Vaccination");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Lot");

            migrationBuilder.DropTable(
                name: "MedicalStaff");

            migrationBuilder.DropTable(
                name: "Vaccine");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Maker");

            migrationBuilder.DropTable(
                name: "Center");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "UserProfile");
        }
    }
}

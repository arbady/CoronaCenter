using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaCenter.DataBase.Migrations
{
    public partial class creationdatasetappointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "CenterId", "DateVacc", "HoursVacc", "PatientId", "VaccineId" },
                values: new object[] { 1, 1, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 15, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 163, 138, 104, 158, 236, 128, 170, 120, 216, 97, 228, 55, 100, 32, 146, 5, 184, 113, 230, 236, 197, 239, 88, 111, 181, 50, 54, 115, 214, 102, 205, 86 }, "71260c9f-b841-479a-8c57-25c53b8a4128" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 103, 24, 125, 143, 128, 114, 181, 204, 83, 231, 166, 127, 102, 202, 250, 73, 235, 225, 129, 83, 21, 208, 119, 36, 222, 1, 232, 190, 226, 19, 29, 70 }, "fdc78ec3-9ebe-4145-9b25-92ba6e3ba69b" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 48, 201, 3, 119, 74, 243, 125, 101, 175, 177, 90, 171, 109, 85, 142, 204, 39, 116, 96, 75, 9, 190, 34, 5, 136, 231, 29, 255, 85, 147, 46, 213 }, "a75d7839-31e5-407a-b8ab-1348acabac69" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 174, 134, 107, 154, 192, 106, 213, 57, 9, 216, 2, 3, 108, 105, 56, 196, 234, 238, 239, 2, 158, 236, 152, 214, 136, 8, 225, 23, 165, 104, 172, 8 }, "09f2193e-15c3-4987-864f-81d442961832" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 4, 67, 20, 130, 181, 121, 172, 182, 175, 65, 234, 199, 83, 238, 181, 130, 24, 230, 85, 119, 167, 38, 89, 25, 110, 0, 164, 157, 48, 6, 115, 239 }, "30c701cf-4f92-455b-893b-a16e494eabf4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 108, 4, 128, 98, 166, 225, 198, 9, 104, 125, 12, 71, 235, 29, 113, 223, 79, 251, 155, 97, 35, 95, 215, 41, 251, 158, 220, 27, 143, 90, 42, 47 }, "63988230-2860-4e1f-9296-ca32bff25da8" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 62, 120, 123, 53, 211, 204, 170, 192, 130, 59, 174, 217, 212, 205, 225, 19, 44, 117, 192, 176, 172, 173, 48, 126, 228, 78, 107, 132, 9, 28, 43, 27 }, "04ed30e3-b0be-4538-af1e-059272ae7f24" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 24, 21, 186, 16, 75, 184, 21, 51, 100, 153, 162, 129, 10, 195, 146, 90, 26, 115, 244, 239, 220, 220, 115, 8, 252, 8, 224, 62, 115, 7, 182, 212 }, "8b352b9d-97f8-45a7-9cb1-18a182ed4f45" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 89, 34, 217, 126, 28, 85, 65, 240, 16, 184, 169, 15, 35, 107, 239, 173, 247, 80, 220, 221, 7, 121, 74, 148, 233, 195, 137, 43, 224, 193, 152, 170 }, "aa94422d-2b86-4832-b2fc-226760755fe8" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 73, 250, 235, 26, 70, 9, 242, 46, 192, 237, 148, 37, 142, 45, 160, 72, 225, 48, 161, 17, 29, 40, 63, 1, 142, 139, 188, 5, 40, 139, 0, 12 }, "2cfc5df5-8190-464d-bd74-793d11eb3c72" });
        }
    }
}

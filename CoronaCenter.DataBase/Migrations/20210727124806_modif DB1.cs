using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaCenter.DataBase.Migrations
{
    public partial class modifDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalStaff_Staff_StaffId",
                table: "MedicalStaff");

            migrationBuilder.DropIndex(
                name: "IX_MedicalStaff_StaffId",
                table: "MedicalStaff");

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 25, 78, 175, 207, 37, 209, 117, 182, 211, 149, 103, 251, 32, 212, 165, 34, 166, 125, 139, 224, 19, 3, 24, 243, 207, 163, 154, 220, 236, 15, 172, 51 }, "6201101a-13aa-4bb9-ad9d-13384bb7b7e3" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 66, 225, 146, 73, 246, 63, 217, 141, 27, 167, 215, 169, 175, 160, 24, 208, 163, 240, 133, 223, 166, 56, 155, 253, 152, 240, 43, 6, 107, 138, 152, 17 }, "1330940e-e1ac-412f-a5fc-e3a27ea0358e" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 157, 95, 9, 56, 225, 87, 128, 219, 26, 227, 50, 107, 188, 29, 194, 225, 64, 191, 128, 4, 174, 236, 124, 230, 168, 241, 201, 132, 182, 51, 210, 164 }, "e3c8688a-3405-46d1-b0fa-1d6d04188cb8" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 24, 50, 128, 22, 95, 151, 6, 237, 163, 175, 209, 228, 246, 203, 204, 209, 160, 85, 86, 35, 99, 121, 222, 206, 207, 202, 247, 228, 19, 43, 40, 152 }, "ff53545d-62a7-4c55-9ddb-7c965870763a" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 150, 78, 69, 74, 224, 97, 0, 125, 142, 66, 39, 147, 106, 55, 138, 224, 29, 243, 79, 55, 241, 246, 6, 149, 128, 138, 243, 80, 147, 95, 70, 122 }, "730027d2-5c95-4a8d-a62e-277f83060964" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaff_StaffId",
                table: "MedicalStaff",
                column: "StaffId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalStaff_Staff_StaffId",
                table: "MedicalStaff",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalStaff_Staff_StaffId",
                table: "MedicalStaff");

            migrationBuilder.DropIndex(
                name: "IX_MedicalStaff_StaffId",
                table: "MedicalStaff");

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 156, 136, 249, 167, 187, 157, 37, 95, 174, 27, 144, 183, 37, 73, 2, 192, 6, 65, 59, 141, 130, 189, 84, 23, 0, 222, 168, 216, 96, 208, 53, 154 }, "1a65028f-e7fd-468d-af28-3ea42ca97d2a" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 79, 71, 77, 113, 61, 179, 224, 202, 58, 15, 53, 212, 236, 244, 60, 206, 35, 86, 13, 246, 224, 235, 221, 84, 161, 71, 28, 108, 143, 92, 209, 44 }, "6ad582b6-c316-4505-aebf-0738bd401bf2" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 85, 9, 34, 23, 242, 199, 7, 163, 38, 69, 249, 205, 15, 162, 18, 253, 186, 14, 111, 86, 139, 250, 108, 129, 252, 166, 99, 207, 106, 186, 224, 247 }, "b9cd2478-a69a-4133-8d40-6d96c070f905" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 5, 19, 153, 60, 163, 175, 220, 11, 108, 169, 162, 6, 40, 208, 85, 10, 134, 181, 126, 146, 158, 200, 31, 0, 20, 252, 5, 94, 225, 35, 241, 14 }, "93b99c2b-55d2-42ba-80b6-73d4d8bb47ad" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 198, 220, 250, 69, 29, 99, 99, 0, 142, 198, 160, 221, 47, 33, 140, 114, 142, 123, 209, 241, 4, 208, 62, 58, 81, 5, 50, 0, 184, 150, 30, 112 }, "45c987dc-47dc-48b2-87c9-c6774eecff3b" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaff_StaffId",
                table: "MedicalStaff",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalStaff_Staff_StaffId",
                table: "MedicalStaff",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

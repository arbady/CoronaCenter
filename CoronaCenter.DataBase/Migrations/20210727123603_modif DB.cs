using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaCenter.DataBase.Migrations
{
    public partial class modifDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_Patient_PatientId",
                table: "UserProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_Staff_StaffId",
                table: "UserProfile");

            migrationBuilder.DropIndex(
                name: "IX_UserProfile_PatientId",
                table: "UserProfile");

            migrationBuilder.DropIndex(
                name: "IX_UserProfile_StaffId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "UserProfile");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "UserProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "UserProfile",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 188, 151, 171, 234, 17, 48, 174, 110, 1, 72, 163, 100, 44, 25, 163, 43, 197, 244, 244, 242, 83, 204, 175, 36, 113, 219, 241, 10, 170, 30, 167, 20 }, "3928c514-8c4f-451a-b576-9f212d77d571" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 242, 184, 116, 30, 8, 27, 144, 110, 92, 12, 78, 166, 102, 163, 35, 3, 134, 166, 38, 155, 159, 141, 147, 246, 118, 90, 78, 44, 123, 61, 9, 200 }, "6051462a-dfbf-4b0a-96e8-fa11988c458a" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 194, 70, 221, 248, 218, 179, 99, 170, 52, 166, 77, 22, 23, 245, 183, 189, 112, 46, 28, 186, 24, 246, 2, 28, 68, 100, 218, 196, 126, 175, 216, 124 }, "866011d9-0565-4582-84bd-d4a6fb38a6b5" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 113, 159, 215, 136, 105, 246, 248, 161, 8, 204, 244, 70, 30, 127, 88, 218, 127, 21, 109, 1, 124, 40, 76, 63, 147, 193, 244, 25, 251, 225, 150, 143 }, "b665dbcd-fb90-4fae-befb-66e7c0f0ba44" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 68, 129, 3, 176, 177, 216, 249, 7, 117, 12, 211, 223, 18, 223, 47, 34, 128, 246, 163, 110, 62, 61, 100, 172, 20, 242, 100, 53, 164, 150, 97, 231 }, "dccb4f42-66c0-46fa-ab9d-fdd3e0d5d40e" });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_PatientId",
                table: "UserProfile",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_StaffId",
                table: "UserProfile",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_Patient_PatientId",
                table: "UserProfile",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_Staff_StaffId",
                table: "UserProfile",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

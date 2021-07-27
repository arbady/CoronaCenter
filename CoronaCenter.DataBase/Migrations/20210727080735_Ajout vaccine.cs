using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaCenter.DataBase.Migrations
{
    public partial class Ajoutvaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CenterVaccine",
                columns: new[] { "CentersId", "VaccinesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CenterVaccine",
                keyColumns: new[] { "CentersId", "VaccinesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CenterVaccine",
                keyColumns: new[] { "CentersId", "VaccinesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 92, 152, 110, 76, 244, 236, 244, 36, 193, 12, 10, 223, 46, 195, 74, 13, 126, 141, 26, 230, 252, 143, 254, 166, 147, 145, 215, 149, 188, 188, 119, 131 }, "c2243088-e748-4474-b8b2-3e03d5f51317" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 134, 15, 242, 233, 63, 90, 158, 43, 105, 159, 236, 192, 107, 250, 255, 60, 194, 247, 76, 218, 49, 221, 84, 174, 179, 32, 53, 122, 126, 30, 168, 158 }, "93b9d0e8-4b56-41e6-8c3b-7db5b8c4a80e" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 68, 75, 177, 89, 240, 209, 174, 206, 236, 19, 29, 142, 147, 193, 160, 75, 128, 236, 136, 255, 205, 98, 186, 242, 97, 185, 75, 234, 18, 149, 43, 8 }, "d6358adc-f3de-4c59-8904-3aae77aa9977" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 36, 183, 185, 136, 24, 143, 162, 118, 230, 95, 132, 110, 200, 59, 2, 232, 128, 248, 42, 243, 233, 161, 220, 12, 91, 238, 62, 169, 178, 200, 129, 142 }, "81c6fe2b-68a0-4369-94e6-949a4d3d3c3d" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 233, 154, 79, 119, 248, 213, 222, 63, 112, 63, 53, 125, 200, 132, 112, 213, 71, 99, 63, 210, 53, 151, 33, 66, 199, 91, 179, 52, 216, 161, 58, 186 }, "3fa3fcad-c4ce-45c0-bea5-ade25bebdda4" });
        }
    }
}

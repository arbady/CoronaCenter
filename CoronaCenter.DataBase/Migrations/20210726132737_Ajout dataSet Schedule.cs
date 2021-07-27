using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaCenter.DataBase.Migrations
{
    public partial class AjoutdataSetSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "CenterId", "CloseHours", "Day", "OpenHours" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2021, 10, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 10, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2021, 10, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 10, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 136, 217, 103, 250, 126, 163, 94, 0, 89, 219, 32, 202, 23, 252, 179, 201, 227, 203, 128, 123, 143, 52, 173, 147, 243, 240, 137, 133, 255, 184, 144, 212 }, "881238e6-30d7-4162-b912-9de7be9c1b95" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 208, 109, 60, 231, 115, 238, 72, 166, 216, 66, 34, 112, 82, 242, 111, 13, 124, 38, 67, 237, 254, 40, 215, 35, 92, 142, 172, 186, 24, 244, 222, 171 }, "be1f7698-90e1-48cd-a38a-9365be7cc75e" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 207, 157, 222, 62, 187, 165, 27, 250, 76, 94, 123, 129, 142, 185, 8, 175, 122, 161, 115, 224, 17, 243, 125, 139, 28, 137, 163, 151, 155, 202, 158, 166 }, "01fcd12f-1144-4a97-9b57-c97108d10693" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 47, 225, 190, 182, 193, 137, 228, 114, 90, 117, 141, 118, 218, 19, 154, 52, 30, 141, 251, 188, 208, 53, 43, 23, 226, 104, 54, 231, 175, 251, 32, 116 }, "93fe1f77-bc87-4275-bbf4-43024353b407" });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { new byte[] { 207, 61, 191, 34, 27, 232, 57, 146, 167, 169, 174, 165, 137, 103, 183, 86, 87, 105, 33, 194, 31, 37, 111, 200, 70, 147, 45, 27, 156, 38, 57, 13 }, "6ebdde99-b5bf-460b-bef0-8e68b6a43162" });
        }
    }
}

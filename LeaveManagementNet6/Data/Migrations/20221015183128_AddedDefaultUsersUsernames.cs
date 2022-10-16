using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd54b7f-a8cc-5559-cbba-2bee542ddcca",
                column: "ConcurrencyStamp",
                value: "3cfdaf93-d883-4587-b21c-c0ca11af3907");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd65b7a-a8dd-5559-cbba-2bee542eecca",
                column: "ConcurrencyStamp",
                value: "1492b557-7af4-403c-9056-59c4e84d9fc6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8cc-5559-dccb-2cff542ddcca",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "798a7d91-02ae-4e4f-95e7-d018c672da49", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAED6FELWnJ1cxSMXjeP7/3e1jRcMBoVffgqg0h7Wo4O+J8NRQf7E4hlFkclgUhse4tA==", "c1ed63cc-73ef-404c-aeaa-4c59360ec91a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd54b7f-a8cc-5559-cbba-2bee542ddcca",
                column: "ConcurrencyStamp",
                value: "7e16a479-20d8-4de9-b6c2-f20fea2eedd4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd65b7a-a8dd-5559-cbba-2bee542eecca",
                column: "ConcurrencyStamp",
                value: "9f8d29cc-79ae-4cf1-a358-c3bd2ddd36c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8cc-5559-dccb-2cff542ddcca",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05c553a5-c5e0-436f-9c4e-4ed4205fd270", false, null, "AQAAAAEAACcQAAAAEL7E/DHaCGR6tDWVk7M6s5l87vTBnz9WpWanOAHrcsALBgYEXXH1KnAbGenuA3enPA==", "86b67a27-ce19-4e07-836d-23a72b25e9b7" });
        }
    }
}

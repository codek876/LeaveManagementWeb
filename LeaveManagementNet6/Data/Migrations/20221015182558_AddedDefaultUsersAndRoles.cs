using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateofBirth",
                table: "AspNetUsers",
                newName: "DateOfBirth");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbd54b7f-a8cc-5559-cbba-2bee542ddcca", "7e16a479-20d8-4de9-b6c2-f20fea2eedd4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbd65b7a-a8dd-5559-cbba-2bee542eecca", "9f8d29cc-79ae-4cf1-a358-c3bd2ddd36c0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ece65c8a-a8cc-5559-dccb-2cff542ddcca", 0, "05c553a5-c5e0-436f-9c4e-4ed4205fd270", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEL7E/DHaCGR6tDWVk7M6s5l87vTBnz9WpWanOAHrcsALBgYEXXH1KnAbGenuA3enPA==", null, false, "86b67a27-ce19-4e07-836d-23a72b25e9b7", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dbd54b7f-a8cc-5559-cbba-2bee542ddcca", "ece65c8a-a8cc-5559-dccb-2cff542ddcca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd65b7a-a8dd-5559-cbba-2bee542eecca");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd54b7f-a8cc-5559-cbba-2bee542ddcca", "ece65c8a-a8cc-5559-dccb-2cff542ddcca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd54b7f-a8cc-5559-cbba-2bee542ddcca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8cc-5559-dccb-2cff542ddcca");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "AspNetUsers",
                newName: "DateofBirth");
        }
    }
}

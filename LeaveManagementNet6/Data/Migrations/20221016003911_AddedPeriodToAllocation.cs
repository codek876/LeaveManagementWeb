using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd54b7f-a8cc-5559-cbba-2bee542ddcca",
                column: "ConcurrencyStamp",
                value: "2faf5aae-9fe7-4a99-9643-ed99f1733b22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd65b7a-a8dd-5559-cbba-2bee542eecca",
                column: "ConcurrencyStamp",
                value: "590b4ce3-f100-41ee-9c03-fcee096b3b0b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8cc-5559-dccb-2cff542ddcca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e64a827-ea64-49ab-8d18-fa61c7afc65a", "AQAAAAEAACcQAAAAENN5j9GwRHrq4HnamcVy6Ci3IJS8FeMrmMUxIguvYm8q1UcRXppkzv40PdDP4EV0zw==", "97380078-89cd-450d-86f3-e8f0ec464622" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "798a7d91-02ae-4e4f-95e7-d018c672da49", "AQAAAAEAACcQAAAAED6FELWnJ1cxSMXjeP7/3e1jRcMBoVffgqg0h7Wo4O+J8NRQf7E4hlFkclgUhse4tA==", "c1ed63cc-73ef-404c-aeaa-4c59360ec91a" });
        }
    }
}

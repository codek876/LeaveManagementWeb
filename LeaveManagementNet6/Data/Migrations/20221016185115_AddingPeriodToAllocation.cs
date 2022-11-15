using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "1a77f29c-b964-42f5-a44d-6b1fc9c8905d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acd431eabbf",
                column: "ConcurrencyStamp",
                value: "64280ae2-7a39-466d-a82b-ca9f1cd97bdf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd54b7f-b7dd-5557-dccb-2bee653eeddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32351f88-3a94-4bd8-a1ed-306d1d28fa3f", "AQAAAAEAACcQAAAAEG34QA54D4G9qon2asbLg1cwM+yw3ci95h+a0qRFU53LZx8kd9ztOTVh7mu+qoKWJQ==", "2d271999-9755-4344-b106-47ed62799e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8bb-5558-dccb-2cff542ddddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a2e6fb4-bed7-43e4-a1cd-f56de2b965aa", "AQAAAAEAACcQAAAAENCBQMmUkew0kuWQBSDvGJrKUjMOpn5iy4W/9ZhsWo7HTcFlNn+U6TbC+s05xHGbTg==", "548376ee-5403-40fc-9cc2-372b5dfc1a2c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "11a8fbca-aad9-4250-a79e-e7a3df6c228d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acd431eabbf",
                column: "ConcurrencyStamp",
                value: "fffc0c50-5b14-4556-af4c-94c2d717af90");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd54b7f-b7dd-5557-dccb-2bee653eeddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a71b999-4e1e-467d-9ecd-bdbddda6976f", "AQAAAAEAACcQAAAAEAFyc18uhm0mLLfUBDNhN+k1phFnv+qg7RqTUQGb+LaJk0+OCbPNa9Ui8XQ0sEzc9A==", "1786764d-e774-45b7-8c6e-644edb14cc3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8bb-5558-dccb-2cff542ddddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3559f3ab-7929-49b6-8cf4-9c3729eae7bd", "AQAAAAEAACcQAAAAEL+VMkybprPQiAOHUzrNIgW/CBXzKT8IOQNJd5NtPNjVwXJasSdwyHFAtIQaEAYEXw==", "9bc0425c-c4a9-4a02-960b-a31f354d54f0" });
        }
    }
}

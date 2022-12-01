using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class AddedLeaveReuqestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestedEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3149c7de-d66a-4d76-b4ce-779227bcba81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acd431eabbf",
                column: "ConcurrencyStamp",
                value: "f7b2baa1-7267-42db-b096-6c52b76e2d11");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd54b7f-b7dd-5557-dccb-2bee653eeddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a60de3e0-699a-4ea6-8f61-16d72635eb53", "AQAAAAEAACcQAAAAEAw4LnZYezoQzdpo8UsGeGNwW1+IdBvKEK+NQW7z3TIBDfWYt8K44cbfRoPq2x80Ww==", "07bd4c68-f812-46b0-b91f-40ebfb0abf59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8bb-5558-dccb-2cff542ddddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "106b44ab-be77-478c-8a00-ba44821a205a", "AQAAAAEAACcQAAAAEM6oDDT7w7duYoUGodEXGYy/npCxnPo67tzGTQGFyXnfWuquUn2hz4Nrmp5HnTexYA==", "7de47e76-565a-49e5-862e-d44b9f392dfb" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}

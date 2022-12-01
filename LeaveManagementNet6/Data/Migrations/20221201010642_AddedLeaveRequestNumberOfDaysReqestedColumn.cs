using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class AddedLeaveRequestNumberOfDaysReqestedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountedDays",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3258147b-e614-4124-b351-181319503a7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acd431eabbf",
                column: "ConcurrencyStamp",
                value: "befab864-7d2d-4c24-a81e-57f22e18aeac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd54b7f-b7dd-5557-dccb-2bee653eeddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40ad6778-68f8-4460-b8b2-0fae771575d2", "AQAAAAEAACcQAAAAEFOjOpCJUIzfkkTtL/pvx7JnUcLcCjTvzEKrJKQF0KpngNAk/OPiZj6Te61jQMmjGQ==", "16c2ffb8-c307-4d09-b4b8-e0493b8178d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8bb-5558-dccb-2cff542ddddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bd6eab5-8e6c-4c91-ae6f-536b790ec933", "AQAAAAEAACcQAAAAEA6ZKhGhVBVEDgiWfxr1uf7aR8G63L0HzPT14egkMyxTOubaiOUcZU47TEHTghux5g==", "d7f78f62-18dc-42b2-9530-b09afd0b1f66" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountedDays",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a59178be-a39f-4def-9ca2-7a51ee7df75b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acd431eabbf",
                column: "ConcurrencyStamp",
                value: "90cd1bf5-ea5e-4ab2-aa63-80bb1803a070");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd54b7f-b7dd-5557-dccb-2bee653eeddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e2cf933-53e9-4bad-8ee6-3b1f7c3eeda3", "AQAAAAEAACcQAAAAEC7UMgOu5ELLtb9Cbc0M3A0h7CpRdyUmFSGLb256YPLB3HlGsWRGTH4eIBJByCPFnQ==", "28ffcf92-5071-43cc-841f-b8c326c38b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8bb-5558-dccb-2cff542ddddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "078c8eab-8606-4838-8c28-4bc3ff23c698", "AQAAAAEAACcQAAAAELTbFzGlprp5u5d7jIjE51mJ7sWEEz8mjY5kCxJg8YwM3PFqcmnburT8ECJZgWG4dQ==", "7e1b8e10-3fba-4166-afb6-5a3015f710b0" });
        }
    }
}

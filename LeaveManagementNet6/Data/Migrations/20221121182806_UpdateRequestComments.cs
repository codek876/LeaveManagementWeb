using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestedComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4d3fda1d-214f-45bd-b95e-0b2eeb44f058");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acd431eabbf",
                column: "ConcurrencyStamp",
                value: "3d823dd4-ae8c-481b-92d1-25a974db110a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd54b7f-b7dd-5557-dccb-2bee653eeddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3ad7c7-d7ab-43b5-9a6c-aa323969ebfc", "AQAAAAEAACcQAAAAEIe9txG+HjW54ZqDQqHsb9653w5wVKWL6KL//JKNqTPXBhJFEEDC9lFj4z2yS70k/Q==", "20c71015-d9d2-4773-a03a-5efd6f273e7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8bb-5558-dccb-2cff542ddddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7529356-7254-4294-80b3-4548d76e6b1a", "AQAAAAEAACcQAAAAEMpauckM+0BCpFybOVWxhnwXjWqA8ful0pZHGHlFxMnOtgqgAvII3gCDsoGy585aXA==", "9fb3e909-48d6-4848-9478-57289a04ebd9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestedComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}

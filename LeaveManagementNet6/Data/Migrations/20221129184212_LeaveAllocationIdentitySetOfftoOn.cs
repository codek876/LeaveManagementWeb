using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class LeaveAllocationIdentitySetOfftoOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2a36373a-4214-4ddf-a274-c53177f5e750");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acd431eabbf",
                column: "ConcurrencyStamp",
                value: "6c8110bd-9041-4522-80c5-2e322924fd32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd54b7f-b7dd-5557-dccb-2bee653eeddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "121cd824-f112-41a7-8157-a313d9c35dca", "AQAAAAEAACcQAAAAENT/yRtL2gm3qyp26yGAr5gtJKixhwwqs9X8tuFSDdfpyL3oM7+mOab/gfJepW2/VA==", "81196b87-f832-4d6b-925a-0be4ac012239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece65c8a-a8bb-5558-dccb-2cff542ddddb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d064e8ba-c664-4edc-93c5-100f9bf3421e", "AQAAAAEAACcQAAAAEJS2PJby/IvVZRw0b55nnDLX41FKSJNk4stfYotO3t8OS3KO2P11NdTv9Y/KjOQEew==", "0a6d095c-f689-42fe-838d-a8e614955aae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

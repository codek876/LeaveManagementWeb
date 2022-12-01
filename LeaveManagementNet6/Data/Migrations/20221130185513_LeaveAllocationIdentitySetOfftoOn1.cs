using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementNet6.Data.Migrations
{
    public partial class LeaveAllocationIdentitySetOfftoOn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

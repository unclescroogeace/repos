using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class AddRoleFieldToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "659c191c-021e-4811-9863-026e476e9795");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "883cd9f0-cfe7-4bc5-a6f4-be134a9e5933");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89653d0a-748b-4c82-ab0b-b86bf322ca21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "924e65d9-8abb-4a12-b474-ecc80c998ff4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d19dd83-6215-4b6d-9a9d-d60855e6a580");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80a1b807-f304-47d2-9370-286a0419a162", "8b831a04-0ddf-4a94-96a1-43c511003a45", "Junior", "JUNIOR" },
                    { "8f8e63f0-00cc-4681-bba5-06a6ba7c0590", "576d2824-5d14-4dbe-b609-45c2de8fdb07", "MidLevel", "MIDLEVEL" },
                    { "7026b5f4-1886-448d-b6fc-0fffc11aa370", "263efc2c-b4ce-4fc2-9d17-fd3e3fd504cf", "Senior", "SENIOR" },
                    { "8d264323-db1d-4bf1-b29e-4c8dfaf29825", "6eb867cb-adc7-436a-9360-2991b975649c", "OfficeSupport", "OFFICESUPPORT" },
                    { "71dd0b87-454a-412f-bc38-26c791549655", "420d224c-73b2-4f23-a372-318a23b211cb", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7026b5f4-1886-448d-b6fc-0fffc11aa370");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71dd0b87-454a-412f-bc38-26c791549655");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a1b807-f304-47d2-9370-286a0419a162");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d264323-db1d-4bf1-b29e-4c8dfaf29825");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f8e63f0-00cc-4681-bba5-06a6ba7c0590");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "883cd9f0-cfe7-4bc5-a6f4-be134a9e5933", "3bbdebdf-d2cc-421d-a029-83f464c37485", "Junior", "JUNIOR" },
                    { "9d19dd83-6215-4b6d-9a9d-d60855e6a580", "995e51be-2691-4dbc-8e22-753037477baf", "MidLevel", "MIDLEVEL" },
                    { "659c191c-021e-4811-9863-026e476e9795", "7923cf6a-7945-43b3-a970-5fe0e5864e4f", "Senior", "SENIOR" },
                    { "89653d0a-748b-4c82-ab0b-b86bf322ca21", "02549bff-9ad8-4517-8e00-c814ec590bb9", "OfficeSupport", "OFFICESUPPORT" },
                    { "924e65d9-8abb-4a12-b474-ecc80c998ff4", "e2cbdade-334e-4fb0-9839-df863a6d1676", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class AddUserIdToTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9039c602-df9b-4ce7-bd7c-bcdb93fc83ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b7547e7-2944-401e-9bf2-0c15f0d67495");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcb22188-05da-4514-85c7-bd6cf77e260b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c185826c-39ac-4f4e-b1c0-be7274d45856");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e173ba74-5a68-4f8e-9cd0-67c62f499f92");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tickets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e173ba74-5a68-4f8e-9cd0-67c62f499f92", "9d137ca8-162c-4721-8d1f-8fc1970007b5", "Junior", "JUNIOR" },
                    { "bcb22188-05da-4514-85c7-bd6cf77e260b", "9b6634ae-9b93-48d1-9682-632b37d869e9", "MidLevel", "MIDLEVEL" },
                    { "9b7547e7-2944-401e-9bf2-0c15f0d67495", "9ba82da4-636c-4f21-a00c-e7ea08687b64", "Senior", "SENIOR" },
                    { "9039c602-df9b-4ce7-bd7c-bcdb93fc83ef", "d82336e5-fa12-4957-a955-b4a345190b2f", "OfficeSupport", "OFFICESUPPORT" },
                    { "c185826c-39ac-4f4e-b1c0-be7274d45856", "5aac9e0c-3877-4f82-9bae-ddb2b443d7b7", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cdab04ab-85e6-4027-b30a-5f9aee8dccf2", "cabc7825-e07e-4e55-9512-25d267797ca2", "Junior", "JUNIOR" },
                    { "42cf7c44-a2fe-42d5-8e0f-61b8e4817de3", "a2df181e-2d9e-4fbb-a633-c8fd61389c1f", "MidLevel", "MIDLEVEL" },
                    { "def91795-da03-48a1-b263-7fe8f29f67f8", "d93fa02b-540f-4cac-9940-4c78ac3e8362", "Senior", "SENIOR" },
                    { "eaf46573-dccc-4bdd-aa4c-4cb861af7c2b", "149bfc10-5bfb-412b-9d72-e614a49f1b43", "OfficeSupport", "OFFICESUPPORT" },
                    { "290ffd67-97a0-4a2d-ae05-eb53f1ac881b", "c37a9a59-456a-4fcc-b110-9450dee444ee", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "290ffd67-97a0-4a2d-ae05-eb53f1ac881b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42cf7c44-a2fe-42d5-8e0f-61b8e4817de3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdab04ab-85e6-4027-b30a-5f9aee8dccf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "def91795-da03-48a1-b263-7fe8f29f67f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaf46573-dccc-4bdd-aa4c-4cb861af7c2b");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class SetPrimaryKeyForTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48b9befc-3082-429f-b6a5-acc911227612");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c003f11a-ecd9-413b-bf2a-c0b1faf8286e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf619a2a-3bc5-4bfe-9dee-da3294814576");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da1fc43e-2238-4863-aa48-2521117108ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2d7f2bc-153e-4096-9d1e-6c3bd8f50926");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cf619a2a-3bc5-4bfe-9dee-da3294814576", "9d30ebbd-c06f-42f6-95ff-711f9ed65b63", "Junior", "JUNIOR" },
                    { "f2d7f2bc-153e-4096-9d1e-6c3bd8f50926", "c9f38bc6-d5cc-47b5-b0d5-70c0618d8eba", "MidLevel", "MIDLEVEL" },
                    { "c003f11a-ecd9-413b-bf2a-c0b1faf8286e", "0916d6f7-12e0-4a1d-be1d-973a3182fb8a", "Senior", "SENIOR" },
                    { "48b9befc-3082-429f-b6a5-acc911227612", "2fab8d0c-dfc7-47ad-bec6-3b4f5d18e16d", "OfficeSupport", "OFFICESUPPORT" },
                    { "da1fc43e-2238-4863-aa48-2521117108ca", "5d04d0f2-9191-4b88-9793-d67b660bc996", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

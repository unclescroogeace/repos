using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class AddTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "007a3adb-0202-4571-a0a5-69e2588f3edb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "011eb09a-a12d-42b6-8a1a-76ee49e05106");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24d62a6a-2651-4964-bdb9-eefbae1a383e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "370bf403-5dff-4816-83d9-2be8bd8b9ef6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec6974e0-968c-4dee-99a1-8629714ff06b");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<int>(type: "int", nullable: false),
                    RefersTo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

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
                    { "ec6974e0-968c-4dee-99a1-8629714ff06b", "2e30284a-5832-4f54-aee8-57f267c6548d", "Junior", "JUNIOR" },
                    { "011eb09a-a12d-42b6-8a1a-76ee49e05106", "71dd3257-31bf-4a74-910f-5d86d3bfaedc", "MidLevel", "MIDLEVEL" },
                    { "007a3adb-0202-4571-a0a5-69e2588f3edb", "9eeb91df-21dc-4f67-a51a-a02fd267daf6", "Senior", "SENIOR" },
                    { "370bf403-5dff-4816-83d9-2be8bd8b9ef6", "17ab41ad-4a1a-4e72-bdeb-a9469630e343", "OfficeSupport", "OFFICESUPPORT" },
                    { "24d62a6a-2651-4964-bdb9-eefbae1a383e", "28a15d16-df00-4f5d-861b-3144bc957786", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

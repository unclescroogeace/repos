using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class AddTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "684aee1e-1c8f-4f95-9f2e-d20a1e1f2969");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fabbd9a-b2f7-420b-8c7a-2bd3c6aa7f49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3a7805-c350-4767-a3c2-d83452ee9b6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c84c9008-2846-4cdb-9bb1-ca1f8806f53f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc0fd55b-9cbe-47a4-a7ff-b620b584f314");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dc0fd55b-9cbe-47a4-a7ff-b620b584f314", "c0fcbe35-1916-45f5-92ec-e5d5f15ba20c", "Junior", "JUNIOR" },
                    { "6fabbd9a-b2f7-420b-8c7a-2bd3c6aa7f49", "406576b1-11fc-4cb4-b1dc-484b11d04c03", "MidLevel", "MIDLEVEL" },
                    { "684aee1e-1c8f-4f95-9f2e-d20a1e1f2969", "2c6719a8-1f98-4ee7-94da-c77a9027cfd5", "Senior", "SENIOR" },
                    { "bc3a7805-c350-4767-a3c2-d83452ee9b6c", "138247b7-87ec-4a19-99ae-d957ea72c1d0", "OfficeSupport", "OFFICESUPPORT" },
                    { "c84c9008-2846-4cdb-9bb1-ca1f8806f53f", "b382cbd3-99b3-432a-bead-601028136511", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

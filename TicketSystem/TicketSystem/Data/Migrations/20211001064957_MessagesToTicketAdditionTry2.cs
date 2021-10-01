using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class MessagesToTicketAdditionTry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "129a195f-580a-49d9-bb99-c627a4ea060b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38ebbb6a-2ddb-4d67-bd4f-1ad280face3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4904d3ea-6dee-4781-b36f-3bf843d2c09e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "965f7e90-5012-4d92-9dae-d16de6e87f30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9a01575-baa2-4302-b323-e7caab153c5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6c38404-2fbd-48f1-8029-f85cc958dc69", "75faecc2-8909-472f-8bd4-8e8afdedd672", "Junior", "JUNIOR" },
                    { "c9d28571-2e00-449e-8cef-3587f898a005", "d27ddc54-b5fe-4c70-9463-6f5f747b902b", "MidLevel", "MIDLEVEL" },
                    { "ab38fd37-5598-4e9f-883a-ff41f8d68e28", "a5a3169a-d0da-4aad-a5c5-94bdae8a7b53", "Senior", "SENIOR" },
                    { "845d49aa-8d6c-4744-96d9-bd2eda392384", "29804c9b-f525-46c6-ae60-8d66a2a8eb3a", "OfficeSupport", "OFFICESUPPORT" },
                    { "277c6800-caee-49fe-ad25-94213a49849f", "6a01b86d-ff00-46d2-9c5c-a39a1be10c01", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277c6800-caee-49fe-ad25-94213a49849f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "845d49aa-8d6c-4744-96d9-bd2eda392384");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab38fd37-5598-4e9f-883a-ff41f8d68e28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6c38404-2fbd-48f1-8029-f85cc958dc69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9d28571-2e00-449e-8cef-3587f898a005");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d9a01575-baa2-4302-b323-e7caab153c5a", "1bd000ca-5528-4fdf-8244-50fec4ed92c9", "Junior", "JUNIOR" },
                    { "38ebbb6a-2ddb-4d67-bd4f-1ad280face3d", "18ed5f02-7aae-471b-ae59-90d999f038aa", "MidLevel", "MIDLEVEL" },
                    { "129a195f-580a-49d9-bb99-c627a4ea060b", "ece3798a-f5cb-4e6e-95e1-a8a6e67cca69", "Senior", "SENIOR" },
                    { "965f7e90-5012-4d92-9dae-d16de6e87f30", "095b10c6-7a91-4786-9431-a9752dd619ba", "OfficeSupport", "OFFICESUPPORT" },
                    { "4904d3ea-6dee-4781-b36f-3bf843d2c09e", "a2679c57-1f46-4b03-b169-4929b82702ea", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

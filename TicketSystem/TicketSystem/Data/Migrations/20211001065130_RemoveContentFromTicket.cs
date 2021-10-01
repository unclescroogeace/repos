using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class RemoveContentFromTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Tickets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fa6d0ef6-058d-454d-96c8-e68f2195c2e2", "7e38d72f-9d05-4e5c-8b59-7d145bea6774", "Junior", "JUNIOR" },
                    { "c2a498a2-8b26-4c80-b133-c26e8a1ff476", "5d5d9b94-beb4-445e-bb9f-badca8ac0649", "MidLevel", "MIDLEVEL" },
                    { "9d62b09d-ff5b-412b-914c-05f9f97a556b", "93d315ab-b9e7-4696-968c-978c6813ca25", "Senior", "SENIOR" },
                    { "2afd9473-f922-4b7d-baca-6776c8d24703", "a42c3280-acee-4323-b34f-1bbd5a7926e1", "OfficeSupport", "OFFICESUPPORT" },
                    { "362206cf-9ac6-426a-b8da-5173989ba6d1", "bd764ef3-922f-4c36-96e1-d0cc5149cbd9", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2afd9473-f922-4b7d-baca-6776c8d24703");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "362206cf-9ac6-426a-b8da-5173989ba6d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d62b09d-ff5b-412b-914c-05f9f97a556b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2a498a2-8b26-4c80-b133-c26e8a1ff476");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa6d0ef6-058d-454d-96c8-e68f2195c2e2");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}

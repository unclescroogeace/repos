using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class AddContentToTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "479a0d9a-e7e4-4e38-9ca2-1b57f66ee09e", "80856189-23a0-4524-bf79-745d850a46d1", "Junior", "JUNIOR" },
                    { "7f09761a-86d5-4fd3-9a55-74c913ab61cd", "20e4703b-309b-4ff7-8c8c-ad4c858ec275", "MidLevel", "MIDLEVEL" },
                    { "9ca418d2-0138-4447-b2a0-ccaebfdaa95f", "2badf86a-0d2d-48dc-bdf1-062ca387d5fd", "Senior", "SENIOR" },
                    { "06872f72-4355-4001-a77c-4e15bdc875fa", "b421a7cf-f4d6-4a09-9800-d589d1007d3f", "OfficeSupport", "OFFICESUPPORT" },
                    { "58600655-70ac-4c5e-a0f0-876d7a91bd4c", "c782e03c-fb49-424a-a343-73ab517c5983", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06872f72-4355-4001-a77c-4e15bdc875fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "479a0d9a-e7e4-4e38-9ca2-1b57f66ee09e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58600655-70ac-4c5e-a0f0-876d7a91bd4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f09761a-86d5-4fd3-9a55-74c913ab61cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ca418d2-0138-4447-b2a0-ccaebfdaa95f");

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
    }
}

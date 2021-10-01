using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class AddSpecifiedSizeForFieldsInTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Tickets",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tickets",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RefersTo",
                table: "Tickets",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Tickets",
                type: "nvarchar(376)",
                maxLength: 376,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cf4bcf5b-641a-4e96-a4e0-2cb97c90fc9a", "7845655d-ae19-4ef0-90b3-68bda0bad457", "Junior", "JUNIOR" },
                    { "35fe1039-aadd-4185-84c4-cefa20699f09", "6205a0b9-1b1a-4ad3-94bf-f8a2c2ad71c5", "MidLevel", "MIDLEVEL" },
                    { "d455238b-169d-4149-8583-70a1bf966418", "7bd3ae95-9eb4-4b16-ba19-2d68979c44da", "Senior", "SENIOR" },
                    { "8bf51abc-632a-4ee9-a7ea-18cabde69e7c", "5fc34952-7a0f-43d6-8612-7d79519a6451", "OfficeSupport", "OFFICESUPPORT" },
                    { "ddafdcec-3caa-47c5-97b3-e1054cb972b1", "39a05b73-270c-4667-9f5e-7bc08c89efc9", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35fe1039-aadd-4185-84c4-cefa20699f09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bf51abc-632a-4ee9-a7ea-18cabde69e7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf4bcf5b-641a-4e96-a4e0-2cb97c90fc9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d455238b-169d-4149-8583-70a1bf966418");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddafdcec-3caa-47c5-97b3-e1054cb972b1");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RefersTo",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(376)",
                oldMaxLength: 376,
                oldNullable: true);

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
    }
}

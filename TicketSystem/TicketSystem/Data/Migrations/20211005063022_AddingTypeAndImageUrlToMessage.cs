using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class AddingTypeAndImageUrlToMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b07b93f-4653-4c18-bac4-4a44c7d404f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fde2dd8-57e6-4b5b-a32e-1e75a6b1d425");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9145bbf5-00a4-4eaa-9ba3-fd1343b3b318");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9471ece3-0869-43a7-83f0-b886868b1a69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7edc2a9-7d53-423c-afab-c4fefe04f37a");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76e5cbf6-c016-4bd3-8c90-756c22012841", "2095b085-f58a-44b4-83f4-b02f87ba2cff", "Junior", "JUNIOR" },
                    { "be28ab09-bc2b-463a-ae3b-547989d2ec53", "0c599fd5-3938-4b40-8e94-f31162193f35", "MidLevel", "MIDLEVEL" },
                    { "f7973e72-acbd-47da-86a0-6e6b1ea0106f", "6d98c9e2-c11a-4eb1-85c1-841c5e770032", "Senior", "SENIOR" },
                    { "991c6f65-f265-42fc-93a6-0db9fa841056", "cc96e139-2646-402d-9045-9fb48a342bca", "OfficeSupport", "OFFICESUPPORT" },
                    { "dd67b4e1-6ae4-48c2-861e-542bafbe2eb1", "2863b46b-35c1-42ca-8e84-ccdf3ecf86ef", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76e5cbf6-c016-4bd3-8c90-756c22012841");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991c6f65-f265-42fc-93a6-0db9fa841056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be28ab09-bc2b-463a-ae3b-547989d2ec53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd67b4e1-6ae4-48c2-861e-542bafbe2eb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7973e72-acbd-47da-86a0-6e6b1ea0106f");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9471ece3-0869-43a7-83f0-b886868b1a69", "12a99714-10fa-4204-af46-29dfc2400fff", "Junior", "JUNIOR" },
                    { "1b07b93f-4653-4c18-bac4-4a44c7d404f6", "cab59e66-8634-41bb-8f17-24c7abf5660f", "MidLevel", "MIDLEVEL" },
                    { "e7edc2a9-7d53-423c-afab-c4fefe04f37a", "e5ed8441-2c00-4679-93e9-95ad4255b2f8", "Senior", "SENIOR" },
                    { "9145bbf5-00a4-4eaa-9ba3-fd1343b3b318", "f5578c9c-7ee5-497b-a62f-5f429c7d283a", "OfficeSupport", "OFFICESUPPORT" },
                    { "6fde2dd8-57e6-4b5b-a32e-1e75a6b1d425", "c61c9189-8c51-461c-96d2-2428c5862956", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

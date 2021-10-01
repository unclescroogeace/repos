using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class MigrationAddDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Tickets_TicketId",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

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

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameIndex(
                name: "IX_Message_TicketId",
                table: "Messages",
                newName: "IX_Messages_TicketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "MessageId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Tickets_TicketId",
                table: "Messages",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Tickets_TicketId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

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

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_TicketId",
                table: "Message",
                newName: "IX_Message_TicketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "MessageId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Tickets_TicketId",
                table: "Message",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

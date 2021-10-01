using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class MessagesToTicketAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7026b5f4-1886-448d-b6fc-0fffc11aa370");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71dd0b87-454a-412f-bc38-26c791549655");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a1b807-f304-47d2-9370-286a0419a162");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d264323-db1d-4bf1-b29e-4c8dfaf29825");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f8e63f0-00cc-4681-bba5-06a6ba7c0590");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Tickets");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Message_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ae38a549-7090-45b6-b62f-ba992f5f6cdd", "dcb8a2e8-ac98-4a8f-8d2f-787b7d12b0e8", "Junior", "JUNIOR" },
                    { "161f4737-f78b-4469-b2f2-031e4efbcc3b", "84a6486a-a2e5-46af-b7ed-c524971cfbcb", "MidLevel", "MIDLEVEL" },
                    { "752a3c43-2a59-4b40-9adf-5d23ae4faf1b", "d3225a07-3ff6-4fac-8798-537af522d5d5", "Senior", "SENIOR" },
                    { "f95078fd-fc59-4a64-82da-b8ac6bd69c07", "a68dbc40-342b-4d27-b30c-c04b8c394eb3", "OfficeSupport", "OFFICESUPPORT" },
                    { "ab88c5a9-5e5b-451a-b7d7-7b2f64e9f720", "5529e4e2-c529-4840-b490-9b532bf30bd3", "TechSupport", "TECHSUPPORT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message_TicketId",
                table: "Message",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "161f4737-f78b-4469-b2f2-031e4efbcc3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "752a3c43-2a59-4b40-9adf-5d23ae4faf1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab88c5a9-5e5b-451a-b7d7-7b2f64e9f720");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae38a549-7090-45b6-b62f-ba992f5f6cdd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f95078fd-fc59-4a64-82da-b8ac6bd69c07");

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
                    { "80a1b807-f304-47d2-9370-286a0419a162", "8b831a04-0ddf-4a94-96a1-43c511003a45", "Junior", "JUNIOR" },
                    { "8f8e63f0-00cc-4681-bba5-06a6ba7c0590", "576d2824-5d14-4dbe-b609-45c2de8fdb07", "MidLevel", "MIDLEVEL" },
                    { "7026b5f4-1886-448d-b6fc-0fffc11aa370", "263efc2c-b4ce-4fc2-9d17-fd3e3fd504cf", "Senior", "SENIOR" },
                    { "8d264323-db1d-4bf1-b29e-4c8dfaf29825", "6eb867cb-adc7-436a-9360-2991b975649c", "OfficeSupport", "OFFICESUPPORT" },
                    { "71dd0b87-454a-412f-bc38-26c791549655", "420d224c-73b2-4f23-a372-318a23b211cb", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

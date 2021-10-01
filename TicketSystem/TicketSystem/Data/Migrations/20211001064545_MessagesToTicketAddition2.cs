using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class MessagesToTicketAddition2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "d9a01575-baa2-4302-b323-e7caab153c5a", "1bd000ca-5528-4fdf-8244-50fec4ed92c9", "Junior", "JUNIOR" },
                    { "38ebbb6a-2ddb-4d67-bd4f-1ad280face3d", "18ed5f02-7aae-471b-ae59-90d999f038aa", "MidLevel", "MIDLEVEL" },
                    { "129a195f-580a-49d9-bb99-c627a4ea060b", "ece3798a-f5cb-4e6e-95e1-a8a6e67cca69", "Senior", "SENIOR" },
                    { "965f7e90-5012-4d92-9dae-d16de6e87f30", "095b10c6-7a91-4786-9431-a9752dd619ba", "OfficeSupport", "OFFICESUPPORT" },
                    { "4904d3ea-6dee-4781-b36f-3bf843d2c09e", "a2679c57-1f46-4b03-b169-4929b82702ea", "TechSupport", "TECHSUPPORT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Tickets");

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
        }
    }
}

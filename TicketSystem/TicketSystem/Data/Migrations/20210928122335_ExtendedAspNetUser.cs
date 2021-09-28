using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Data.Migrations
{
    public partial class ExtendedAspNetUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "290ffd67-97a0-4a2d-ae05-eb53f1ac881b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42cf7c44-a2fe-42d5-8e0f-61b8e4817de3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdab04ab-85e6-4027-b30a-5f9aee8dccf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "def91795-da03-48a1-b263-7fe8f29f67f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaf46573-dccc-4bdd-aa4c-4cb861af7c2b");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cdab04ab-85e6-4027-b30a-5f9aee8dccf2", "cabc7825-e07e-4e55-9512-25d267797ca2", "Junior", "JUNIOR" },
                    { "42cf7c44-a2fe-42d5-8e0f-61b8e4817de3", "a2df181e-2d9e-4fbb-a633-c8fd61389c1f", "MidLevel", "MIDLEVEL" },
                    { "def91795-da03-48a1-b263-7fe8f29f67f8", "d93fa02b-540f-4cac-9940-4c78ac3e8362", "Senior", "SENIOR" },
                    { "eaf46573-dccc-4bdd-aa4c-4cb861af7c2b", "149bfc10-5bfb-412b-9d72-e614a49f1b43", "OfficeSupport", "OFFICESUPPORT" },
                    { "290ffd67-97a0-4a2d-ae05-eb53f1ac881b", "c37a9a59-456a-4fcc-b110-9450dee444ee", "TechSupport", "TECHSUPPORT" }
                });
        }
    }
}

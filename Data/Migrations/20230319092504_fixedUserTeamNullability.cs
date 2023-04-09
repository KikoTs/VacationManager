using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class fixedUserTeamNullability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "301d5e72-ef27-48cb-842d-45529677c015");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4668316a-6b65-4e6f-98c0-7f7e5c6f2364");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b312a1-cb3b-44b9-b616-ad87a2ce090a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a10d4fe0-9151-469d-985e-e94453d1929d");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f4de7f2-62b6-48cb-a85c-c89037ae5041", "23670cc4-4d51-4dd3-aa39-60d3b8db50bb", "Unassigned", null },
                    { "18a74abf-90dc-4295-ba4e-0671e6137918", "d6516fc8-92df-47f7-ae23-f1877cd963e7", "Team Lead", null },
                    { "3676d4af-cef8-4825-994d-33954b06d777", "11773fb4-9f9e-4dd5-b85a-9ab42a7e0003", "CEO", null },
                    { "37638add-a853-4537-aa1a-55473c03a77e", "d1a09706-aff7-479b-8669-a3c9b2e01ec1", "Developer", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f4de7f2-62b6-48cb-a85c-c89037ae5041");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18a74abf-90dc-4295-ba4e-0671e6137918");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3676d4af-cef8-4825-994d-33954b06d777");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37638add-a853-4537-aa1a-55473c03a77e");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "301d5e72-ef27-48cb-842d-45529677c015", "fa9cb4dd-d3a3-43fc-a999-9ff426e39a1e", "Unassigned", null },
                    { "4668316a-6b65-4e6f-98c0-7f7e5c6f2364", "2f4d1d39-bdf8-44d4-bcc4-afd1432c09fe", "Developer", null },
                    { "a0b312a1-cb3b-44b9-b616-ad87a2ce090a", "8122e3d9-c7b9-4f38-b95e-b28861ead60e", "Team Lead", null },
                    { "a10d4fe0-9151-469d-985e-e94453d1929d", "c8ddbfe4-6a05-434b-ba55-35f89dbb6aa5", "CEO", null }
                });
        }
    }
}

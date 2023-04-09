using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class addedHolidayTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b9761e6-ab04-4d39-a949-6abe8ff7033e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e72b57c-0b3e-4c89-83dd-7407e320e119");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e13a42bc-e8be-48b3-affc-2cd8d99b8909");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2995e9e-640a-4716-b961-8e8a4a3004ba");

            migrationBuilder.AddColumn<string>(
                name: "PatientNote",
                table: "Holidays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Holidays",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "PatientNote",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Holidays");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b9761e6-ab04-4d39-a949-6abe8ff7033e", "1df45342-07e7-4acf-8904-9be38871279f", "Unassigned", null },
                    { "8e72b57c-0b3e-4c89-83dd-7407e320e119", "60449ae8-46d9-4111-aa77-5fd8910acb99", "Team Lead", null },
                    { "e13a42bc-e8be-48b3-affc-2cd8d99b8909", "1fd21d8f-efd3-45b0-affa-41ff11dc5442", "Developer", null },
                    { "e2995e9e-640a-4716-b961-8e8a4a3004ba", "9315bc14-d311-45ae-90fa-8c07bd99111f", "CEO", null }
                });
        }
    }
}

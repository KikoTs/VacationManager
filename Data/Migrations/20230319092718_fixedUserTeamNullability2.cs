using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class fixedUserTeamNullability2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67a792e9-bfcd-4226-ad26-758a24596caa", "2c2fee74-129d-4141-b6ec-3c8e73a54608", "Team Lead", null },
                    { "80209b8b-971a-4ea5-88fe-f9bdf54e6b9e", "4729e14a-ea79-42ab-a29d-f94d2e645c1d", "Unassigned", null },
                    { "eefa7030-f0bf-4ffa-a72a-1bf1aa40dd50", "ba6799ed-5163-4c1a-be66-f52465b8e77b", "CEO", null },
                    { "f0e7a80b-b20e-455c-b058-75b09ca8b5d0", "bfcd62a1-5917-4c83-b4c8-9f6cea624569", "Developer", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67a792e9-bfcd-4226-ad26-758a24596caa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80209b8b-971a-4ea5-88fe-f9bdf54e6b9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eefa7030-f0bf-4ffa-a72a-1bf1aa40dd50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0e7a80b-b20e-455c-b058-75b09ca8b5d0");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
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
    }
}

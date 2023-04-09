using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class RemovedTeamProjectStrictConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

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
                name: "ProjectId",
                table: "Teams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "088af96b-8df0-4899-8c4f-b3df531d1590", "b86154d9-3337-4a20-bac2-0b17e73b0b1e", "Unassigned", null },
                    { "825204ae-a317-41e9-87eb-ef35014c2fd3", "e29a584e-8c2a-4a3a-95de-3b9a715de042", "Team Lead", null },
                    { "99f0f5d3-a942-49ad-878a-235fb285bd36", "45830f25-cc7a-40ed-a75f-ed33872627b4", "Developer", null },
                    { "e3bd2238-5672-406b-b6bb-7d695e873e20", "9c76a07b-9858-41f5-8b88-5475850fa6a7", "CEO", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "088af96b-8df0-4899-8c4f-b3df531d1590");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "825204ae-a317-41e9-87eb-ef35014c2fd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99f0f5d3-a942-49ad-878a-235fb285bd36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3bd2238-5672-406b-b6bb-7d695e873e20");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Teams",
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
                    { "67a792e9-bfcd-4226-ad26-758a24596caa", "2c2fee74-129d-4141-b6ec-3c8e73a54608", "Team Lead", null },
                    { "80209b8b-971a-4ea5-88fe-f9bdf54e6b9e", "4729e14a-ea79-42ab-a29d-f94d2e645c1d", "Unassigned", null },
                    { "eefa7030-f0bf-4ffa-a72a-1bf1aa40dd50", "ba6799ed-5163-4c1a-be66-f52465b8e77b", "CEO", null },
                    { "f0e7a80b-b20e-455c-b058-75b09ca8b5d0", "bfcd62a1-5917-4c83-b4c8-9f6cea624569", "Developer", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

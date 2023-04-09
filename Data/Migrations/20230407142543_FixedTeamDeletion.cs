using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class FixedTeamDeletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fcce6c1-9529-4bec-82ff-f6e1874f67e9", "1c7ab240-de7d-4829-b8ed-18914bb75c8c", "Developer", null },
                    { "b032e1f3-302d-4347-b005-1f6f26cb9b06", "ac9344aa-29f1-48dc-85a6-424f372e5159", "Team Lead", null },
                    { "c143bff1-7425-41b7-a78d-b12d713b4f9b", "6d38db46-a7a1-43fc-bc13-6a7f43c09262", "Unassigned", null },
                    { "fd8c0f83-d3a2-44da-b8bd-090a39db315b", "d636cdb8-5f21-44aa-bf27-60e527cb6661", "CEO", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fcce6c1-9529-4bec-82ff-f6e1874f67e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b032e1f3-302d-4347-b005-1f6f26cb9b06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c143bff1-7425-41b7-a78d-b12d713b4f9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd8c0f83-d3a2-44da-b8bd-090a39db315b");

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
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}

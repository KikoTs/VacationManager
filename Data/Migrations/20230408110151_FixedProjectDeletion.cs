using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class FixedProjectDeletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

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
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}

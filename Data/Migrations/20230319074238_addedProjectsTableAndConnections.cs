using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class addedProjectsTableAndConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_AspNetUsers_LeaderId1",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LeaderId1",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26ffdc65-1c3d-4dc3-8005-dc8d062a2def");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e119dae-60d9-4311-8db8-b472ca40f23f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be3c0c6e-22b9-4472-b766-4689845dbfd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcff6d3b-dd11-4f63-8af9-8d65a1dad12d");

            migrationBuilder.DropColumn(
                name: "LeaderId1",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamLedId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "481e9326-ebc3-4b09-b90f-9932e411cf9d", "a972173c-cc60-47ab-8c60-cd91f6a74ce6", "CEO", null },
                    { "568fbee6-b24c-4a20-b042-28dc822ef3ae", "cfd9eb9c-0da0-43bf-a09a-76a044b5baaa", "Unassigned", null },
                    { "e1295894-7290-4197-aebd-123fe790d6c5", "cce9b480-95b9-457f-8b98-ad8572b31642", "Developer", null },
                    { "e5e80295-f8e4-4999-b8cf-987045170b53", "4563f1a0-1e78-4e0a-a686-b3e61ffdc805", "Team Lead", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TeamLedId",
                table: "AspNetUsers",
                column: "TeamLedId",
                unique: true,
                filter: "[TeamLedId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Teams_TeamLedId",
                table: "AspNetUsers",
                column: "TeamLedId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Teams_TeamLedId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TeamLedId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "481e9326-ebc3-4b09-b90f-9932e411cf9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "568fbee6-b24c-4a20-b042-28dc822ef3ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1295894-7290-4197-aebd-123fe790d6c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5e80295-f8e4-4999-b8cf-987045170b53");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamLedId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "LeaderId1",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26ffdc65-1c3d-4dc3-8005-dc8d062a2def", "b5b97c05-5434-4f8d-990f-f43f6cb7bb96", "Developer", null },
                    { "9e119dae-60d9-4311-8db8-b472ca40f23f", "c041f3c6-5bff-42a9-84ce-c252d3d26553", "Unassigned", null },
                    { "be3c0c6e-22b9-4472-b766-4689845dbfd3", "9333fc53-115b-4ba6-ae90-06d8e0b39ff8", "CEO", null },
                    { "fcff6d3b-dd11-4f63-8af9-8d65a1dad12d", "a97fdb9f-3b1f-48b2-9049-e0e257f3e4be", "Team Lead", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeaderId1",
                table: "Teams",
                column: "LeaderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_AspNetUsers_LeaderId1",
                table: "Teams",
                column: "LeaderId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

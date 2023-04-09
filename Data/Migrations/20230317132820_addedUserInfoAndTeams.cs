using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class addedUserInfoAndTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaderId1 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_AspNetUsers_LeaderId1",
                        column: x => x.LeaderId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AspNetUsers_TeamId",
                table: "AspNetUsers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeaderId1",
                table: "Teams",
                column: "LeaderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TeamId",
                table: "AspNetUsers");

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
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "AspNetUsers");
        }
    }
}

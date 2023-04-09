using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class addedHolidaysTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    DateOfRequest = table.Column<DateTime>(type: "date", nullable: false),
                    IsHalfDay = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    RequesterId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holidays_AspNetUsers_RequesterId",
                        column: x => x.RequesterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_RequesterId",
                table: "Holidays",
                column: "RequesterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holidays");

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
        }
    }
}

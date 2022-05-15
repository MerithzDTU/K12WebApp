using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class NewUserChores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChoreMonthsUsers");

            migrationBuilder.CreateTable(
                name: "UserChores",
                columns: table => new
                {
                    AssignedRoomNo = table.Column<int>(type: "int", nullable: false),
                    ChoreMonthId = table.Column<int>(type: "int", nullable: false),
                    AssignedUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChores", x => new { x.AssignedRoomNo, x.ChoreMonthId });
                    table.ForeignKey(
                        name: "FK_UserChores_ChoreMonths_ChoreMonthId",
                        column: x => x.ChoreMonthId,
                        principalTable: "ChoreMonths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChores_Users_AssignedUserId",
                        column: x => x.AssignedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 17, 24, 17, 368, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 17, 24, 17, 368, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 17, 24, 17, 368, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 17, 24, 17, 368, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.InsertData(
                table: "UserChores",
                columns: new[] { "AssignedRoomNo", "ChoreMonthId", "AssignedUserId" },
                values: new object[,]
                {
                    { 1340, 38, null },
                    { 1341, 50, null },
                    { 1343, 4, null },
                    { 1343, 62, null },
                    { 1344, 74, null },
                    { 1345, 86, null },
                    { 1346, 98, null },
                    { 1349, 2, null },
                    { 1350, 14, null },
                    { 1351, 14, null },
                    { 1353, 3, null },
                    { 1353, 26, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserChores_AssignedUserId",
                table: "UserChores",
                column: "AssignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChores_ChoreMonthId",
                table: "UserChores",
                column: "ChoreMonthId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserChores");

            migrationBuilder.CreateTable(
                name: "ChoreMonthsUsers",
                columns: table => new
                {
                    AssignedRoomNo = table.Column<int>(type: "int", nullable: false),
                    ChoreMonthId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChoreMonthsUsers", x => new { x.AssignedRoomNo, x.ChoreMonthId });
                    table.ForeignKey(
                        name: "FK_ChoreMonthsUsers_ChoreMonths_ChoreMonthId",
                        column: x => x.ChoreMonthId,
                        principalTable: "ChoreMonths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChoreMonthsUsers_Users_AssignedRoomNo",
                        column: x => x.AssignedRoomNo,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChoreMonthsUsers",
                columns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                values: new object[,]
                {
                    { 1340, 38 },
                    { 1341, 50 },
                    { 1343, 4 },
                    { 1343, 62 },
                    { 1344, 74 },
                    { 1345, 86 },
                    { 1346, 98 },
                    { 1349, 2 },
                    { 1350, 14 },
                    { 1351, 14 },
                    { 1353, 3 },
                    { 1353, 26 }
                });

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 16, 1, 54, 258, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 16, 1, 54, 258, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 16, 1, 54, 258, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 16, 1, 54, 258, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.CreateIndex(
                name: "IX_ChoreMonthsUsers_ChoreMonthId",
                table: "ChoreMonthsUsers",
                column: "ChoreMonthId");
        }
    }
}

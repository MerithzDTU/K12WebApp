using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class UpdatedCMURelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChoreMonthUser");

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
                        principalColumn: "RoomNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 14, 26, 8, 816, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 14, 26, 8, 816, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 14, 26, 8, 816, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 14, 26, 8, 816, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.CreateIndex(
                name: "IX_ChoreMonthsUsers_ChoreMonthId",
                table: "ChoreMonthsUsers",
                column: "ChoreMonthId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChoreMonthsUsers");

            migrationBuilder.CreateTable(
                name: "ChoreMonthUser",
                columns: table => new
                {
                    AssignedUsersId = table.Column<int>(type: "int", nullable: false),
                    ChoreMonthsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChoreMonthUser", x => new { x.AssignedUsersId, x.ChoreMonthsId });
                    table.ForeignKey(
                        name: "FK_ChoreMonthUser_ChoreMonths_ChoreMonthsId",
                        column: x => x.ChoreMonthsId,
                        principalTable: "ChoreMonths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChoreMonthUser_Users_AssignedUsersId",
                        column: x => x.AssignedUsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 52, 148, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 52, 148, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 52, 148, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 7, 15, 2, 52, 148, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.CreateIndex(
                name: "IX_ChoreMonthUser_ChoreMonthsId",
                table: "ChoreMonthUser",
                column: "ChoreMonthsId");
        }
    }
}

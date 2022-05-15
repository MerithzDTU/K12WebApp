using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class AssignedUsersNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChoreMonthUser_Users_AssignedUserId",
                table: "ChoreMonthUser");

            migrationBuilder.RenameColumn(
                name: "AssignedUserId",
                table: "ChoreMonthUser",
                newName: "AssignedUsersId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ChoreMonthUser_Users_AssignedUsersId",
                table: "ChoreMonthUser",
                column: "AssignedUsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChoreMonthUser_Users_AssignedUsersId",
                table: "ChoreMonthUser");

            migrationBuilder.RenameColumn(
                name: "AssignedUsersId",
                table: "ChoreMonthUser",
                newName: "AssignedUserId");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.AddForeignKey(
                name: "FK_ChoreMonthUser_Users_AssignedUserId",
                table: "ChoreMonthUser",
                column: "AssignedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

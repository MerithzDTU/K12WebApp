using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class NewRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserChores_Users_AssignedUserId",
                table: "UserChores");

            migrationBuilder.DropIndex(
                name: "IX_UserChores_AssignedUserId",
                table: "UserChores");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "UserChores");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 20, 21, 12, 641, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 20, 21, 12, 641, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 20, 21, 12, 641, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 10, 20, 21, 12, 641, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.AddForeignKey(
                name: "FK_UserChores_Users_AssignedRoomNo",
                table: "UserChores",
                column: "AssignedRoomNo",
                principalTable: "Users",
                principalColumn: "RoomNo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserChores_Users_AssignedRoomNo",
                table: "UserChores");

            migrationBuilder.AddColumn<int>(
                name: "AssignedUserId",
                table: "UserChores",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 23, 2, 18, 131, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 23, 2, 18, 131, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 23, 2, 18, 131, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 23, 2, 18, 131, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.CreateIndex(
                name: "IX_UserChores_AssignedUserId",
                table: "UserChores",
                column: "AssignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserChores_Users_AssignedUserId",
                table: "UserChores",
                column: "AssignedUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}

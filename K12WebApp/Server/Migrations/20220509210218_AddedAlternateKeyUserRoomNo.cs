using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class AddedAlternateKeyUserRoomNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_RoomNo",
                table: "Users");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_RoomNo",
                table: "Users",
                column: "RoomNo");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_RoomNo",
                table: "Users");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoomNo",
                table: "Users",
                column: "RoomNo",
                unique: true);
        }
    }
}

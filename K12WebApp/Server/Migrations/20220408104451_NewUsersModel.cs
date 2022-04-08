using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class NewUsersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 8, 12, 44, 50, 916, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 4, 8, 12, 44, 50, 916, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 4, 8, 12, 44, 50, 916, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 4, 8, 12, 44, 50, 916, DateTimeKind.Local).AddTicks(7053));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6769));
        }
    }
}

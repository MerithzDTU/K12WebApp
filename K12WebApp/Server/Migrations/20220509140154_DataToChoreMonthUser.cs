using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class DataToChoreMonthUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1340, 38 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1341, 50 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1343, 4 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1343, 62 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1344, 74 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1345, 86 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1346, 98 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1349, 2 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1350, 14 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1351, 14 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1353, 3 });

            migrationBuilder.DeleteData(
                table: "ChoreMonthsUsers",
                keyColumns: new[] { "AssignedRoomNo", "ChoreMonthId" },
                keyValues: new object[] { 1353, 26 });

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
        }
    }
}

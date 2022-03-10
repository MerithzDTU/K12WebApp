using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class Groceries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groceries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroceryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isBought = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groceries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groceries_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "Id", "CreatedByUserId", "DateCreated", "GroceryName", "LastUpdated", "isBought" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6734), "Løg", null, false },
                    { 2, 1, new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6765), "Hvidløg", null, false },
                    { 3, 1, new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6767), "Affaldsposer", null, false },
                    { 4, 1, new DateTime(2022, 3, 9, 21, 32, 44, 448, DateTimeKind.Local).AddTicks(6769), "Karry", null, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groceries_CreatedByUserId",
                table: "Groceries",
                column: "CreatedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groceries");
        }
    }
}

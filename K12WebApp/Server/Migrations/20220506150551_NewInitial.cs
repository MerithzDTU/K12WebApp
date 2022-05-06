using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class NewInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChoreMonths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChoreMonths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChoreMonths_Chores_ChoreId",
                        column: x => x.ChoreId,
                        principalTable: "Chores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNo = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChoreMonthUser",
                columns: table => new
                {
                    AssignedUserId = table.Column<int>(type: "int", nullable: false),
                    ChoreMonthsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChoreMonthUser", x => new { x.AssignedUserId, x.ChoreMonthsId });
                    table.ForeignKey(
                        name: "FK_ChoreMonthUser_ChoreMonths_ChoreMonthsId",
                        column: x => x.ChoreMonthsId,
                        principalTable: "ChoreMonths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChoreMonthUser_Users_AssignedUserId",
                        column: x => x.AssignedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Chores",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Tjanse-tjekker" },
                    { 2, "", "Affalds-sortering" },
                    { 3, "", "Krydderihylde, emhætter og skuffer" },
                    { 4, "", "Ovn/komfur ved dør" },
                    { 5, "", "Altan og pant" },
                    { 6, "", "Alm. og grønskraldespand" },
                    { 7, "", "Ovn/komfur ved stuen" },
                    { 8, "", "Rydde op, tørre af og støvsuge" },
                    { 9, "", "Buffer" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Køkken Ansvarlig" },
                    { 3, "Køkken Beboer" },
                    { 4, "Tjanse Tjekker" },
                    { 5, "Køkken Kasserer" }
                });

            migrationBuilder.InsertData(
                table: "ChoreMonths",
                columns: new[] { "Id", "ChoreId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "januar" },
                    { 2, 1, "februar" },
                    { 3, 1, "marts" },
                    { 4, 1, "april" },
                    { 5, 1, "maj" },
                    { 6, 1, "juni" },
                    { 7, 1, "juli" },
                    { 8, 1, "august" },
                    { 9, 1, "september" },
                    { 10, 1, "october" },
                    { 11, 1, "november" },
                    { 12, 1, "december" },
                    { 13, 2, "januar" },
                    { 14, 2, "februar" },
                    { 15, 2, "marts" },
                    { 16, 2, "april" },
                    { 17, 2, "maj" },
                    { 18, 2, "juni" },
                    { 19, 2, "juli" },
                    { 20, 2, "august" },
                    { 21, 2, "september" },
                    { 22, 2, "october" },
                    { 23, 2, "november" },
                    { 24, 2, "december" },
                    { 25, 3, "januar" },
                    { 26, 3, "februar" },
                    { 27, 3, "marts" },
                    { 28, 3, "april" },
                    { 29, 3, "maj" },
                    { 30, 3, "juni" },
                    { 31, 3, "juli" },
                    { 32, 3, "august" },
                    { 33, 3, "september" },
                    { 34, 3, "october" },
                    { 35, 3, "november" },
                    { 36, 3, "december" },
                    { 37, 4, "januar" },
                    { 38, 4, "februar" },
                    { 39, 4, "marts" },
                    { 40, 4, "april" },
                    { 41, 4, "maj" },
                    { 42, 4, "juni" }
                });

            migrationBuilder.InsertData(
                table: "ChoreMonths",
                columns: new[] { "Id", "ChoreId", "Name" },
                values: new object[,]
                {
                    { 43, 4, "juli" },
                    { 44, 4, "august" },
                    { 45, 4, "september" },
                    { 46, 4, "october" },
                    { 47, 4, "november" },
                    { 48, 4, "december" },
                    { 49, 5, "januar" },
                    { 50, 5, "februar" },
                    { 51, 5, "marts" },
                    { 52, 5, "april" },
                    { 53, 5, "maj" },
                    { 54, 5, "juni" },
                    { 55, 5, "juli" },
                    { 56, 5, "august" },
                    { 57, 5, "september" },
                    { 58, 5, "october" },
                    { 59, 5, "november" },
                    { 60, 5, "december" },
                    { 61, 6, "januar" },
                    { 62, 6, "februar" },
                    { 63, 6, "marts" },
                    { 64, 6, "april" },
                    { 65, 6, "maj" },
                    { 66, 6, "juni" },
                    { 67, 6, "juli" },
                    { 68, 6, "august" },
                    { 69, 6, "september" },
                    { 70, 6, "october" },
                    { 71, 6, "november" },
                    { 72, 6, "december" },
                    { 73, 7, "januar" },
                    { 74, 7, "februar" },
                    { 75, 7, "marts" },
                    { 76, 7, "april" },
                    { 77, 7, "maj" },
                    { 78, 7, "juni" },
                    { 79, 7, "juli" },
                    { 80, 7, "august" },
                    { 81, 7, "september" },
                    { 82, 7, "october" },
                    { 83, 7, "november" },
                    { 84, 7, "december" }
                });

            migrationBuilder.InsertData(
                table: "ChoreMonths",
                columns: new[] { "Id", "ChoreId", "Name" },
                values: new object[,]
                {
                    { 85, 8, "januar" },
                    { 86, 8, "februar" },
                    { 87, 8, "marts" },
                    { 88, 8, "april" },
                    { 89, 8, "maj" },
                    { 90, 8, "juni" },
                    { 91, 8, "juli" },
                    { 92, 8, "august" },
                    { 93, 8, "september" },
                    { 94, 8, "october" },
                    { 95, 8, "november" },
                    { 96, 8, "december" },
                    { 97, 9, "januar" },
                    { 98, 9, "februar" },
                    { 99, 9, "marts" },
                    { 100, 9, "april" },
                    { 101, 9, "maj" },
                    { 102, 9, "juni" },
                    { 103, 9, "juli" },
                    { 104, 9, "august" },
                    { 105, 9, "september" },
                    { 106, 9, "october" },
                    { 107, 9, "november" },
                    { 108, 9, "december" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "NickName", "PasswordHash", "PasswordSalt", "RoleId", "RoomNo" },
                values: new object[,]
                {
                    { 1, "", "Christian", "Merithz Uhrenfeldt Nielsen", "Krølle", null, null, 1, 1350 },
                    { 2, "", "Joey", "Knutsson", "Joey", null, null, 2, 1340 },
                    { 3, "", "Emma", "Rosa", "Ems", null, null, 3, 1347 },
                    { 4, "", "Kasper", "Djælund Nyberg", "Guffe", null, null, 3, 1345 },
                    { 5, "", "Daniel", "Katz", "Danniboi", null, null, 3, 1344 },
                    { 6, "", "Andreas", "Ven", "Venno", null, null, 3, 1349 },
                    { 7, "", "Lynge", "Moustgaard", "LyngLyng", null, null, 3, 1351 },
                    { 8, "", "Lucas", "Zacho", "Peter", null, null, 3, 1343 },
                    { 9, "", "Nicolai", "Toft", "Nico", null, null, 3, 1348 },
                    { 10, "", "Anastasia", "Jakobsen", "Anastasia", null, null, 3, 1346 },
                    { 11, "", "Eva", "Sand Larsen", "Eva", null, null, 5, 1341 },
                    { 12, "", "Ahmad", "Mazrah", "Ahmad", null, null, 3, 1353 }
                });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "Id", "CreatedByUserId", "DateCreated", "GroceryName", "LastUpdated", "isBought" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7464), "Løg", null, false },
                    { 2, 1, new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7496), "Hvidløg", null, false },
                    { 3, 1, new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7498), "Affaldsposer", null, false },
                    { 4, 1, new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7500), "Karry", null, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChoreMonths_ChoreId",
                table: "ChoreMonths",
                column: "ChoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ChoreMonthUser_ChoreMonthsId",
                table: "ChoreMonthUser",
                column: "ChoreMonthsId");

            migrationBuilder.CreateIndex(
                name: "IX_Groceries_CreatedByUserId",
                table: "Groceries",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoomNo",
                table: "Users",
                column: "RoomNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChoreMonthUser");

            migrationBuilder.DropTable(
                name: "Groceries");

            migrationBuilder.DropTable(
                name: "ChoreMonths");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Chores");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}

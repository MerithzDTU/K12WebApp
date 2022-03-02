using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "NickName", "RoleId" },
                values: new object[,]
                {
                    { 1, "Christian", "Merithz Uhrenfeldt Nielsen", "Krølle", 1 },
                    { 2, "Joey", "Knutsson", "Joey", 2 },
                    { 3, "Emma", "Rosa", "Ems", 3 },
                    { 4, "Kasper", "Djælund Nyberg", "Guffe", 3 },
                    { 5, "Daniel", "Katz", "Danniboi", 3 },
                    { 6, "Andreas", "Ven", "Venno", 3 },
                    { 7, "Lynge", "Moustgaard", "LyngLyng", 3 },
                    { 8, "Lucas", "Zacho", "Peter", 3 },
                    { 9, "Nicolai", "Toft", "Nico", 3 },
                    { 10, "Anastasia", "Jakobsen", "Anastasia", 3 },
                    { 11, "Eva", "Sand Larsen", "Eva", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}

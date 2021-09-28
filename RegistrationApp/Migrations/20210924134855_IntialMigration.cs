using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationApp.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "mstClient",
                schema: "dbo",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ClientCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ClientIsActive = table.Column<bool>(type: "bit", nullable: false),
                    ClientCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mstClient", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "mstUsersDetail",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FavoriteFootBallTeam = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mstUsersDetail", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_mstUsersDetail_mstClient_ClientID",
                        column: x => x.ClientID,
                        principalSchema: "dbo",
                        principalTable: "mstClient",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "mstClient",
                columns: new[] { "ClientId", "ClientCode", "ClientCreatedOn", "ClientDesc", "ClientIsActive", "ClientModifiedOn", "ClientName" },
                values: new object[] { 1, "MrGreen", new DateTime(2021, 9, 24, 19, 18, 55, 166, DateTimeKind.Local).AddTicks(880), "Mr Green", true, null, "Mr Green" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "mstClient",
                columns: new[] { "ClientId", "ClientCode", "ClientCreatedOn", "ClientDesc", "ClientIsActive", "ClientModifiedOn", "ClientName" },
                values: new object[] { 2, "RedBat", new DateTime(2021, 9, 24, 19, 18, 55, 167, DateTimeKind.Local).AddTicks(818), "Red Bat", true, null, "Red Bat" });

            migrationBuilder.CreateIndex(
                name: "IX_mstUsersDetail_ClientID",
                schema: "dbo",
                table: "mstUsersDetail",
                column: "ClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mstUsersDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "mstClient",
                schema: "dbo");
        }
    }
}

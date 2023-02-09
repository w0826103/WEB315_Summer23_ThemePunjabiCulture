using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB315_Summer23_ThemePunjabiCulture.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PunjabiCulture",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CultureName = table.Column<string>(type: "TEXT", nullable: true),
                    OccassionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Costume = table.Column<string>(type: "TEXT", nullable: true),
                    Food = table.Column<string>(type: "TEXT", nullable: true),
                    OrganisedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PunjabiCulture", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PunjabiCulture");
        }
    }
}

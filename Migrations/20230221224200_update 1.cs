using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB315_Summer23_ThemePunjabiCulture.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DaysOfCelebration",
                table: "PunjabiCulture",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OriginCity",
                table: "PunjabiCulture",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysOfCelebration",
                table: "PunjabiCulture");

            migrationBuilder.DropColumn(
                name: "OriginCity",
                table: "PunjabiCulture");
        }
    }
}

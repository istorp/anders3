using Microsoft.EntityFrameworkCore.Migrations;

namespace anders3.Migrations
{
    public partial class error : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Samage",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "Damage",
                table: "Skills",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Damage",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "Samage",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class newSkillLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SkillLevel");

            migrationBuilder.AddColumn<string>(
                name: "AgeGroup",
                table: "SkillLevel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Division",
                table: "SkillLevel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "SkillLevel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "SkillLevel");

            migrationBuilder.DropColumn(
                name: "Division",
                table: "SkillLevel");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "SkillLevel");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SkillLevel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

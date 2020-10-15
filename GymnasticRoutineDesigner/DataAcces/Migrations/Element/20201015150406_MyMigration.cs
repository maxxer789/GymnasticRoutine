using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations.Element
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApparatusDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApparatusDTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillGroupDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ApparatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillGroupDTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillGroupDTO_ApparatusDTO_ApparatusId",
                        column: x => x.ApparatusId,
                        principalTable: "ApparatusDTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Difficulty = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    Worth = table.Column<decimal>(type: "decimal(1,1)", nullable: false),
                    SkillGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Element", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Element_SkillGroupDTO_SkillGroupId",
                        column: x => x.SkillGroupId,
                        principalTable: "SkillGroupDTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Element_SkillGroupId",
                table: "Element",
                column: "SkillGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillGroupDTO_ApparatusId",
                table: "SkillGroupDTO",
                column: "ApparatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropTable(
                name: "SkillGroupDTO");

            migrationBuilder.DropTable(
                name: "ApparatusDTO");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apparatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apparatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillLevel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ApparatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillGroup_Apparatus_ApparatusId",
                        column: x => x.ApparatusId,
                        principalTable: "Apparatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Worth = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ApparatusId = table.Column<int>(nullable: false),
                    SkillLevelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routine_Apparatus_ApparatusId",
                        column: x => x.ApparatusId,
                        principalTable: "Apparatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Routine_SkillLevel_SkillLevelId",
                        column: x => x.SkillLevelId,
                        principalTable: "SkillLevel",
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
                        name: "FK_Element_SkillGroup_SkillGroupId",
                        column: x => x.SkillGroupId,
                        principalTable: "SkillGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoutineElement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoutineId = table.Column<int>(nullable: false),
                    ElementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutineElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoutineElement_Element_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Element",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutineElement_Routine_RoutineId",
                        column: x => x.RoutineId,
                        principalTable: "Routine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Element_SkillGroupId",
                table: "Element",
                column: "SkillGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Routine_ApparatusId",
                table: "Routine",
                column: "ApparatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Routine_SkillLevelId",
                table: "Routine",
                column: "SkillLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutineElement_ElementId",
                table: "RoutineElement",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutineElement_RoutineId",
                table: "RoutineElement",
                column: "RoutineId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillGroup_ApparatusId",
                table: "SkillGroup",
                column: "ApparatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoutineElement");

            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropTable(
                name: "Routine");

            migrationBuilder.DropTable(
                name: "SkillGroup");

            migrationBuilder.DropTable(
                name: "SkillLevel");

            migrationBuilder.DropTable(
                name: "Apparatus");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Labont_Dumitru_Proiect.Migrations
{
    public partial class Nota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValoareNota = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nota_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nota_StudentID",
                table: "Nota",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nota");
        }
    }
}

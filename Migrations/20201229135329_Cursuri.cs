using Microsoft.EntityFrameworkCore.Migrations;

namespace Labont_Dumitru_Proiect.Migrations
{
    public partial class Cursuri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(nullable: true),
                    ProfesorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Curs_Profesor_ProfesorID",
                        column: x => x.ProfesorID,
                        principalTable: "Profesor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curs_ProfesorID",
                table: "Curs",
                column: "ProfesorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curs");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Labont_Dumitru_Proiect.Migrations
{
    public partial class Profesori2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "Profesor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "Profesor");
        }
    }
}

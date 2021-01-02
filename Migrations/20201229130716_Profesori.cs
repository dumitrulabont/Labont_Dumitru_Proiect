using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labont_Dumitru_Proiect.Migrations
{
    public partial class Profesori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    DataNasteri = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesor");
        }
    }
}

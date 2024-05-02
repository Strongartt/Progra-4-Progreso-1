using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Progra_4_Progreso_1.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    Idcarrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_carrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    campus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_semestre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.Idcarrera);
                });

            migrationBuilder.CreateTable(
                name: "Ricardo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calificacion = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    EstadoFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idcarrera = table.Column<int>(type: "int", nullable: false),
                    CarreraIdcarrera = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ricardo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ricardo_Carrera_CarreraIdcarrera",
                        column: x => x.CarreraIdcarrera,
                        principalTable: "Carrera",
                        principalColumn: "Idcarrera",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ricardo_CarreraIdcarrera",
                table: "Ricardo",
                column: "CarreraIdcarrera");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ricardo");

            migrationBuilder.DropTable(
                name: "Carrera");
        }
    }
}

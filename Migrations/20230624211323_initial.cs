using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiReparacion.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reparacion",
                columns: table => new
                {
                    idReparacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reparacion", x => x.idReparacion);
                });

            migrationBuilder.CreateTable(
                name: "detalleReparacion",
                columns: table => new
                {
                    idDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    precioUnitario = table.Column<double>(type: "float", nullable: false),
                    igv = table.Column<double>(type: "float", nullable: false),
                    subtotal = table.Column<double>(type: "float", nullable: false),
                    reparacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleReparacion", x => x.idDetalle);
                    table.ForeignKey(
                        name: "FK_detalleReparacion_reparacion_reparacionId",
                        column: x => x.reparacionId,
                        principalTable: "reparacion",
                        principalColumn: "idReparacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalleReparacion_reparacionId",
                table: "detalleReparacion",
                column: "reparacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleReparacion");

            migrationBuilder.DropTable(
                name: "reparacion");
        }
    }
}

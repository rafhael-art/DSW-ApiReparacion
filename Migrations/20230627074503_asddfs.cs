using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiReparacion.Migrations
{
    public partial class asddfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "clienteId",
                table: "reparacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clienteId",
                table: "reparacion");
        }
    }
}

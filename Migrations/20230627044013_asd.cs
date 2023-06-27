using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiReparacion.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "numero",
                table: "reparacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numero",
                table: "reparacion");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCPrimerEjemplo.Migrations
{
    public partial class Cinemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumbertOfRooms",
                table: "Cinema",
                newName: "NumberOfRooms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfRooms",
                table: "Cinema",
                newName: "NumbertOfRooms");
        }
    }
}

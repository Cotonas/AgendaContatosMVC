using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaContatosMVC.Migrations
{
    public partial class Foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Contact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoneId",
                table: "Contact",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "FoneId",
                table: "Contact");
        }
    }
}

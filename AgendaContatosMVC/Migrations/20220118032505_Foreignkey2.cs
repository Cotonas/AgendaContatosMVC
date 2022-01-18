using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaContatosMVC.Migrations
{
    public partial class Foreignkey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Contact_ContactId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Fone_Contact_ContactId",
                table: "Fone");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "FoneId",
                table: "Contact");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Fone",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Endereco",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Contact_ContactId",
                table: "Endereco",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fone_Contact_ContactId",
                table: "Fone",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Contact_ContactId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Fone_Contact_ContactId",
                table: "Fone");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Fone",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Contact_ContactId",
                table: "Endereco",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fone_Contact_ContactId",
                table: "Fone",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

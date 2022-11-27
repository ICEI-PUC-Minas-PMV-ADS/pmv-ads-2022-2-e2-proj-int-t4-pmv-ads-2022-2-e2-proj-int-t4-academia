using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_web_backend.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "repeteSenha",
                table: "Usuarios",
                newName: "RepeteSenha");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RepeteSenha",
                table: "Usuarios",
                newName: "repeteSenha");
        }
    }
}

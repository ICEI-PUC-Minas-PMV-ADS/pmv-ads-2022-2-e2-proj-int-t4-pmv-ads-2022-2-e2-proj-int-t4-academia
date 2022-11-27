using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_web_backend.Migrations
{
    public partial class M01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "repeteSenha",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "repeteSenha",
                table: "Usuarios");
        }
    }
}

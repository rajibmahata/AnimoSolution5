using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimoWeb.Server.Migrations
{
    public partial class lucasfinales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirmaEmail",
                table: "GlobalConfig");

            migrationBuilder.DropColumn(
                name: "FirmaPhone1",
                table: "GlobalConfig");

            migrationBuilder.DropColumn(
                name: "FirmaPhone2",
                table: "GlobalConfig");

            migrationBuilder.DropColumn(
                name: "FirmaZip",
                table: "GlobalConfig");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirmaEmail",
                table: "GlobalConfig",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaPhone1",
                table: "GlobalConfig",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaPhone2",
                table: "GlobalConfig",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaZip",
                table: "GlobalConfig",
                type: "TEXT",
                nullable: true);
        }
    }
}

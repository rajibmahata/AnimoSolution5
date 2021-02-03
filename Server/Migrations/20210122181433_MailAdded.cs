using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimoWeb.Server.Migrations
{
    public partial class MailAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MailDestination",
                table: "GlobalConfig",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MailDestination",
                table: "GlobalConfig");
        }
    }
}
